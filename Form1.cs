using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static task_indusoft.Form1;

namespace task_indusoft
{
    public partial class Form1 : Form
    {

        public class DataGenerator
        {
            private Random random;

            public DataGenerator()
            {
                random = new Random();
            }

            public float GenerateRandomValue()
            {
                return (float)random.NextDouble() * 200; // Пример случайного значения от 0 до 199
            }

            // Метод для генерации случайного имени сигнала
            public string GenerateRandomSignalName()
            {
                string[] signalNames = { "Sig1", "Sig2", "Sig3" };
                return signalNames[random.Next(signalNames.Length)];
            }
        }


        private Timer timer;

        private DataGenerator dataGenerator;

        public Form1()
        {
            InitializeComponent();
            LoadBoundariesFromDatabase();
            LoadEventsFromDatabase();
            InitializeTimer();
            LoadBoundaryEventsFromDatabase();
            dataGenerator = new DataGenerator();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 3000; // Установка интервала таймера в миллисекундах (1 секунда)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // Генерация данных и запись в базу данных
            GenerateAndSaveData();

        }

        private void GenerateAndSaveData()
        {
            float value = dataGenerator.GenerateRandomValue();
            string signal = dataGenerator.GenerateRandomSignalName();

            // Запись данных в базу данных TimeSeries
            string connectionString = @"Server=MSI-Y9\SQLEXPRESS;Database=base_test;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO TimeSeries (nameSignal, value, timeStamp) VALUES (@nameSignal, @value, @timeStamp)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nameSignal", signal);
                command.Parameters.AddWithValue("@value", value);
                command.Parameters.AddWithValue("@timeStamp", DateTime.Now);
                command.ExecuteNonQuery();
            }


                bool isTracingBoundariesEnabled = check_tracing_boundaries.Checked;
                if (isTracingBoundariesEnabled)
                {
                    float minBoundary = float.Parse(min_boundary.Text);
                    float maxBoundary = float.Parse(max_boundary.Text);
                    if (value < minBoundary || value > maxBoundary)
                    {
                        // Определение типа события
                        string eventType = value < minBoundary ? "Below Boundary" : "Above Boundary";

                        // Запись данных в базу данных BoundaryEvents
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO BoundaryEvents (nameSignal, [time], value, border, eventType) VALUES (@nameSignal, @timeStamp, @value, @border, @eventType)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@nameSignal", signal);
                            command.Parameters.AddWithValue("@timeStamp", DateTime.Now);
                            command.Parameters.AddWithValue("@value", value);
                            command.Parameters.AddWithValue("@border", value < minBoundary ? minBoundary : maxBoundary); // Граница, которую пересекло значение
                            command.Parameters.AddWithValue("@eventType", eventType);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            
        }
        private void LoadBoundariesFromDatabase()
        {
            string connectionString = @"Server=MSI-Y9\SQLEXPRESS;Database=base_test;Integrated Security=True;";
            string query = "SELECT lowBorder, highBorder FROM Borders WHERE nameSignal = @nameSignal";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nameSignal", comboBox1.SelectedItem?.ToString());

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        double lowBorder = reader.GetDouble(reader.GetOrdinal("lowBorder"));
                        double highBorder = reader.GetDouble(reader.GetOrdinal("highBorder"));

                        min_boundary.Text = lowBorder.ToString();
                        max_boundary.Text = highBorder.ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading boundaries from the database: " + ex.Message);
                }
            }
        }

        // Метод для загрузки событий из базы данных
        private void LoadEventsFromDatabase()
        {
            // Получение даты и времени из dateTimePicker1
            DateTime fromDate = dateTimePicker1.Value;

            // Получение даты и времени из dateTimePicker2
            DateTime toDate = dateTimePicker2.Value;

            // Проверка состояния флагов checkBox_time_from и checkBox_time_to
            if (!checkBox_time_from.Checked)
            {
                // Если флаг не установлен, используем минимальную дату
                fromDate = new DateTime(1753, 1, 1);
            }

            if (!checkBox_time_to.Checked)
            {
                // Если флаг не установлен, используем максимальную дату
                toDate = new DateTime(9999, 12, 31, 23, 59, 59);
            }

            // Очищаем ListBox перед загрузкой новых данных
            List_of_events.Items.Clear();
            // Подключение к базе данных
            string connectionString = @"Server=MSI-Y9\SQLEXPRESS;Database=base_test;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Создание команды для выполнения SQL-запроса
                string query = "SELECT * FROM TimeSeries WHERE timeStamp >= @fromDate AND timeStamp <= @toDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                // Выполнение команды и получение данных
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Получение значений из результата запроса
                    string nameSignal = reader["nameSignal"].ToString();
                    DateTime time = (DateTime)reader["timeStamp"];
                    double generatedValue = (double)reader["value"];

                    // Отображение данных в списке событий
                    List_of_events.Items.Add($"{time}: Signal '{nameSignal}' generated value {generatedValue}");
                }
                reader.Close();
            }
        }

        private void LoadBoundaryEventsFromDatabase()
        {

            // Получение имени сигнала из выпадающего списка
            string selectedSignal = comboBox1.SelectedItem?.ToString();

            // Получение даты и времени из dateTimePicker3
            DateTime fromDate = dateTimePicker3.Value;

            // Получение даты и времени из dateTimePicker4
            DateTime toDate = dateTimePicker4.Value;

            // Проверка состояния флагов checkBox_time_from_bound и checkBox_time_to_bound
            if (!checkBox_time_from_bound.Checked)
            {
                // Если флаг не установлен, используем минимальную дату
                fromDate = new DateTime(1753, 1, 1);
            }

            if (!checkBox_time_to_bound.Checked)
            {
                // Если флаг не установлен, используем максимальную дату
                toDate = new DateTime(9999, 12, 31, 23, 59, 59);
            }

            // Очищаем ListBox перед загрузкой новых данных
            Boundary_events.Items.Clear();


            // Подключение к базе данных
            string connectionString = @"Server=MSI-Y9\SQLEXPRESS;Database=base_test;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Создание команды для выполнения SQL-запроса
                string query = "SELECT * FROM BoundaryEvents WHERE [time] >= @fromDate AND [time] <= @toDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                // Выполнение команды и получение данных
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Получение значений из результата запроса
                    string nameSignal = reader["nameSignal"].ToString();
                    DateTime time = (DateTime)reader["time"];
                    double value = (double)reader["value"];
                    double border = (double)reader["border"];
                    string eventType = reader["eventType"].ToString();
                    
                    if (nameSignal == selectedSignal)
                    {
                        // Отображение данных в списке событий
                        Boundary_events.Items.Add($"{time}: Signal '{nameSignal}' {eventType} boundary value {border}, actual value {value}");
                    }

                }
                reader.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadEventsFromDatabase();
            LoadBoundaryEventsFromDatabase();
        }
    }
}

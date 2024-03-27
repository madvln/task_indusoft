using System.Windows.Forms;

namespace task_indusoft
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.min_boundary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max_boundary = new System.Windows.Forms.TextBox();
            this.check_tracing_boundaries = new System.Windows.Forms.CheckBox();
            this.List_of_events = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox_time_from = new System.Windows.Forms.CheckBox();
            this.checkBox_time_to = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Boundary_events = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_time_from_bound = new System.Windows.Forms.CheckBox();
            this.checkBox_time_to_bound = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sig1",
            "Sig2",
            "Sig3",
            "Sig4"});
            this.comboBox1.Location = new System.Drawing.Point(23, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Sig1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of signals";
            // 
            // min_boundary
            // 
            this.min_boundary.Location = new System.Drawing.Point(23, 139);
            this.min_boundary.Name = "min_boundary";
            this.min_boundary.Size = new System.Drawing.Size(102, 20);
            this.min_boundary.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Signal boundaries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max";
            // 
            // max_boundary
            // 
            this.max_boundary.Location = new System.Drawing.Point(131, 139);
            this.max_boundary.Name = "max_boundary";
            this.max_boundary.Size = new System.Drawing.Size(102, 20);
            this.max_boundary.TabIndex = 2;
            // 
            // check_tracing_boundaries
            // 
            this.check_tracing_boundaries.AutoSize = true;
            this.check_tracing_boundaries.Location = new System.Drawing.Point(23, 165);
            this.check_tracing_boundaries.Name = "check_tracing_boundaries";
            this.check_tracing_boundaries.Size = new System.Drawing.Size(117, 17);
            this.check_tracing_boundaries.TabIndex = 3;
            this.check_tracing_boundaries.Text = "Tracing boundaries";
            this.check_tracing_boundaries.UseVisualStyleBackColor = true;
            // 
            // List_of_events
            // 
            this.List_of_events.FormattingEnabled = true;
            this.List_of_events.Location = new System.Drawing.Point(370, 64);
            this.List_of_events.Name = "List_of_events";
            this.List_of_events.Size = new System.Drawing.Size(310, 303);
            this.List_of_events.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 26, 11, 52, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(334, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(537, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(573, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2024, 3, 26, 21, 45, 0, 0);
            // 
            // checkBox_time_from
            // 
            this.checkBox_time_from.AutoSize = true;
            this.checkBox_time_from.Location = new System.Drawing.Point(313, 38);
            this.checkBox_time_from.Name = "checkBox_time_from";
            this.checkBox_time_from.Size = new System.Drawing.Size(15, 14);
            this.checkBox_time_from.TabIndex = 3;
            this.checkBox_time_from.UseVisualStyleBackColor = true;
            // 
            // checkBox_time_to
            // 
            this.checkBox_time_to.AutoSize = true;
            this.checkBox_time_to.Location = new System.Drawing.Point(517, 38);
            this.checkBox_time_to.Name = "checkBox_time_to";
            this.checkBox_time_to.Size = new System.Drawing.Size(15, 14);
            this.checkBox_time_to.TabIndex = 3;
            this.checkBox_time_to.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Boundary_events
            // 
            this.Boundary_events.FormattingEnabled = true;
            this.Boundary_events.Location = new System.Drawing.Point(786, 61);
            this.Boundary_events.Name = "Boundary_events";
            this.Boundary_events.Size = new System.Drawing.Size(445, 303);
            this.Boundary_events.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(750, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(953, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "To";
            // 
            // checkBox_time_from_bound
            // 
            this.checkBox_time_from_bound.AutoSize = true;
            this.checkBox_time_from_bound.Location = new System.Drawing.Point(729, 38);
            this.checkBox_time_from_bound.Name = "checkBox_time_from_bound";
            this.checkBox_time_from_bound.Size = new System.Drawing.Size(15, 14);
            this.checkBox_time_from_bound.TabIndex = 3;
            this.checkBox_time_from_bound.UseVisualStyleBackColor = true;
            // 
            // checkBox_time_to_bound
            // 
            this.checkBox_time_to_bound.AutoSize = true;
            this.checkBox_time_to_bound.Location = new System.Drawing.Point(933, 38);
            this.checkBox_time_to_bound.Name = "checkBox_time_to_bound";
            this.checkBox_time_to_bound.Size = new System.Drawing.Size(15, 14);
            this.checkBox_time_to_bound.TabIndex = 3;
            this.checkBox_time_to_bound.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(786, 38);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker3.TabIndex = 6;
            this.dateTimePicker3.Value = new System.DateTime(2024, 3, 26, 11, 52, 0, 0);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(989, 38);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker4.TabIndex = 6;
            this.dateTimePicker4.Value = new System.DateTime(2024, 3, 26, 21, 45, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Boundary_events);
            this.Controls.Add(this.checkBox_time_to_bound);
            this.Controls.Add(this.List_of_events);
            this.Controls.Add(this.checkBox_time_from_bound);
            this.Controls.Add(this.checkBox_time_to);
            this.Controls.Add(this.checkBox_time_from);
            this.Controls.Add(this.check_tracing_boundaries);
            this.Controls.Add(this.max_boundary);
            this.Controls.Add(this.min_boundary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox min_boundary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox max_boundary;
        private System.Windows.Forms.CheckBox check_tracing_boundaries;
        private System.Windows.Forms.ListBox List_of_events;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private CheckBox checkBox_time_from;
        private CheckBox checkBox_time_to;
        private Button button1;
        private ListBox Boundary_events;
        private Label label7;
        private Label label8;
        private CheckBox checkBox_time_from_bound;
        private CheckBox checkBox_time_to_bound;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
    }
}


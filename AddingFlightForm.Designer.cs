namespace Airport
{
    partial class AddingFlightForm
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
            dataGridViewAirplanes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridViewAirports = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBoxOut = new ComboBox();
            comboBoxIn = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            comboBoxDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirplanes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirports).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAirplanes
            // 
            dataGridViewAirplanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAirplanes.Location = new Point(879, 356);
            dataGridViewAirplanes.Name = "dataGridViewAirplanes";
            dataGridViewAirplanes.Size = new Size(711, 323);
            dataGridViewAirplanes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1178, 306);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 1;
            label1.Text = "Самолеты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(311, 306);
            label2.Name = "label2";
            label2.Size = new Size(156, 37);
            label2.TabIndex = 2;
            label2.Text = "Аэропорты";
            // 
            // dataGridViewAirports
            // 
            dataGridViewAirports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAirports.Location = new Point(15, 356);
            dataGridViewAirports.Name = "dataGridViewAirports";
            dataGridViewAirports.Size = new Size(810, 323);
            dataGridViewAirports.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(347, 37);
            label3.TabIndex = 4;
            label3.Text = "Введите параметры рейса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(91, 67);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 5;
            label4.Text = "Самолет:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(79, 189);
            label5.Name = "label5";
            label5.Size = new Size(109, 37);
            label5.TabIndex = 6;
            label5.Text = "Откуда:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 36);
            comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(359, 189);
            label6.Name = "label6";
            label6.Size = new Size(81, 37);
            label6.TabIndex = 8;
            label6.Text = "Куда:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxOut
            // 
            comboBoxOut.Font = new Font("Segoe UI", 15F);
            comboBoxOut.FormattingEnabled = true;
            comboBoxOut.Location = new Point(15, 229);
            comboBoxOut.Name = "comboBoxOut";
            comboBoxOut.Size = new Size(258, 36);
            comboBoxOut.TabIndex = 9;
            // 
            // comboBoxIn
            // 
            comboBoxIn.Font = new Font("Segoe UI", 15F);
            comboBoxIn.FormattingEnabled = true;
            comboBoxIn.Location = new Point(300, 229);
            comboBoxIn.Name = "comboBoxIn";
            comboBoxIn.Size = new Size(207, 36);
            comboBoxIn.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(379, 90);
            button1.Name = "button1";
            button1.Size = new Size(232, 62);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(682, 189);
            label7.Name = "label7";
            label7.Size = new Size(81, 37);
            label7.TabIndex = 12;
            label7.Text = "Дата:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDate
            // 
            comboBoxDate.Font = new Font("Segoe UI", 15F);
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(610, 229);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(224, 36);
            comboBoxDate.TabIndex = 13;
            // 
            // AddingFlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 691);
            Controls.Add(comboBoxDate);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(comboBoxIn);
            Controls.Add(comboBoxOut);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewAirports);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAirplanes);
            Name = "AddingFlightForm";
            Text = "AddingFlightForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirplanes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAirplanes;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewAirports;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBoxOut;
        private ComboBox comboBoxIn;
        private Button button1;
        private Label label7;
        private ComboBox comboBoxDate;
    }
}
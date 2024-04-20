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
            dataGridViewPositions = new DataGridView();
            label8 = new Label();
            dataGridViewPersonal = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            dataGridViewServices = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirplanes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAirports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAirplanes
            // 
            dataGridViewAirplanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAirplanes.Location = new Point(12, 84);
            dataGridViewAirplanes.Name = "dataGridViewAirplanes";
            dataGridViewAirplanes.Size = new Size(347, 175);
            dataGridViewAirplanes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(84, 44);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 1;
            label1.Text = "Самолеты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(591, 44);
            label2.Name = "label2";
            label2.Size = new Size(156, 37);
            label2.TabIndex = 2;
            label2.Text = "Аэропорты";
            // 
            // dataGridViewAirports
            // 
            dataGridViewAirports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAirports.Location = new Point(402, 84);
            dataGridViewAirports.Name = "dataGridViewAirports";
            dataGridViewAirports.Size = new Size(506, 175);
            dataGridViewAirports.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 288);
            label3.Name = "label3";
            label3.Size = new Size(347, 37);
            label3.TabIndex = 4;
            label3.Text = "Введите параметры рейса:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 349);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 5;
            label4.Text = "Самолет:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(12, 474);
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
            comboBox1.Location = new Point(12, 402);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 36);
            comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(210, 474);
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
            comboBoxOut.Location = new Point(12, 524);
            comboBoxOut.Name = "comboBoxOut";
            comboBoxOut.Size = new Size(155, 36);
            comboBoxOut.TabIndex = 9;
            // 
            // comboBoxIn
            // 
            comboBoxIn.Font = new Font("Segoe UI", 15F);
            comboBoxIn.FormattingEnabled = true;
            comboBoxIn.Location = new Point(210, 524);
            comboBoxIn.Name = "comboBoxIn";
            comboBoxIn.Size = new Size(155, 36);
            comboBoxIn.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 594);
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
            label7.Location = new Point(499, 474);
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
            comboBoxDate.Location = new Point(429, 524);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(224, 36);
            comboBoxDate.TabIndex = 13;
            // 
            // dataGridViewPositions
            // 
            dataGridViewPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositions.Location = new Point(954, 84);
            dataGridViewPositions.Name = "dataGridViewPositions";
            dataGridViewPositions.Size = new Size(248, 175);
            dataGridViewPositions.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(995, 44);
            label8.Name = "label8";
            label8.Size = new Size(157, 37);
            label8.TabIndex = 15;
            label8.Text = "Должности";
            // 
            // dataGridViewPersonal
            // 
            dataGridViewPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonal.Location = new Point(896, 402);
            dataGridViewPersonal.Name = "dataGridViewPersonal";
            dataGridViewPersonal.Size = new Size(663, 270);
            dataGridViewPersonal.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(1111, 349);
            label9.Name = "label9";
            label9.Size = new Size(166, 37);
            label9.TabIndex = 17;
            label9.Text = "Сотрудники";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(1328, 44);
            label10.Name = "label10";
            label10.Size = new Size(116, 37);
            label10.TabIndex = 18;
            label10.Text = "Службы";
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(1271, 84);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.Size = new Size(288, 175);
            dataGridViewServices.TabIndex = 19;
            // 
            // AddingFlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 691);
            Controls.Add(dataGridViewServices);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridViewPersonal);
            Controls.Add(label8);
            Controls.Add(dataGridViewPositions);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
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
        private DataGridView dataGridViewPositions;
        private Label label8;
        private DataGridView dataGridViewPersonal;
        private Label label9;
        private Label label10;
        private DataGridView dataGridViewServices;
    }
}
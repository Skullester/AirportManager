namespace Airport
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            labelCurrentFlights = new Label();
            dataGridViewDestinations = new DataGridView();
            button1 = new Button();
            comboBoxReport = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            comboBoxAirports = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelCurrentFlights
            // 
            labelCurrentFlights.AutoSize = true;
            labelCurrentFlights.Font = new Font("Segoe UI", 22F);
            labelCurrentFlights.Location = new Point(701, 46);
            labelCurrentFlights.Name = "labelCurrentFlights";
            labelCurrentFlights.Size = new Size(239, 41);
            labelCurrentFlights.TabIndex = 1;
            labelCurrentFlights.Text = "Текущие рейсы:";
            // 
            // dataGridViewDestinations
            // 
            dataGridViewDestinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDestinations.Location = new Point(417, 104);
            dataGridViewDestinations.Name = "dataGridViewDestinations";
            dataGridViewDestinations.Size = new Size(814, 480);
            dataGridViewDestinations.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 533);
            button1.Name = "button1";
            button1.Size = new Size(254, 51);
            button1.TabIndex = 3;
            button1.Text = "Добавить рейс";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddFlight;
            // 
            // comboBoxReport
            // 
            comboBoxReport.Font = new Font("Segoe UI", 15F);
            comboBoxReport.FormattingEnabled = true;
            comboBoxReport.Location = new Point(12, 249);
            comboBoxReport.Name = "comboBoxReport";
            comboBoxReport.Size = new Size(379, 36);
            comboBoxReport.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 5;
            label1.Text = "Отчет:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(12, 476);
            button2.Name = "button2";
            button2.Size = new Size(254, 51);
            button2.TabIndex = 6;
            button2.Text = "Составить отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MakeReport;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 298);
            label2.Name = "label2";
            label2.Size = new Size(372, 37);
            label2.TabIndex = 8;
            label2.Text = "Аэропорт конечного пункта:";
            // 
            // comboBoxAirports
            // 
            comboBoxAirports.Font = new Font("Segoe UI", 15F);
            comboBoxAirports.FormattingEnabled = true;
            comboBoxAirports.Location = new Point(12, 338);
            comboBoxAirports.Name = "comboBoxAirports";
            comboBoxAirports.Size = new Size(227, 36);
            comboBoxAirports.TabIndex = 9;
            // 
            // MainForm
            // 
            ClientSize = new Size(1292, 645);
            Controls.Add(dataGridViewDestinations);
            Controls.Add(comboBoxAirports);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBoxReport);
            Controls.Add(button1);
            Controls.Add(labelCurrentFlights);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "AIRPLANE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDestinations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCurrentFlights;
        private DataGridView dataGridViewDestinations;
        private Button button1;
        private ComboBox comboBoxReport;
        private Label label1;
        private Button button2;
        private Label label2;
        public ComboBox comboBoxAirports;
    }
}
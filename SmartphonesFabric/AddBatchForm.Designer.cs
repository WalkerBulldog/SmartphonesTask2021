namespace SmartphonesFabric
{
    partial class AddBatchForm
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
            this.RadioLLP = new System.Windows.Forms.RadioButton();
            this.RadioPBP = new System.Windows.Forms.RadioButton();
            this.RadioSP = new System.Windows.Forms.RadioButton();
            this.AOHcheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.FreeHandsCheckBox = new System.Windows.Forms.CheckBox();
            this.AnsweringMachineCheckBox = new System.Windows.Forms.CheckBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.MaskedTextBox();
            this.SimCardCountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScreenDiagonalScrollBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagonalLabel = new System.Windows.Forms.Label();
            this.MemoryBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MemoryCardCheckBox = new System.Windows.Forms.CheckBox();
            this.CameraBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CameraMPLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BattaryBox = new System.Windows.Forms.MaskedTextBox();
            this.OSPanel = new System.Windows.Forms.Panel();
            this.RadioAndroid = new System.Windows.Forms.RadioButton();
            this.RadioIOS = new System.Windows.Forms.RadioButton();
            this.RadioWindows = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CPUcomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddPhoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenDiagonalScrollBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBar)).BeginInit();
            this.OSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioLLP
            // 
            this.RadioLLP.AutoSize = true;
            this.RadioLLP.Location = new System.Drawing.Point(66, 64);
            this.RadioLLP.Name = "RadioLLP";
            this.RadioLLP.Size = new System.Drawing.Size(189, 21);
            this.RadioLLP.TabIndex = 0;
            this.RadioLLP.TabStop = true;
            this.RadioLLP.Text = "Стационарный телефон";
            this.RadioLLP.UseVisualStyleBackColor = true;
            this.RadioLLP.CheckedChanged += new System.EventHandler(this.RadioLLP_CheckedChanged);
            // 
            // RadioPBP
            // 
            this.RadioPBP.AutoSize = true;
            this.RadioPBP.Location = new System.Drawing.Point(383, 64);
            this.RadioPBP.Name = "RadioPBP";
            this.RadioPBP.Size = new System.Drawing.Size(166, 21);
            this.RadioPBP.TabIndex = 1;
            this.RadioPBP.TabStop = true;
            this.RadioPBP.Text = "Кнопочный телефон";
            this.RadioPBP.UseVisualStyleBackColor = true;
            this.RadioPBP.CheckedChanged += new System.EventHandler(this.RadioPBP_CheckedChanged);
            // 
            // RadioSP
            // 
            this.RadioSP.AutoSize = true;
            this.RadioSP.Location = new System.Drawing.Point(763, 64);
            this.RadioSP.Name = "RadioSP";
            this.RadioSP.Size = new System.Drawing.Size(97, 21);
            this.RadioSP.TabIndex = 2;
            this.RadioSP.TabStop = true;
            this.RadioSP.Text = "Смартфон";
            this.RadioSP.UseVisualStyleBackColor = true;
            this.RadioSP.CheckedChanged += new System.EventHandler(this.RadioSP_CheckedChanged);
            // 
            // AOHcheckBox
            // 
            this.AOHcheckBox.AutoSize = true;
            this.AOHcheckBox.Location = new System.Drawing.Point(66, 114);
            this.AOHcheckBox.Name = "AOHcheckBox";
            this.AOHcheckBox.Size = new System.Drawing.Size(180, 21);
            this.AOHcheckBox.TabIndex = 3;
            this.AOHcheckBox.Text = "Определитель номера";
            this.AOHcheckBox.UseVisualStyleBackColor = true;
            // 
            // DisplayCheckBox
            // 
            this.DisplayCheckBox.AutoSize = true;
            this.DisplayCheckBox.Location = new System.Drawing.Point(66, 141);
            this.DisplayCheckBox.Name = "DisplayCheckBox";
            this.DisplayCheckBox.Size = new System.Drawing.Size(88, 21);
            this.DisplayCheckBox.TabIndex = 4;
            this.DisplayCheckBox.Text = "Дисплей";
            this.DisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FreeHandsCheckBox
            // 
            this.FreeHandsCheckBox.AutoSize = true;
            this.FreeHandsCheckBox.Location = new System.Drawing.Point(66, 168);
            this.FreeHandsCheckBox.Name = "FreeHandsCheckBox";
            this.FreeHandsCheckBox.Size = new System.Drawing.Size(126, 21);
            this.FreeHandsCheckBox.TabIndex = 5;
            this.FreeHandsCheckBox.Text = "Громкая связь";
            this.FreeHandsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnsweringMachineCheckBox
            // 
            this.AnsweringMachineCheckBox.AutoSize = true;
            this.AnsweringMachineCheckBox.Location = new System.Drawing.Point(66, 195);
            this.AnsweringMachineCheckBox.Name = "AnsweringMachineCheckBox";
            this.AnsweringMachineCheckBox.Size = new System.Drawing.Size(121, 21);
            this.AnsweringMachineCheckBox.TabIndex = 6;
            this.AnsweringMachineCheckBox.Text = "Автоответчик";
            this.AnsweringMachineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(66, 292);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(160, 22);
            this.ModelTextBox.TabIndex = 7;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(66, 342);
            this.CostBox.Mask = "00000";
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 22);
            this.CostBox.TabIndex = 8;
            this.CostBox.ValidatingType = typeof(int);
            // 
            // SimCardCountComboBox
            // 
            this.SimCardCountComboBox.FormattingEnabled = true;
            this.SimCardCountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SimCardCountComboBox.Location = new System.Drawing.Point(383, 128);
            this.SimCardCountComboBox.Name = "SimCardCountComboBox";
            this.SimCardCountComboBox.Size = new System.Drawing.Size(121, 24);
            this.SimCardCountComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество сим-карт:";
            // 
            // ScreenDiagonalScrollBar
            // 
            this.ScreenDiagonalScrollBar.Location = new System.Drawing.Point(383, 180);
            this.ScreenDiagonalScrollBar.Maximum = 150;
            this.ScreenDiagonalScrollBar.Minimum = 10;
            this.ScreenDiagonalScrollBar.Name = "ScreenDiagonalScrollBar";
            this.ScreenDiagonalScrollBar.Size = new System.Drawing.Size(498, 56);
            this.ScreenDiagonalScrollBar.TabIndex = 11;
            this.ScreenDiagonalScrollBar.Value = 10;
            this.ScreenDiagonalScrollBar.Scroll += new System.EventHandler(this.ScreenDiagonalScrollBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Диагональ экрана, дюймов:";
            // 
            // DiagonalLabel
            // 
            this.DiagonalLabel.AutoSize = true;
            this.DiagonalLabel.Location = new System.Drawing.Point(581, 219);
            this.DiagonalLabel.Name = "DiagonalLabel";
            this.DiagonalLabel.Size = new System.Drawing.Size(13, 17);
            this.DiagonalLabel.TabIndex = 13;
            this.DiagonalLabel.Text = "-";
            // 
            // MemoryBox
            // 
            this.MemoryBox.Location = new System.Drawing.Point(558, 130);
            this.MemoryBox.Mask = "00000";
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Size = new System.Drawing.Size(100, 22);
            this.MemoryBox.TabIndex = 14;
            this.MemoryBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Память, мб:";
            // 
            // MemoryCardCheckBox
            // 
            this.MemoryCardCheckBox.AutoSize = true;
            this.MemoryCardCheckBox.Location = new System.Drawing.Point(685, 132);
            this.MemoryCardCheckBox.Name = "MemoryCardCheckBox";
            this.MemoryCardCheckBox.Size = new System.Drawing.Size(113, 21);
            this.MemoryCardCheckBox.TabIndex = 16;
            this.MemoryCardCheckBox.Text = "Слот под SD";
            this.MemoryCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // CameraBar
            // 
            this.CameraBar.Location = new System.Drawing.Point(383, 258);
            this.CameraBar.Maximum = 32;
            this.CameraBar.Minimum = 1;
            this.CameraBar.Name = "CameraBar";
            this.CameraBar.Size = new System.Drawing.Size(239, 56);
            this.CameraBar.TabIndex = 17;
            this.CameraBar.Value = 10;
            this.CameraBar.Scroll += new System.EventHandler(this.CameraBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Камера, мегапикселей:\r\n";
            // 
            // CameraMPLabel
            // 
            this.CameraMPLabel.AutoSize = true;
            this.CameraMPLabel.Location = new System.Drawing.Point(551, 306);
            this.CameraMPLabel.Name = "CameraMPLabel";
            this.CameraMPLabel.Size = new System.Drawing.Size(13, 17);
            this.CameraMPLabel.TabIndex = 19;
            this.CameraMPLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ёмкость батареи, мАч:";
            // 
            // BattaryBox
            // 
            this.BattaryBox.Location = new System.Drawing.Point(685, 281);
            this.BattaryBox.Mask = "00000";
            this.BattaryBox.Name = "BattaryBox";
            this.BattaryBox.Size = new System.Drawing.Size(100, 22);
            this.BattaryBox.TabIndex = 20;
            this.BattaryBox.ValidatingType = typeof(int);
            // 
            // OSPanel
            // 
            this.OSPanel.Controls.Add(this.RadioWindows);
            this.OSPanel.Controls.Add(this.RadioIOS);
            this.OSPanel.Controls.Add(this.RadioAndroid);
            this.OSPanel.Location = new System.Drawing.Point(383, 382);
            this.OSPanel.Name = "OSPanel";
            this.OSPanel.Size = new System.Drawing.Size(200, 100);
            this.OSPanel.TabIndex = 22;
            // 
            // RadioAndroid
            // 
            this.RadioAndroid.AutoSize = true;
            this.RadioAndroid.Location = new System.Drawing.Point(4, 4);
            this.RadioAndroid.Name = "RadioAndroid";
            this.RadioAndroid.Size = new System.Drawing.Size(78, 21);
            this.RadioAndroid.TabIndex = 0;
            this.RadioAndroid.TabStop = true;
            this.RadioAndroid.Text = "Android";
            this.RadioAndroid.UseVisualStyleBackColor = true;
            // 
            // RadioIOS
            // 
            this.RadioIOS.AutoSize = true;
            this.RadioIOS.Location = new System.Drawing.Point(4, 31);
            this.RadioIOS.Name = "RadioIOS";
            this.RadioIOS.Size = new System.Drawing.Size(52, 21);
            this.RadioIOS.TabIndex = 1;
            this.RadioIOS.TabStop = true;
            this.RadioIOS.Text = "iOS";
            this.RadioIOS.UseVisualStyleBackColor = true;
            // 
            // RadioWindows
            // 
            this.RadioWindows.AutoSize = true;
            this.RadioWindows.Location = new System.Drawing.Point(4, 58);
            this.RadioWindows.Name = "RadioWindows";
            this.RadioWindows.Size = new System.Drawing.Size(85, 21);
            this.RadioWindows.TabIndex = 2;
            this.RadioWindows.TabStop = true;
            this.RadioWindows.Text = "Windows";
            this.RadioWindows.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Операционная система:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Количество ядер процессора:";
            // 
            // CPUcomboBox
            // 
            this.CPUcomboBox.FormattingEnabled = true;
            this.CPUcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "16"});
            this.CPUcomboBox.Location = new System.Drawing.Point(638, 398);
            this.CPUcomboBox.Name = "CPUcomboBox";
            this.CPUcomboBox.Size = new System.Drawing.Size(121, 24);
            this.CPUcomboBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Модель:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Стоимость:";
            // 
            // AddPhoneButton
            // 
            this.AddPhoneButton.Location = new System.Drawing.Point(66, 458);
            this.AddPhoneButton.Name = "AddPhoneButton";
            this.AddPhoneButton.Size = new System.Drawing.Size(100, 23);
            this.AddPhoneButton.TabIndex = 28;
            this.AddPhoneButton.Text = "Добавить";
            this.AddPhoneButton.UseVisualStyleBackColor = true;
            this.AddPhoneButton.Click += new System.EventHandler(this.AddPhoneButton_Click);
            // 
            // AddBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 508);
            this.Controls.Add(this.AddPhoneButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CPUcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OSPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BattaryBox);
            this.Controls.Add(this.CameraMPLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraBar);
            this.Controls.Add(this.MemoryCardCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemoryBox);
            this.Controls.Add(this.DiagonalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScreenDiagonalScrollBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimCardCountComboBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.AnsweringMachineCheckBox);
            this.Controls.Add(this.FreeHandsCheckBox);
            this.Controls.Add(this.DisplayCheckBox);
            this.Controls.Add(this.AOHcheckBox);
            this.Controls.Add(this.RadioSP);
            this.Controls.Add(this.RadioPBP);
            this.Controls.Add(this.RadioLLP);
            this.Name = "AddBatchForm";
            this.Text = "Телефон";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenDiagonalScrollBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBar)).EndInit();
            this.OSPanel.ResumeLayout(false);
            this.OSPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioLLP;
        private System.Windows.Forms.RadioButton RadioPBP;
        private System.Windows.Forms.RadioButton RadioSP;
        private System.Windows.Forms.CheckBox AOHcheckBox;
        private System.Windows.Forms.CheckBox DisplayCheckBox;
        private System.Windows.Forms.CheckBox FreeHandsCheckBox;
        private System.Windows.Forms.CheckBox AnsweringMachineCheckBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.MaskedTextBox CostBox;
        private System.Windows.Forms.ComboBox SimCardCountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ScreenDiagonalScrollBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DiagonalLabel;
        private System.Windows.Forms.MaskedTextBox MemoryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MemoryCardCheckBox;
        private System.Windows.Forms.TrackBar CameraBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CameraMPLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox BattaryBox;
        private System.Windows.Forms.Panel OSPanel;
        private System.Windows.Forms.RadioButton RadioWindows;
        private System.Windows.Forms.RadioButton RadioIOS;
        private System.Windows.Forms.RadioButton RadioAndroid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CPUcomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddPhoneButton;
    }
}
namespace SmartphonesFabric
{
    partial class FactoryViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BatchesView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BatchInfoLabel = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBatchButton = new System.Windows.Forms.Button();
            this.DeleteBatchButton = new System.Windows.Forms.Button();
            this.DateBatchPicker = new System.Windows.Forms.DateTimePicker();
            this.CountBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BatchInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BatchesView
            // 
            this.BatchesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.BatchesView.FullRowSelect = true;
            this.BatchesView.GridLines = true;
            this.BatchesView.HideSelection = false;
            this.BatchesView.Location = new System.Drawing.Point(12, 12);
            this.BatchesView.Name = "BatchesView";
            this.BatchesView.Size = new System.Drawing.Size(462, 436);
            this.BatchesView.TabIndex = 0;
            this.BatchesView.UseCompatibleStateImageBehavior = false;
            this.BatchesView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№ партии";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип телефона";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Модель";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество";
            this.columnHeader4.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация:";
            // 
            // BatchInfoLabel
            // 
            this.BatchInfoLabel.AutoSize = true;
            this.BatchInfoLabel.Location = new System.Drawing.Point(495, 47);
            this.BatchInfoLabel.Name = "BatchInfoLabel";
            this.BatchInfoLabel.Size = new System.Drawing.Size(130, 17);
            this.BatchInfoLabel.TabIndex = 2;
            this.BatchInfoLabel.Text = "Выберите партию!";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Стоимость";
            this.columnHeader5.Width = 88;
            // 
            // AddBatchButton
            // 
            this.AddBatchButton.Location = new System.Drawing.Point(498, 415);
            this.AddBatchButton.Name = "AddBatchButton";
            this.AddBatchButton.Size = new System.Drawing.Size(142, 23);
            this.AddBatchButton.TabIndex = 3;
            this.AddBatchButton.Text = "Создать паритю";
            this.AddBatchButton.UseVisualStyleBackColor = true;
            this.AddBatchButton.Click += new System.EventHandler(this.AddBatchButton_Click);
            // 
            // DeleteBatchButton
            // 
            this.DeleteBatchButton.Location = new System.Drawing.Point(659, 415);
            this.DeleteBatchButton.Name = "DeleteBatchButton";
            this.DeleteBatchButton.Size = new System.Drawing.Size(142, 23);
            this.DeleteBatchButton.TabIndex = 4;
            this.DeleteBatchButton.Text = "Удалить паритю";
            this.DeleteBatchButton.UseVisualStyleBackColor = true;
            this.DeleteBatchButton.Click += new System.EventHandler(this.DeleteBatchButton_Click);
            // 
            // DateBatchPicker
            // 
            this.DateBatchPicker.Location = new System.Drawing.Point(498, 377);
            this.DateBatchPicker.Name = "DateBatchPicker";
            this.DateBatchPicker.Size = new System.Drawing.Size(303, 22);
            this.DateBatchPicker.TabIndex = 5;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(498, 338);
            this.CountBox.Mask = "00000";
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 22);
            this.CountBox.TabIndex = 6;
            this.CountBox.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество телефонов:";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата";
            // 
            // BatchInfoButton
            // 
            this.BatchInfoButton.Location = new System.Drawing.Point(659, 336);
            this.BatchInfoButton.Name = "BatchInfoButton";
            this.BatchInfoButton.Size = new System.Drawing.Size(142, 23);
            this.BatchInfoButton.TabIndex = 8;
            this.BatchInfoButton.Text = "Информация";
            this.BatchInfoButton.UseVisualStyleBackColor = true;
            this.BatchInfoButton.Click += new System.EventHandler(this.BatchInfoButton_Click);
            // 
            // FactoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.BatchInfoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.DateBatchPicker);
            this.Controls.Add(this.DeleteBatchButton);
            this.Controls.Add(this.AddBatchButton);
            this.Controls.Add(this.BatchInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BatchesView);
            this.Name = "FactoryViewForm";
            this.Text = "Фабрика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BatchesView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BatchInfoLabel;
        private System.Windows.Forms.Button AddBatchButton;
        private System.Windows.Forms.Button DeleteBatchButton;
        private System.Windows.Forms.DateTimePicker DateBatchPicker;
        private System.Windows.Forms.MaskedTextBox CountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button BatchInfoButton;
    }
}


namespace Hotel_SA
{
    partial class ChargeService
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
            this.RoomNumber_lbl = new System.Windows.Forms.Label();
            this.PaidServices_list = new System.Windows.Forms.ListBox();
            this.Service_list = new System.Windows.Forms.ListBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Count_lbl = new System.Windows.Forms.Label();
            this.Count_numeric = new System.Windows.Forms.NumericUpDown();
            this.PaidServices_lbl = new System.Windows.Forms.Label();
            this.Service_lbl = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Charge_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.RoomNumber_combobox = new System.Windows.Forms.ComboBox();
            this.Sum_lbl = new System.Windows.Forms.Label();
            this.SumValue_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Count_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomNumber_lbl
            // 
            this.RoomNumber_lbl.AutoSize = true;
            this.RoomNumber_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNumber_lbl.Location = new System.Drawing.Point(13, 13);
            this.RoomNumber_lbl.Name = "RoomNumber_lbl";
            this.RoomNumber_lbl.Size = new System.Drawing.Size(142, 20);
            this.RoomNumber_lbl.TabIndex = 0;
            this.RoomNumber_lbl.Text = "Номер комнаты";
            // 
            // PaidServices_list
            // 
            this.PaidServices_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaidServices_list.FormattingEnabled = true;
            this.PaidServices_list.ItemHeight = 20;
            this.PaidServices_list.Location = new System.Drawing.Point(17, 134);
            this.PaidServices_list.Name = "PaidServices_list";
            this.PaidServices_list.ScrollAlwaysVisible = true;
            this.PaidServices_list.Size = new System.Drawing.Size(266, 244);
            this.PaidServices_list.TabIndex = 2;
            // 
            // Service_list
            // 
            this.Service_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Service_list.FormattingEnabled = true;
            this.Service_list.ItemHeight = 20;
            this.Service_list.Location = new System.Drawing.Point(375, 134);
            this.Service_list.Name = "Service_list";
            this.Service_list.ScrollAlwaysVisible = true;
            this.Service_list.Size = new System.Drawing.Size(266, 244);
            this.Service_list.TabIndex = 3;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_btn.BackgroundImage = global::Hotel_SA.Properties.Resources.arrow_right;
            this.Add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_btn.Location = new System.Drawing.Point(289, 188);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(80, 42);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Count_lbl
            // 
            this.Count_lbl.AutoSize = true;
            this.Count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_lbl.Location = new System.Drawing.Point(13, 51);
            this.Count_lbl.Name = "Count_lbl";
            this.Count_lbl.Size = new System.Drawing.Size(109, 20);
            this.Count_lbl.TabIndex = 5;
            this.Count_lbl.Text = "Количество";
            // 
            // Count_numeric
            // 
            this.Count_numeric.Location = new System.Drawing.Point(161, 51);
            this.Count_numeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Count_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_numeric.Name = "Count_numeric";
            this.Count_numeric.Size = new System.Drawing.Size(120, 22);
            this.Count_numeric.TabIndex = 7;
            this.Count_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PaidServices_lbl
            // 
            this.PaidServices_lbl.AutoSize = true;
            this.PaidServices_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaidServices_lbl.Location = new System.Drawing.Point(13, 111);
            this.PaidServices_lbl.Name = "PaidServices_lbl";
            this.PaidServices_lbl.Size = new System.Drawing.Size(192, 20);
            this.PaidServices_lbl.TabIndex = 8;
            this.PaidServices_lbl.Text = "Список платных услуг";
            // 
            // Service_lbl
            // 
            this.Service_lbl.AutoSize = true;
            this.Service_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Service_lbl.Location = new System.Drawing.Point(371, 111);
            this.Service_lbl.Name = "Service_lbl";
            this.Service_lbl.Size = new System.Drawing.Size(223, 20);
            this.Service_lbl.TabIndex = 9;
            this.Service_lbl.Text = "Предоставленные услуги";
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackgroundImage = global::Hotel_SA.Properties.Resources.image_trash;
            this.Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.Location = new System.Drawing.Point(289, 315);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(80, 63);
            this.Clear_btn.TabIndex = 15;
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Charge_btn
            // 
            this.Charge_btn.Enabled = false;
            this.Charge_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Charge_btn.Location = new System.Drawing.Point(375, 10);
            this.Charge_btn.Name = "Charge_btn";
            this.Charge_btn.Size = new System.Drawing.Size(266, 60);
            this.Charge_btn.TabIndex = 16;
            this.Charge_btn.Text = "Записать на комнату";
            this.Charge_btn.UseVisualStyleBackColor = true;
            this.Charge_btn.Click += new System.EventHandler(this.Charge_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Remove_btn.BackgroundImage = global::Hotel_SA.Properties.Resources.arrow_left;
            this.Remove_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Remove_btn.Location = new System.Drawing.Point(289, 236);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(80, 42);
            this.Remove_btn.TabIndex = 17;
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // RoomNumber_combobox
            // 
            this.RoomNumber_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RoomNumber_combobox.FormattingEnabled = true;
            this.RoomNumber_combobox.Location = new System.Drawing.Point(160, 13);
            this.RoomNumber_combobox.Name = "RoomNumber_combobox";
            this.RoomNumber_combobox.Size = new System.Drawing.Size(123, 24);
            this.RoomNumber_combobox.TabIndex = 18;
            // 
            // Sum_lbl
            // 
            this.Sum_lbl.AutoSize = true;
            this.Sum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_lbl.Location = new System.Drawing.Point(205, 87);
            this.Sum_lbl.Name = "Sum_lbl";
            this.Sum_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sum_lbl.Size = new System.Drawing.Size(78, 20);
            this.Sum_lbl.TabIndex = 19;
            this.Sum_lbl.Text = " Сумма :";
            // 
            // SumValue_lbl
            // 
            this.SumValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumValue_lbl.Location = new System.Drawing.Point(289, 87);
            this.SumValue_lbl.Name = "SumValue_lbl";
            this.SumValue_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumValue_lbl.Size = new System.Drawing.Size(80, 20);
            this.SumValue_lbl.TabIndex = 20;
            this.SumValue_lbl.Text = "0";
            this.SumValue_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Charge_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 390);
            this.Controls.Add(this.SumValue_lbl);
            this.Controls.Add(this.Sum_lbl);
            this.Controls.Add(this.RoomNumber_combobox);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Charge_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Service_lbl);
            this.Controls.Add(this.PaidServices_lbl);
            this.Controls.Add(this.Count_numeric);
            this.Controls.Add(this.Count_lbl);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Service_list);
            this.Controls.Add(this.PaidServices_list);
            this.Controls.Add(this.RoomNumber_lbl);
            this.Name = "ChargeService";
            this.Text = "Оказание услуг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Count_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomNumber_lbl;
        private System.Windows.Forms.ListBox PaidServices_list;
        private System.Windows.Forms.ListBox Service_list;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label Count_lbl;
        private System.Windows.Forms.NumericUpDown Count_numeric;
        private System.Windows.Forms.Label PaidServices_lbl;
        private System.Windows.Forms.Label Service_lbl;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Charge_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.ComboBox RoomNumber_combobox;
        private System.Windows.Forms.Label Sum_lbl;
        private System.Windows.Forms.Label SumValue_lbl;
    }
}
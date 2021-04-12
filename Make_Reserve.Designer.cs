namespace Hotel_SA
{
    partial class Make_Reserve
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
            this.ReserveRooms_List = new System.Windows.Forms.ListView();
            this.colRoomNumber = new System.Windows.Forms.ColumnHeader();
            this.colRoomCapacity = new System.Windows.Forms.ColumnHeader();
            this.colCheckIn = new System.Windows.Forms.ColumnHeader();
            this.colRoomCost = new System.Windows.Forms.ColumnHeader();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Number_textbox = new System.Windows.Forms.TextBox();
            this.Number_label = new System.Windows.Forms.Label();
            this.clientType_checkbox = new System.Windows.Forms.CheckBox();
            this.sexMale_radio = new System.Windows.Forms.RadioButton();
            this.sexFemale_radio = new System.Windows.Forms.RadioButton();
            this.sexPanel = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Reserve_Btn = new System.Windows.Forms.Button();
            this.sexPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReserveRooms_List
            // 
            this.ReserveRooms_List.AutoArrange = false;
            this.ReserveRooms_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.colRoomNumber, this.colRoomCapacity, this.colCheckIn, this.colRoomCost});
            this.ReserveRooms_List.FullRowSelect = true;
            this.ReserveRooms_List.GridLines = true;
            this.ReserveRooms_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReserveRooms_List.HideSelection = false;
            this.ReserveRooms_List.Location = new System.Drawing.Point(12, 114);
            this.ReserveRooms_List.MultiSelect = false;
            this.ReserveRooms_List.Name = "ReserveRooms_List";
            this.ReserveRooms_List.Size = new System.Drawing.Size(578, 120);
            this.ReserveRooms_List.TabIndex = 10;
            this.ReserveRooms_List.UseCompatibleStateImageBehavior = false;
            this.ReserveRooms_List.View = System.Windows.Forms.View.Details;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Номер комнаты";
            this.colRoomNumber.Width = 114;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.Text = "Вместимость";
            this.colRoomCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomCapacity.Width = 98;
            // 
            // colCheckIn
            // 
            this.colCheckIn.Text = "Заселение";
            this.colCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCheckIn.Width = 84;
            // 
            // colRoomCost
            // 
            this.colRoomCost.Text = "Цена за номер";
            this.colRoomCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRoomCost.Width = 273;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(12, 18);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(206, 17);
            this.Name_Label.TabIndex = 12;
            this.Name_Label.Text = "ФИО / Название организации";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(241, 15);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(349, 22);
            this.Name_textbox.TabIndex = 13;
            this.Name_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            // 
            // Number_textbox
            // 
            this.Number_textbox.Location = new System.Drawing.Point(241, 43);
            this.Number_textbox.Name = "Number_textbox";
            this.Number_textbox.Size = new System.Drawing.Size(349, 22);
            this.Number_textbox.TabIndex = 15;
            this.Number_textbox.TextChanged += new System.EventHandler(this.Number_textbox_TextChanged);
            // 
            // Number_label
            // 
            this.Number_label.AutoSize = true;
            this.Number_label.Location = new System.Drawing.Point(12, 46);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(121, 17);
            this.Number_label.TabIndex = 14;
            this.Number_label.Text = "Номер телефона";
            // 
            // clientType_checkbox
            // 
            this.clientType_checkbox.AutoSize = true;
            this.clientType_checkbox.Location = new System.Drawing.Point(241, 78);
            this.clientType_checkbox.Name = "clientType_checkbox";
            this.clientType_checkbox.Size = new System.Drawing.Size(92, 21);
            this.clientType_checkbox.TabIndex = 18;
            this.clientType_checkbox.Text = "Юр. лицо";
            this.clientType_checkbox.UseVisualStyleBackColor = true;
            this.clientType_checkbox.CheckedChanged += new System.EventHandler(this.clientType_checkbox_CheckedChanged);
            // 
            // sexMale_radio
            // 
            this.sexMale_radio.AutoSize = true;
            this.sexMale_radio.Location = new System.Drawing.Point(3, 3);
            this.sexMale_radio.Name = "sexMale_radio";
            this.sexMale_radio.Size = new System.Drawing.Size(86, 21);
            this.sexMale_radio.TabIndex = 19;
            this.sexMale_radio.Text = "Мужской";
            this.sexMale_radio.UseVisualStyleBackColor = true;
            // 
            // sexFemale_radio
            // 
            this.sexFemale_radio.AutoSize = true;
            this.sexFemale_radio.Location = new System.Drawing.Point(112, 3);
            this.sexFemale_radio.Name = "sexFemale_radio";
            this.sexFemale_radio.Size = new System.Drawing.Size(88, 21);
            this.sexFemale_radio.TabIndex = 20;
            this.sexFemale_radio.Text = "Женский";
            this.sexFemale_radio.UseVisualStyleBackColor = true;
            // 
            // sexPanel
            // 
            this.sexPanel.Controls.Add(this.sexFemale_radio);
            this.sexPanel.Controls.Add(this.sexMale_radio);
            this.sexPanel.Location = new System.Drawing.Point(15, 74);
            this.sexPanel.Name = "sexPanel";
            this.sexPanel.Size = new System.Drawing.Size(203, 34);
            this.sexPanel.TabIndex = 21;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Exit_Btn.Location = new System.Drawing.Point(612, 196);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(176, 38);
            this.Exit_Btn.TabIndex = 21;
            this.Exit_Btn.Text = "Отмена";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Clear_btn.Location = new System.Drawing.Point(612, 152);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(176, 38);
            this.Clear_btn.TabIndex = 22;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Reserve_Btn
            // 
            this.Reserve_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Reserve_Btn.Location = new System.Drawing.Point(612, 15);
            this.Reserve_Btn.Name = "Reserve_Btn";
            this.Reserve_Btn.Size = new System.Drawing.Size(176, 38);
            this.Reserve_Btn.TabIndex = 23;
            this.Reserve_Btn.Text = "Бронь";
            this.Reserve_Btn.UseVisualStyleBackColor = true;
            this.Reserve_Btn.Click += new System.EventHandler(this.Reserve_Btn_Click);
            // 
            // Make_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.Reserve_Btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.sexPanel);
            this.Controls.Add(this.clientType_checkbox);
            this.Controls.Add(this.Number_textbox);
            this.Controls.Add(this.Number_label);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.ReserveRooms_List);
            this.Name = "Make_Reserve";
            this.Text = "Создание брони";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            this.sexPanel.ResumeLayout(false);
            this.sexPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView ReserveRooms_List;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomCapacity;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colRoomCost;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Number_textbox;
        private System.Windows.Forms.Label Number_label;
        private System.Windows.Forms.CheckBox clientType_checkbox;
        private System.Windows.Forms.RadioButton sexMale_radio;
        private System.Windows.Forms.RadioButton sexFemale_radio;
        private System.Windows.Forms.Panel sexPanel;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Reserve_Btn;
    }
}
using System;
using System.Data;

namespace Hotel_SA
{
    partial class Show_Available_Rooms
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
            this.RoomTypes_Dropdown = new System.Windows.Forms.ComboBox();
            this.countPeople = new System.Windows.Forms.NumericUpDown();
            this.RoomType_Label = new System.Windows.Forms.Label();
            this.countPeople_Label = new System.Windows.Forms.Label();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            this.CheckIn_Label = new System.Windows.Forms.Label();
            this.CheckOut_Label = new System.Windows.Forms.Label();
            this.FreeRooms_List = new System.Windows.Forms.ListView();
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search_btn = new System.Windows.Forms.Button();
            this.Reserve_btn = new System.Windows.Forms.Button();
            this.CheckIn_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomTypes_Dropdown
            // 
            this.RoomTypes_Dropdown.AllowDrop = true;
            this.RoomTypes_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypes_Dropdown.Location = new System.Drawing.Point(153, 15);
            this.RoomTypes_Dropdown.MaxDropDownItems = 10;
            this.RoomTypes_Dropdown.Name = "RoomTypes_Dropdown";
            this.RoomTypes_Dropdown.Size = new System.Drawing.Size(171, 24);
            this.RoomTypes_Dropdown.TabIndex = 0;
            // 
            // countPeople
            // 
            this.countPeople.Location = new System.Drawing.Point(153, 54);
            this.countPeople.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.countPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countPeople.Name = "countPeople";
            this.countPeople.Size = new System.Drawing.Size(171, 22);
            this.countPeople.TabIndex = 2;
            this.countPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countPeople.ValueChanged += new System.EventHandler(this.checkCapacity);
            // 
            // RoomType_Label
            // 
            this.RoomType_Label.AutoSize = true;
            this.RoomType_Label.Location = new System.Drawing.Point(12, 15);
            this.RoomType_Label.Name = "RoomType_Label";
            this.RoomType_Label.Size = new System.Drawing.Size(86, 17);
            this.RoomType_Label.TabIndex = 3;
            this.RoomType_Label.Text = "Тип номера";
            // 
            // countPeople_Label
            // 
            this.countPeople_Label.AutoSize = true;
            this.countPeople_Label.Location = new System.Drawing.Point(12, 54);
            this.countPeople_Label.Name = "countPeople_Label";
            this.countPeople_Label.Size = new System.Drawing.Size(111, 17);
            this.countPeople_Label.TabIndex = 4;
            this.countPeople_Label.Text = "Кол-во человек";
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckIn.Location = new System.Drawing.Point(477, 15);
            this.dateTimeCheckIn.MinDate = new System.DateTime(2021, 4, 2, 15, 19, 58, 864);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(108, 22);
            this.dateTimeCheckIn.TabIndex = 5;
            this.dateTimeCheckIn.Value = new System.DateTime(2021, 4, 2, 15, 19, 58, 865);
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckOut.Location = new System.Drawing.Point(477, 54);
            this.dateTimeCheckOut.MinDate = new System.DateTime(2021, 4, 2, 15, 19, 58, 866);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(108, 22);
            this.dateTimeCheckOut.TabIndex = 6;
            this.dateTimeCheckOut.Value = new System.DateTime(2021, 4, 3, 15, 19, 58, 867);
            // 
            // CheckIn_Label
            // 
            this.CheckIn_Label.AutoSize = true;
            this.CheckIn_Label.Location = new System.Drawing.Point(346, 15);
            this.CheckIn_Label.Name = "CheckIn_Label";
            this.CheckIn_Label.Size = new System.Drawing.Size(116, 17);
            this.CheckIn_Label.TabIndex = 7;
            this.CheckIn_Label.Text = "Дата заселения";
            // 
            // CheckOut_Label
            // 
            this.CheckOut_Label.AutoSize = true;
            this.CheckOut_Label.Location = new System.Drawing.Point(346, 54);
            this.CheckOut_Label.Name = "CheckOut_Label";
            this.CheckOut_Label.Size = new System.Drawing.Size(118, 17);
            this.CheckOut_Label.TabIndex = 8;
            this.CheckOut_Label.Text = "Дата выселения";
            // 
            // FreeRooms_List
            // 
            this.FreeRooms_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRoomCapacity,
            this.colCheckIn,
            this.colRoomCost});
            this.FreeRooms_List.FullRowSelect = true;
            this.FreeRooms_List.GridLines = true;
            this.FreeRooms_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FreeRooms_List.HideSelection = false;
            this.FreeRooms_List.Location = new System.Drawing.Point(15, 112);
            this.FreeRooms_List.Name = "FreeRooms_List";
            this.FreeRooms_List.Size = new System.Drawing.Size(573, 326);
            this.FreeRooms_List.TabIndex = 9;
            this.FreeRooms_List.UseCompatibleStateImageBehavior = false;
            this.FreeRooms_List.View = System.Windows.Forms.View.Details;
            this.FreeRooms_List.SelectedIndexChanged += new System.EventHandler(this.checkCapacity);
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
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_btn.Location = new System.Drawing.Point(612, 38);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(176, 38);
            this.Search_btn.TabIndex = 10;
            this.Search_btn.Text = "Поиск";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.loadRooms);
            // 
            // Reserve_btn
            // 
            this.Reserve_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reserve_btn.Location = new System.Drawing.Point(612, 112);
            this.Reserve_btn.Name = "Reserve_btn";
            this.Reserve_btn.Size = new System.Drawing.Size(176, 38);
            this.Reserve_btn.TabIndex = 11;
            this.Reserve_btn.Text = "Бронь";
            this.Reserve_btn.UseVisualStyleBackColor = true;
            this.Reserve_btn.Click += new System.EventHandler(this.Reserve_btn_Click);
            // 
            // CheckIn_btn
            // 
            this.CheckIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIn_btn.Location = new System.Drawing.Point(612, 156);
            this.CheckIn_btn.Name = "CheckIn_btn";
            this.CheckIn_btn.Size = new System.Drawing.Size(176, 38);
            this.CheckIn_btn.TabIndex = 12;
            this.CheckIn_btn.Text = "Заселение";
            this.CheckIn_btn.UseVisualStyleBackColor = true;
            this.CheckIn_btn.Click += new System.EventHandler(this.CheckIn_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.Location = new System.Drawing.Point(612, 400);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(176, 38);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "Выход";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.Location = new System.Drawing.Point(612, 200);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(176, 38);
            this.Clear_btn.TabIndex = 14;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Show_Available_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.CheckIn_btn);
            this.Controls.Add(this.Reserve_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.FreeRooms_List);
            this.Controls.Add(this.CheckOut_Label);
            this.Controls.Add(this.CheckIn_Label);
            this.Controls.Add(this.dateTimeCheckOut);
            this.Controls.Add(this.dateTimeCheckIn);
            this.Controls.Add(this.countPeople_Label);
            this.Controls.Add(this.RoomType_Label);
            this.Controls.Add(this.countPeople);
            this.Controls.Add(this.RoomTypes_Dropdown);
            this.Name = "Show_Available_Rooms";
            this.Text = "Поиск  свободных номеров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.countPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomTypes_Dropdown;
        private System.Windows.Forms.NumericUpDown countPeople;
        private System.Windows.Forms.Label RoomType_Label;
        private System.Windows.Forms.Label countPeople_Label;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;
        private System.Windows.Forms.Label CheckIn_Label;
        private System.Windows.Forms.Label CheckOut_Label;
        private System.Windows.Forms.ListView FreeRooms_List;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomCapacity;
        private System.Windows.Forms.ColumnHeader colRoomCost;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Reserve_btn;
        private System.Windows.Forms.Button CheckIn_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}
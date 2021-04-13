using System.ComponentModel;

namespace Hotel_SA
{
    partial class Show_Reserved_Rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpireAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.CheckIn_Btn = new System.Windows.Forms.Button();
            this.ReserveUpdate_Btn = new System.Windows.Forms.Button();
            this.ReserveDelete_Btn = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReserveRooms_List
            // 
            this.ReserveRooms_List.AutoArrange = false;
            this.ReserveRooms_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRoomCapacity,
            this.colExpireAt});
            this.ReserveRooms_List.FullRowSelect = true;
            this.ReserveRooms_List.GridLines = true;
            this.ReserveRooms_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReserveRooms_List.HideSelection = false;
            this.ReserveRooms_List.LabelWrap = false;
            this.ReserveRooms_List.Location = new System.Drawing.Point(12, 12);
            this.ReserveRooms_List.Name = "ReserveRooms_List";
            this.ReserveRooms_List.Size = new System.Drawing.Size(450, 338);
            this.ReserveRooms_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ReserveRooms_List.TabIndex = 11;
            this.ReserveRooms_List.UseCompatibleStateImageBehavior = false;
            this.ReserveRooms_List.View = System.Windows.Forms.View.Details;
            this.ReserveRooms_List.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ReserveRooms_List_ItemSelectionChanged);
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Номер комнаты";
            this.colRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomNumber.Width = 114;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.Text = "Вместимость";
            this.colRoomCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomCapacity.Width = 98;
            // 
            // colExpireAt
            // 
            this.colExpireAt.Text = "Дата истечения";
            this.colExpireAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpireAt.Width = 273;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Btn.Location = new System.Drawing.Point(492, 312);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(211, 38);
            this.Exit_Btn.TabIndex = 14;
            this.Exit_Btn.Text = "Выход";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // CheckIn_Btn
            // 
            this.CheckIn_Btn.Enabled = false;
            this.CheckIn_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIn_Btn.Location = new System.Drawing.Point(492, 12);
            this.CheckIn_Btn.Name = "CheckIn_Btn";
            this.CheckIn_Btn.Size = new System.Drawing.Size(211, 38);
            this.CheckIn_Btn.TabIndex = 15;
            this.CheckIn_Btn.Text = "Заселение";
            this.CheckIn_Btn.UseVisualStyleBackColor = true;
            this.CheckIn_Btn.Click += new System.EventHandler(this.CheckIn_Btn_Click);
            // 
            // ReserveUpdate_Btn
            // 
            this.ReserveUpdate_Btn.Enabled = false;
            this.ReserveUpdate_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveUpdate_Btn.Location = new System.Drawing.Point(492, 100);
            this.ReserveUpdate_Btn.Name = "ReserveUpdate_Btn";
            this.ReserveUpdate_Btn.Size = new System.Drawing.Size(211, 38);
            this.ReserveUpdate_Btn.TabIndex = 16;
            this.ReserveUpdate_Btn.Text = "Продление на день";
            this.ReserveUpdate_Btn.UseVisualStyleBackColor = true;
            this.ReserveUpdate_Btn.Click += new System.EventHandler(this.ReserveUpdate_Btn_Click);
            // 
            // ReserveDelete_Btn
            // 
            this.ReserveDelete_Btn.Enabled = false;
            this.ReserveDelete_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveDelete_Btn.Location = new System.Drawing.Point(492, 56);
            this.ReserveDelete_Btn.Name = "ReserveDelete_Btn";
            this.ReserveDelete_Btn.Size = new System.Drawing.Size(211, 38);
            this.ReserveDelete_Btn.TabIndex = 17;
            this.ReserveDelete_Btn.Text = "Удаление брони";
            this.ReserveDelete_Btn.UseVisualStyleBackColor = true;
            this.ReserveDelete_Btn.Click += new System.EventHandler(this.ReserveDelete_Btn_Click);
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Btn.Location = new System.Drawing.Point(492, 268);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(211, 38);
            this.Clear_Btn.TabIndex = 18;
            this.Clear_Btn.Text = "Очистить выбор";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // Show_Reserved_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 377);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.ReserveDelete_Btn);
            this.Controls.Add(this.ReserveUpdate_Btn);
            this.Controls.Add(this.CheckIn_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.ReserveRooms_List);
            this.Name = "Show_Reserved_Rooms";
            this.Text = "Забронированные номера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label RoomType_Label;

        #endregion

        private System.Windows.Forms.ListView ReserveRooms_List;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomCapacity;
        private System.Windows.Forms.ColumnHeader colExpireAt;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button CheckIn_Btn;
        private System.Windows.Forms.Button ReserveUpdate_Btn;
        private System.Windows.Forms.Button ReserveDelete_Btn;
        private System.Windows.Forms.Button Clear_Btn;
    }
}
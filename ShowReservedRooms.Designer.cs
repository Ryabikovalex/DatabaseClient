using System.ComponentModel;

namespace DatabaseClient
{
    partial class ShowReservedRooms
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
            this.Exit_btn = new System.Windows.Forms.Button();
            this.CheckIn_btn = new System.Windows.Forms.Button();
            this.ReserveUpdate_btn = new System.Windows.Forms.Button();
            this.ReserveDelete_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
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
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.Location = new System.Drawing.Point(492, 312);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(211, 38);
            this.Exit_btn.TabIndex = 14;
            this.Exit_btn.Text = "Выход";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // CheckIn_btn
            // 
            this.CheckIn_btn.Enabled = false;
            this.CheckIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIn_btn.Location = new System.Drawing.Point(492, 12);
            this.CheckIn_btn.Name = "CheckIn_btn";
            this.CheckIn_btn.Size = new System.Drawing.Size(211, 38);
            this.CheckIn_btn.TabIndex = 15;
            this.CheckIn_btn.Text = "Заселение";
            this.CheckIn_btn.UseVisualStyleBackColor = true;
            this.CheckIn_btn.Click += new System.EventHandler(this.CheckIn_btn_Click);
            // 
            // ReserveUpdate_btn
            // 
            this.ReserveUpdate_btn.Enabled = false;
            this.ReserveUpdate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveUpdate_btn.Location = new System.Drawing.Point(492, 100);
            this.ReserveUpdate_btn.Name = "ReserveUpdate_btn";
            this.ReserveUpdate_btn.Size = new System.Drawing.Size(211, 38);
            this.ReserveUpdate_btn.TabIndex = 16;
            this.ReserveUpdate_btn.Text = "Продление на день";
            this.ReserveUpdate_btn.UseVisualStyleBackColor = true;
            this.ReserveUpdate_btn.Click += new System.EventHandler(this.ReserveUpdate_btn_Click);
            // 
            // ReserveDelete_btn
            // 
            this.ReserveDelete_btn.Enabled = false;
            this.ReserveDelete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveDelete_btn.Location = new System.Drawing.Point(492, 56);
            this.ReserveDelete_btn.Name = "ReserveDelete_btn";
            this.ReserveDelete_btn.Size = new System.Drawing.Size(211, 38);
            this.ReserveDelete_btn.TabIndex = 17;
            this.ReserveDelete_btn.Text = "Удаление брони";
            this.ReserveDelete_btn.UseVisualStyleBackColor = true;
            this.ReserveDelete_btn.Click += new System.EventHandler(this.ReserveDelete_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.Location = new System.Drawing.Point(492, 268);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(211, 38);
            this.Clear_btn.TabIndex = 18;
            this.Clear_btn.Text = "Очистить выбор";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Show_Reserved_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 377);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.ReserveDelete_btn);
            this.Controls.Add(this.ReserveUpdate_btn);
            this.Controls.Add(this.CheckIn_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.ReserveRooms_List);
            this.Name = "ShowReservedRooms";
            this.Text = "Забронированные номера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ReserveRooms_List;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRoomCapacity;
        private System.Windows.Forms.ColumnHeader colExpireAt;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button CheckIn_btn;
        private System.Windows.Forms.Button ReserveUpdate_btn;
        private System.Windows.Forms.Button ReserveDelete_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}
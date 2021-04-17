namespace Hotel_SA
{
    partial class ShowLiving
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
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Living_List = new System.Windows.Forms.ListView();
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientInfo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOut_btn.Location = new System.Drawing.Point(582, 12);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(206, 38);
            this.checkOut_btn.TabIndex = 19;
            this.checkOut_btn.Text = "Выселение";
            this.checkOut_btn.UseVisualStyleBackColor = true;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.Location = new System.Drawing.Point(582, 56);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(206, 38);
            this.Clear_btn.TabIndex = 20;
            this.Clear_btn.Text = "Очистить выбор";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.Location = new System.Drawing.Point(582, 312);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(206, 38);
            this.Exit_btn.TabIndex = 21;
            this.Exit_btn.Text = "Выход";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Living_List
            // 
            this.Living_List.AutoArrange = false;
            this.Living_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientName,
            this.colClientSex,
            this.colClientNumber,
            this.colCheckIn});
            this.Living_List.FullRowSelect = true;
            this.Living_List.GridLines = true;
            this.Living_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Living_List.HideSelection = false;
            this.Living_List.LabelWrap = false;
            this.Living_List.Location = new System.Drawing.Point(12, 12);
            this.Living_List.Name = "Living_List";
            this.Living_List.Size = new System.Drawing.Size(564, 338);
            this.Living_List.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Living_List.TabIndex = 22;
            this.Living_List.UseCompatibleStateImageBehavior = false;
            this.Living_List.View = System.Windows.Forms.View.Details;
            this.Living_List.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Living_List_ItemSelectionChanged);
            // 
            // colClientName
            // 
            this.colClientName.Text = "ФИО";
            this.colClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClientName.Width = 114;
            // 
            // colClientSex
            // 
            this.colClientSex.Text = "Пол";
            this.colClientSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colClientNumber
            // 
            this.colClientNumber.Text = "Номер телефона";
            this.colClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClientNumber.Width = 98;
            // 
            // colCheckIn
            // 
            this.colCheckIn.Text = "Дата заселения";
            this.colCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCheckIn.Width = 265;
            // 
            // clientInfo_btn
            // 
            this.clientInfo_btn.Enabled = false;
            this.clientInfo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientInfo_btn.Location = new System.Drawing.Point(582, 100);
            this.clientInfo_btn.Name = "clientInfo_btn";
            this.clientInfo_btn.Size = new System.Drawing.Size(206, 38);
            this.clientInfo_btn.TabIndex = 23;
            this.clientInfo_btn.Text = "Карта Клиента";
            this.clientInfo_btn.UseVisualStyleBackColor = true;
            this.clientInfo_btn.Visible = false;
            // 
            // Show_Living
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.clientInfo_btn);
            this.Controls.Add(this.Living_List);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.checkOut_btn);
            this.Name = "ShowLiving";
            this.Text = "Постояльцы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkOut_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.ListView Living_List;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colClientNumber;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colClientSex;
        private System.Windows.Forms.Button clientInfo_btn;
    }
}
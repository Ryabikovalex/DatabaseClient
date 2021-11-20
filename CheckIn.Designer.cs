using System.ComponentModel;

namespace DatabaseClient
{
    partial class CheckIn
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
            this.CheckIn_Label = new System.Windows.Forms.Label();
            this.CheckOut_Label = new System.Windows.Forms.Label();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countPeople = new System.Windows.Forms.NumericUpDown();
            this.countPeople_Label = new System.Windows.Forms.Label();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.countPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckIn_Label
            // 
            this.CheckIn_Label.AutoSize = true;
            this.CheckIn_Label.Location = new System.Drawing.Point(12, 12);
            this.CheckIn_Label.Name = "CheckIn_Label";
            this.CheckIn_Label.Size = new System.Drawing.Size(116, 17);
            this.CheckIn_Label.TabIndex = 8;
            this.CheckIn_Label.Text = "Дата заселения";
            // 
            // CheckOut_Label
            // 
            this.CheckOut_Label.AutoSize = true;
            this.CheckOut_Label.Location = new System.Drawing.Point(12, 40);
            this.CheckOut_Label.Name = "CheckOut_Label";
            this.CheckOut_Label.Size = new System.Drawing.Size(118, 17);
            this.CheckOut_Label.TabIndex = 9;
            this.CheckOut_Label.Text = "Дата выселения";
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Enabled = false;
            this.dateTimeCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckIn.Location = new System.Drawing.Point(145, 12);
            this.dateTimeCheckIn.MinDate = new System.DateTime(2021, 4, 2, 15, 19, 58, 864);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(108, 22);
            this.dateTimeCheckIn.TabIndex = 10;
            this.dateTimeCheckIn.Value = new System.DateTime(2021, 4, 2, 15, 19, 58, 865);
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckOut.Location = new System.Drawing.Point(145, 40);
            this.dateTimeCheckOut.MinDate = new System.DateTime(2021, 4, 2, 15, 19, 58, 866);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(108, 22);
            this.dateTimeCheckOut.TabIndex = 11;
            this.dateTimeCheckOut.Value = new System.DateTime(2021, 4, 3, 15, 19, 58, 867);
            // 
            // Main_panel
            // 
            this.Main_panel.AutoScroll = true;
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_panel.Controls.Add(this.groupBox1);
            this.Main_panel.Location = new System.Drawing.Point(12, 79);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(776, 359);
            this.Main_panel.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // countPeople
            // 
            this.countPeople.Location = new System.Drawing.Point(283, 40);
            this.countPeople.Maximum = new decimal(new int[] {30, 0, 0, 0});
            this.countPeople.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.countPeople.Name = "countPeople";
            this.countPeople.Size = new System.Drawing.Size(171, 22);
            this.countPeople.TabIndex = 3;
            this.countPeople.Value = new decimal(new int[] {1, 0, 0, 0});
            this.countPeople.ValueChanged += new System.EventHandler(this.countPeople_ValueChanged);
            // 
            // countPeople_Label
            // 
            this.countPeople_Label.AutoSize = true;
            this.countPeople_Label.Location = new System.Drawing.Point(283, 12);
            this.countPeople_Label.Name = "countPeople_Label";
            this.countPeople_Label.Size = new System.Drawing.Size(111, 17);
            this.countPeople_Label.TabIndex = 13;
            this.countPeople_Label.Text = "Кол-во человек";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countPeople_Label);
            this.Controls.Add(this.countPeople);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.dateTimeCheckOut);
            this.Controls.Add(this.dateTimeCheckIn);
            this.Controls.Add(this.CheckOut_Label);
            this.Controls.Add(this.CheckIn_Label);
            this.Name = "CheckIn";
            this.Text = "Заселение клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            this.Main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.countPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label countPeople_Label;

        private System.Windows.Forms.NumericUpDown countPeople;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Panel Main_panel;

        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;

        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;

        private System.Windows.Forms.Label CheckOut_Label;

        private System.Windows.Forms.Label CheckIn_Label;

        #endregion
    }
}
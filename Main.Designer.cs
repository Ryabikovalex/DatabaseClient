using System.Windows.Forms;
using Hotel_SA;

namespace Hotel_SA
{
    partial class Main : Hotel_SA.ProjectForm
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
            this.AvailableRooms_Btn = new System.Windows.Forms.Button();
            this.ReservedRooms_Btn = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Living_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.PaidServices_Btn = new System.Windows.Forms.Button();
            this.Archive_Btn = new System.Windows.Forms.Button();
            this.checkOut_Btn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailableRooms_Btn
            // 
            this.AvailableRooms_Btn.Enabled = false;
            this.AvailableRooms_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableRooms_Btn.Location = new System.Drawing.Point(283, 150);
            this.AvailableRooms_Btn.Name = "AvailableRooms_Btn";
            this.AvailableRooms_Btn.Size = new System.Drawing.Size(278, 47);
            this.AvailableRooms_Btn.TabIndex = 1;
            this.AvailableRooms_Btn.Text = "Доступные номера";
            this.AvailableRooms_Btn.UseVisualStyleBackColor = true;
            this.AvailableRooms_Btn.Click += new System.EventHandler(this.availableRooms_Btn_Click);
            // 
            // ReservedRooms_Btn
            // 
            this.ReservedRooms_Btn.Enabled = false;
            this.ReservedRooms_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservedRooms_Btn.Location = new System.Drawing.Point(283, 203);
            this.ReservedRooms_Btn.Name = "ReservedRooms_Btn";
            this.ReservedRooms_Btn.Size = new System.Drawing.Size(278, 53);
            this.ReservedRooms_Btn.TabIndex = 2;
            this.ReservedRooms_Btn.Text = "Забронированные номера";
            this.ReservedRooms_Btn.UseVisualStyleBackColor = true;
            this.ReservedRooms_Btn.Click += new System.EventHandler(this.reservedRooms_Btn_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(848, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(848, 71);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(848, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 468);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(848, 24);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Living_Btn
            // 
            this.Living_Btn.Enabled = false;
            this.Living_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Living_Btn.Location = new System.Drawing.Point(283, 262);
            this.Living_Btn.Name = "Living_Btn";
            this.Living_Btn.Size = new System.Drawing.Size(278, 53);
            this.Living_Btn.TabIndex = 5;
            this.Living_Btn.Text = "Постояльцы";
            this.Living_Btn.UseVisualStyleBackColor = true;
            this.Living_Btn.Click += new System.EventHandler(this.Living_Btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Btn.Location = new System.Drawing.Point(648, 424);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(185, 38);
            this.Exit_Btn.TabIndex = 15;
            this.Exit_Btn.Text = "Выход";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // PaidServices_Btn
            // 
            this.PaidServices_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaidServices_Btn.ForeColor = System.Drawing.Color.Red;
            this.PaidServices_Btn.Location = new System.Drawing.Point(12, 424);
            this.PaidServices_Btn.Name = "PaidServices_Btn";
            this.PaidServices_Btn.Size = new System.Drawing.Size(206, 38);
            this.PaidServices_Btn.TabIndex = 16;
            this.PaidServices_Btn.Text = "Оказание услуг";
            this.PaidServices_Btn.UseVisualStyleBackColor = true;
            this.PaidServices_Btn.Click += new System.EventHandler(this.PaidServices_Btn_Click);
            // 
            // Archive_Btn
            // 
            this.Archive_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archive_Btn.Location = new System.Drawing.Point(436, 424);
            this.Archive_Btn.Name = "Archive_Btn";
            this.Archive_Btn.Size = new System.Drawing.Size(206, 38);
            this.Archive_Btn.TabIndex = 17;
            this.Archive_Btn.Text = "Архив";
            this.Archive_Btn.UseVisualStyleBackColor = true;
            this.Archive_Btn.Click += new System.EventHandler(this.Archive_Btn_Click);
            // 
            // checkOut_Btn
            // 
            this.checkOut_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOut_Btn.Location = new System.Drawing.Point(224, 424);
            this.checkOut_Btn.Name = "checkOut_Btn";
            this.checkOut_Btn.Size = new System.Drawing.Size(206, 38);
            this.checkOut_Btn.TabIndex = 18;
            this.checkOut_Btn.Text = "Выселение";
            this.checkOut_Btn.UseVisualStyleBackColor = true;
            this.checkOut_Btn.Click += new System.EventHandler(this.checkOut_Btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 493);
            this.Controls.Add(this.checkOut_Btn);
            this.Controls.Add(this.Archive_Btn);
            this.Controls.Add(this.PaidServices_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Living_Btn);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.ReservedRooms_Btn);
            this.Controls.Add(this.AvailableRooms_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "ИС Гостиница (Матвеев, Рябиков)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AvailableRooms_Btn;
        private System.Windows.Forms.Button ReservedRooms_Btn;
        private ToolStripPanel BottomToolStripPanel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ToolStripContainer toolStripContainer1;
        private Button Living_Btn;
        private Button Exit_Btn;
        private Button PaidServices_Btn;
        private Button Archive_Btn;
        private Button checkOut_Btn;
    }
}
﻿namespace QuanLyKhachSan
{
    partial class Mainformreceptionist
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.youToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementLaborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInOutReceptoinistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.managementGuestToolStripMenuItem,
            this.managementFoodToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.ReservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1977, 81);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // managementGuestToolStripMenuItem
            // 
            this.managementGuestToolStripMenuItem.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.managementGuestToolStripMenuItem.Name = "managementGuestToolStripMenuItem";
            this.managementGuestToolStripMenuItem.Size = new System.Drawing.Size(132, 77);
            this.managementGuestToolStripMenuItem.Text = "Guest";
            this.managementGuestToolStripMenuItem.Click += new System.EventHandler(this.managementGuestToolStripMenuItem_Click);
            // 
            // managementFoodToolStripMenuItem
            // 
            this.managementFoodToolStripMenuItem.Name = "managementFoodToolStripMenuItem";
            this.managementFoodToolStripMenuItem.Size = new System.Drawing.Size(120, 77);
            this.managementFoodToolStripMenuItem.Text = "Food";
            this.managementFoodToolStripMenuItem.Click += new System.EventHandler(this.managementFoodToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(132, 77);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // ReservationToolStripMenuItem
            // 
            this.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem";
            this.ReservationToolStripMenuItem.Size = new System.Drawing.Size(214, 77);
            this.ReservationToolStripMenuItem.Text = "Reservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Manager SysTem";
            // 
            // youToolStripMenuItem
            // 
            this.youToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInOutToolStripMenuItem,
            this.checkInOutReceptoinistToolStripMenuItem});
            this.youToolStripMenuItem.Name = "youToolStripMenuItem";
            this.youToolStripMenuItem.Size = new System.Drawing.Size(104, 77);
            this.youToolStripMenuItem.Text = "You";
            // 
            // checkInOutToolStripMenuItem
            // 
            this.checkInOutToolStripMenuItem.Name = "checkInOutToolStripMenuItem";
            this.checkInOutToolStripMenuItem.Size = new System.Drawing.Size(558, 82);
            this.checkInOutToolStripMenuItem.Text = "Check in - out Labor";
            this.checkInOutToolStripMenuItem.Click += new System.EventHandler(this.checkInOutToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementLaborToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(201, 77);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // managementLaborToolStripMenuItem
            // 
            this.managementLaborToolStripMenuItem.Name = "managementLaborToolStripMenuItem";
            this.managementLaborToolStripMenuItem.Size = new System.Drawing.Size(362, 82);
            this.managementLaborToolStripMenuItem.Text = "Management";
            this.managementLaborToolStripMenuItem.Click += new System.EventHandler(this.managementLaborToolStripMenuItem_Click);
            // 
            // checkInOutReceptoinistToolStripMenuItem
            // 
            this.checkInOutReceptoinistToolStripMenuItem.Name = "checkInOutReceptoinistToolStripMenuItem";
            this.checkInOutReceptoinistToolStripMenuItem.Size = new System.Drawing.Size(558, 82);
            this.checkInOutReceptoinistToolStripMenuItem.Text = "Check in - out Receptoinist";
            this.checkInOutReceptoinistToolStripMenuItem.Click += new System.EventHandler(this.checkInOutReceptoinistToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.Hotel_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(376, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Mainformreceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1977, 901);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainformreceptionist";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementLaborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInOutReceptoinistToolStripMenuItem;
    }
}
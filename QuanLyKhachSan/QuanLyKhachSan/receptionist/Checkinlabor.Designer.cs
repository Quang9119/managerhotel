namespace QuanLyKhachSan.receptionist
{
    partial class Checkinlabor
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
            this.dateTimePickerdaymonthyear = new System.Windows.Forms.DateTimePicker();
            this.buttonshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickertimein = new System.Windows.Forms.DateTimePicker();
            this.buttoncheckin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttoncheckout = new System.Windows.Forms.Button();
            this.dateTimePickertimeout = new System.Windows.Forms.DateTimePicker();
            this.textBoxidemployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerdaymonthyear
            // 
            this.dateTimePickerdaymonthyear.Location = new System.Drawing.Point(61, 152);
            this.dateTimePickerdaymonthyear.Name = "dateTimePickerdaymonthyear";
            this.dateTimePickerdaymonthyear.Size = new System.Drawing.Size(371, 31);
            this.dateTimePickerdaymonthyear.TabIndex = 0;
            // 
            // buttonshow
            // 
            this.buttonshow.Location = new System.Drawing.Point(499, 128);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(198, 82);
            this.buttonshow.TabIndex = 1;
            this.buttonshow.Text = "Show";
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(731, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 840);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dateTimePickertimein
            // 
            this.dateTimePickertimein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickertimein.Location = new System.Drawing.Point(202, 469);
            this.dateTimePickertimein.Name = "dateTimePickertimein";
            this.dateTimePickertimein.ShowUpDown = true;
            this.dateTimePickertimein.Size = new System.Drawing.Size(290, 31);
            this.dateTimePickertimein.TabIndex = 4;
            this.dateTimePickertimein.Value = new System.DateTime(2023, 5, 14, 23, 57, 0, 0);
            // 
            // buttoncheckin
            // 
            this.buttoncheckin.Location = new System.Drawing.Point(527, 445);
            this.buttoncheckin.Name = "buttoncheckin";
            this.buttoncheckin.Size = new System.Drawing.Size(198, 82);
            this.buttoncheckin.TabIndex = 5;
            this.buttoncheckin.Text = "Check in";
            this.buttoncheckin.UseVisualStyleBackColor = true;
            this.buttoncheckin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 750);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 82);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time Out";
            // 
            // buttoncheckout
            // 
            this.buttoncheckout.Location = new System.Drawing.Point(527, 603);
            this.buttoncheckout.Name = "buttoncheckout";
            this.buttoncheckout.Size = new System.Drawing.Size(198, 82);
            this.buttoncheckout.TabIndex = 9;
            this.buttoncheckout.Text = "Check Out";
            this.buttoncheckout.UseVisualStyleBackColor = true;
            this.buttoncheckout.Click += new System.EventHandler(this.buttoncheckout_Click);
            // 
            // dateTimePickertimeout
            // 
            this.dateTimePickertimeout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickertimeout.Location = new System.Drawing.Point(202, 627);
            this.dateTimePickertimeout.Name = "dateTimePickertimeout";
            this.dateTimePickertimeout.ShowUpDown = true;
            this.dateTimePickertimeout.Size = new System.Drawing.Size(290, 31);
            this.dateTimePickertimeout.TabIndex = 8;
            this.dateTimePickertimeout.Value = new System.DateTime(2023, 5, 14, 23, 57, 0, 0);
            // 
            // textBoxidemployee
            // 
            this.textBoxidemployee.Location = new System.Drawing.Point(202, 337);
            this.textBoxidemployee.Name = "textBoxidemployee";
            this.textBoxidemployee.Size = new System.Drawing.Size(153, 31);
            this.textBoxidemployee.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Employee";
            // 
            // Checkinlaborbyreception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 967);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxidemployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoncheckout);
            this.Controls.Add(this.dateTimePickertimeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttoncheckin);
            this.Controls.Add(this.dateTimePickertimein);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonshow);
            this.Controls.Add(this.dateTimePickerdaymonthyear);
            this.Name = "Checkinlaborbyreception";
            this.Text = "CheckinLabor";
            this.Load += new System.EventHandler(this.Checkinlaborbyreception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerdaymonthyear;
        private System.Windows.Forms.Button buttonshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickertimein;
        private System.Windows.Forms.Button buttoncheckin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttoncheckout;
        private System.Windows.Forms.DateTimePicker dateTimePickertimeout;
        private System.Windows.Forms.TextBox textBoxidemployee;
        private System.Windows.Forms.Label label3;
    }
}
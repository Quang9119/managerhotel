namespace QuanLyKhachSan
{
    partial class forgot_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgot_password));
            this.pictureBoxforgotpassword = new System.Windows.Forms.PictureBox();
            this.labelusernameforgot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.buttonSubmitpassword = new System.Windows.Forms.Button();
            this.radioButtonhumanresource = new System.Windows.Forms.RadioButton();
            this.radioButtonstudent = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforgotpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxforgotpassword
            // 
            this.pictureBoxforgotpassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxforgotpassword.Image")));
            this.pictureBoxforgotpassword.Location = new System.Drawing.Point(277, 74);
            this.pictureBoxforgotpassword.Name = "pictureBoxforgotpassword";
            this.pictureBoxforgotpassword.Size = new System.Drawing.Size(261, 208);
            this.pictureBoxforgotpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxforgotpassword.TabIndex = 0;
            this.pictureBoxforgotpassword.TabStop = false;
            // 
            // labelusernameforgot
            // 
            this.labelusernameforgot.AutoSize = true;
            this.labelusernameforgot.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.labelusernameforgot.Location = new System.Drawing.Point(72, 370);
            this.labelusernameforgot.Name = "labelusernameforgot";
            this.labelusernameforgot.Size = new System.Drawing.Size(186, 73);
            this.labelusernameforgot.TabIndex = 1;
            this.labelusernameforgot.Text = "Username :";
            this.labelusernameforgot.Click += new System.EventHandler(this.labelusernameforgot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.label2.Location = new System.Drawing.Point(79, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 73);
            this.label2.TabIndex = 1;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(277, 387);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(333, 31);
            this.textBoxusername.TabIndex = 2;
            this.textBoxusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSubmitpassword
            // 
            this.buttonSubmitpassword.BackColor = System.Drawing.Color.Green;
            this.buttonSubmitpassword.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonSubmitpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmitpassword.Location = new System.Drawing.Point(313, 609);
            this.buttonSubmitpassword.Name = "buttonSubmitpassword";
            this.buttonSubmitpassword.Size = new System.Drawing.Size(154, 79);
            this.buttonSubmitpassword.TabIndex = 3;
            this.buttonSubmitpassword.Text = "Submit";
            this.buttonSubmitpassword.UseVisualStyleBackColor = false;
            this.buttonSubmitpassword.Click += new System.EventHandler(this.buttonSubmitpassword_Click);
            // 
            // radioButtonhumanresource
            // 
            this.radioButtonhumanresource.AutoSize = true;
            this.radioButtonhumanresource.Location = new System.Drawing.Point(429, 474);
            this.radioButtonhumanresource.Name = "radioButtonhumanresource";
            this.radioButtonhumanresource.Size = new System.Drawing.Size(209, 29);
            this.radioButtonhumanresource.TabIndex = 8;
            this.radioButtonhumanresource.TabStop = true;
            this.radioButtonhumanresource.Text = "Human Resource";
            this.radioButtonhumanresource.UseVisualStyleBackColor = true;
            // 
            // radioButtonstudent
            // 
            this.radioButtonstudent.AutoSize = true;
            this.radioButtonstudent.Location = new System.Drawing.Point(130, 474);
            this.radioButtonstudent.Name = "radioButtonstudent";
            this.radioButtonstudent.Size = new System.Drawing.Size(117, 29);
            this.radioButtonstudent.TabIndex = 7;
            this.radioButtonstudent.TabStop = true;
            this.radioButtonstudent.Text = "Student";
            this.radioButtonstudent.UseVisualStyleBackColor = true;
            // 
            // forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 734);
            this.Controls.Add(this.radioButtonhumanresource);
            this.Controls.Add(this.radioButtonstudent);
            this.Controls.Add(this.buttonSubmitpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelusernameforgot);
            this.Controls.Add(this.pictureBoxforgotpassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgot_password";
            this.Text = "forgot_password";
            this.Load += new System.EventHandler(this.forgot_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforgotpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxforgotpassword;
        private System.Windows.Forms.Label labelusernameforgot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Button buttonSubmitpassword;
        private System.Windows.Forms.RadioButton radioButtonhumanresource;
        private System.Windows.Forms.RadioButton radioButtonstudent;
    }
}
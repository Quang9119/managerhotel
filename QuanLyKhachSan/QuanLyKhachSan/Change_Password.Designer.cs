namespace QuanLyKhachSan
{
    partial class Change_Password
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxpasswordold = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxforgotpassword = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderexits = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidercharacter = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSendOTP = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpasswordnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxpasswordold = new System.Windows.Forms.CheckBox();
            this.checkBoxpasswordnew = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforgotpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderexits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Green;
            this.buttonRegister.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegister.Location = new System.Drawing.Point(630, 666);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(203, 96);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Confirm";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxpasswordold
            // 
            this.textBoxpasswordold.Location = new System.Drawing.Point(401, 505);
            this.textBoxpasswordold.Name = "textBoxpasswordold";
            this.textBoxpasswordold.Size = new System.Drawing.Size(464, 31);
            this.textBoxpasswordold.TabIndex = 17;
            this.textBoxpasswordold.UseSystemPasswordChar = true;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(401, 443);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(464, 31);
            this.textBoxusername.TabIndex = 18;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.labelPassword.Location = new System.Drawing.Point(163, 488);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(232, 56);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password Old:";
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(163, 431);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(208, 43);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username :";
            // 
            // pictureBoxforgotpassword
            // 
            this.pictureBoxforgotpassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxforgotpassword.Image")));
            this.pictureBoxforgotpassword.Location = new System.Drawing.Point(401, 78);
            this.pictureBoxforgotpassword.Name = "pictureBoxforgotpassword";
            this.pictureBoxforgotpassword.Size = new System.Drawing.Size(261, 208);
            this.pictureBoxforgotpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxforgotpassword.TabIndex = 14;
            this.pictureBoxforgotpassword.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProviderexits
            // 
            this.errorProviderexits.ContainerControl = this;
            // 
            // errorProvidercharacter
            // 
            this.errorProvidercharacter.ContainerControl = this;
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.Location = new System.Drawing.Point(401, 610);
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(159, 31);
            this.textBoxOTP.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 43);
            this.label2.TabIndex = 23;
            this.label2.Text = "OTP :";
            // 
            // buttonSendOTP
            // 
            this.buttonSendOTP.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSendOTP.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonSendOTP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSendOTP.Location = new System.Drawing.Point(347, 666);
            this.buttonSendOTP.Name = "buttonSendOTP";
            this.buttonSendOTP.Size = new System.Drawing.Size(213, 96);
            this.buttonSendOTP.TabIndex = 22;
            this.buttonSendOTP.Text = "Send OPT";
            this.buttonSendOTP.UseVisualStyleBackColor = false;
            this.buttonSendOTP.Click += new System.EventHandler(this.buttonSendOTP_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(401, 386);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(464, 31);
            this.textBoxemail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email :";
            // 
            // textBoxpasswordnew
            // 
            this.textBoxpasswordnew.Location = new System.Drawing.Point(401, 561);
            this.textBoxpasswordnew.Name = "textBoxpasswordnew";
            this.textBoxpasswordnew.Size = new System.Drawing.Size(464, 31);
            this.textBoxpasswordnew.TabIndex = 26;
            this.textBoxpasswordnew.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.label3.Location = new System.Drawing.Point(163, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 64);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password New :";
            // 
            // checkBoxpasswordold
            // 
            this.checkBoxpasswordold.AutoSize = true;
            this.checkBoxpasswordold.Location = new System.Drawing.Point(881, 507);
            this.checkBoxpasswordold.Name = "checkBoxpasswordold";
            this.checkBoxpasswordold.Size = new System.Drawing.Size(197, 29);
            this.checkBoxpasswordold.TabIndex = 27;
            this.checkBoxpasswordold.Text = "Show Password";
            this.checkBoxpasswordold.UseVisualStyleBackColor = true;
            this.checkBoxpasswordold.CheckedChanged += new System.EventHandler(this.checkBoxpassword_CheckedChanged);
            // 
            // checkBoxpasswordnew
            // 
            this.checkBoxpasswordnew.AutoSize = true;
            this.checkBoxpasswordnew.Location = new System.Drawing.Point(881, 561);
            this.checkBoxpasswordnew.Name = "checkBoxpasswordnew";
            this.checkBoxpasswordnew.Size = new System.Drawing.Size(197, 29);
            this.checkBoxpasswordnew.TabIndex = 28;
            this.checkBoxpasswordnew.Text = "Show Password";
            this.checkBoxpasswordnew.UseVisualStyleBackColor = true;
            this.checkBoxpasswordnew.CheckedChanged += new System.EventHandler(this.checkBoxpasswordnew_CheckedChanged);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 840);
            this.Controls.Add(this.checkBoxpasswordnew);
            this.Controls.Add(this.checkBoxpasswordold);
            this.Controls.Add(this.textBoxpasswordnew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxpasswordold);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxforgotpassword);
            this.Controls.Add(this.textBoxOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSendOTP);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.label1);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforgotpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderexits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxpasswordold;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxforgotpassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxOTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendOTP;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderexits;
        private System.Windows.Forms.ErrorProvider errorProvidercharacter;
        private System.Windows.Forms.TextBox textBoxpasswordnew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxpasswordnew;
        private System.Windows.Forms.CheckBox checkBoxpasswordold;
    }
}
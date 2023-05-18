namespace QuanLyKhachSan
{
    partial class login
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButtonlabor = new System.Windows.Forms.RadioButton();
            this.linkLabelforgotpassword = new System.Windows.Forms.LinkLabel();
            this.checkBoxpassword = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonrêcptionist = new System.Windows.Forms.RadioButton();
            this.radioButtonmanager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(101, 285);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(208, 43);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username :";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.labelPassword.Location = new System.Drawing.Point(101, 405);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(208, 43);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password :";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(315, 302);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(464, 31);
            this.textBoxusername.TabIndex = 0;
            this.textBoxusername.TextChanged += new System.EventHandler(this.textBoxusername_TextChanged);
            this.textBoxusername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxusername_Validating);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(315, 417);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(464, 31);
            this.textBoxpassword.TabIndex = 1;
            this.textBoxpassword.UseSystemPasswordChar = true;
            this.textBoxpassword.TextChanged += new System.EventHandler(this.textBoxpassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(315, 534);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 96);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancel.Location = new System.Drawing.Point(632, 534);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 96);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(315, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 185);
            this.label3.TabIndex = 1;
            this.label3.Text = "ACOUNT LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // radioButtonlabor
            // 
            this.radioButtonlabor.AutoSize = true;
            this.radioButtonlabor.Location = new System.Drawing.Point(315, 470);
            this.radioButtonlabor.Name = "radioButtonlabor";
            this.radioButtonlabor.Size = new System.Drawing.Size(98, 29);
            this.radioButtonlabor.TabIndex = 5;
            this.radioButtonlabor.TabStop = true;
            this.radioButtonlabor.Text = "Labor";
            this.radioButtonlabor.UseVisualStyleBackColor = true;
            // 
            // linkLabelforgotpassword
            // 
            this.linkLabelforgotpassword.AutoSize = true;
            this.linkLabelforgotpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelforgotpassword.Location = new System.Drawing.Point(849, 577);
            this.linkLabelforgotpassword.Name = "linkLabelforgotpassword";
            this.linkLabelforgotpassword.Size = new System.Drawing.Size(173, 25);
            this.linkLabelforgotpassword.TabIndex = 7;
            this.linkLabelforgotpassword.TabStop = true;
            this.linkLabelforgotpassword.Text = "Fotgot Password";
            this.linkLabelforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelforgotpassword_LinkClicked_1);
            // 
            // checkBoxpassword
            // 
            this.checkBoxpassword.AutoSize = true;
            this.checkBoxpassword.Location = new System.Drawing.Point(796, 419);
            this.checkBoxpassword.Name = "checkBoxpassword";
            this.checkBoxpassword.Size = new System.Drawing.Size(197, 29);
            this.checkBoxpassword.TabIndex = 8;
            this.checkBoxpassword.Text = "Show Password";
            this.checkBoxpassword.UseVisualStyleBackColor = true;
            this.checkBoxpassword.CheckedChanged += new System.EventHandler(this.checkBoxpassword_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(820, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 25);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change  Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonrêcptionist
            // 
            this.radioButtonrêcptionist.AutoSize = true;
            this.radioButtonrêcptionist.Location = new System.Drawing.Point(477, 470);
            this.radioButtonrêcptionist.Name = "radioButtonrêcptionist";
            this.radioButtonrêcptionist.Size = new System.Drawing.Size(162, 29);
            this.radioButtonrêcptionist.TabIndex = 10;
            this.radioButtonrêcptionist.TabStop = true;
            this.radioButtonrêcptionist.Text = "Receptionist";
            this.radioButtonrêcptionist.UseVisualStyleBackColor = true;
            // 
            // radioButtonmanager
            // 
            this.radioButtonmanager.AutoSize = true;
            this.radioButtonmanager.Location = new System.Drawing.Point(654, 470);
            this.radioButtonmanager.Name = "radioButtonmanager";
            this.radioButtonmanager.Size = new System.Drawing.Size(128, 29);
            this.radioButtonmanager.TabIndex = 11;
            this.radioButtonmanager.TabStop = true;
            this.radioButtonmanager.Text = "Manager";
            this.radioButtonmanager.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 655);
            this.Controls.Add(this.radioButtonmanager);
            this.Controls.Add(this.radioButtonrêcptionist);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxpassword);
            this.Controls.Add(this.linkLabelforgotpassword);
            this.Controls.Add(this.radioButtonlabor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioButtonlabor;
        private System.Windows.Forms.LinkLabel linkLabelforgotpassword;
        private System.Windows.Forms.CheckBox checkBoxpassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButtonmanager;
        private System.Windows.Forms.RadioButton radioButtonrêcptionist;
    }
}


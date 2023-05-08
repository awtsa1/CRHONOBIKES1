namespace WindowsFormsApplication4
{
    partial class chronobike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chronobike));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signupLinklabel = new System.Windows.Forms.LinkLabel();
            this.register = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.Label();
            this.signinTITLE = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.signupLinklabel);
            this.loginPanel.Controls.Add(this.register);
            this.loginPanel.Controls.Add(this.forgotpass);
            this.loginPanel.Controls.Add(this.signinTITLE);
            this.loginPanel.Controls.Add(this.loginBTN);
            this.loginPanel.Controls.Add(this.passTextBox);
            this.loginPanel.Controls.Add(this.emailTextBox);
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.email);
            this.loginPanel.Location = new System.Drawing.Point(53, 48);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(223, 299);
            this.loginPanel.TabIndex = 0;
            // 
            // signupLinklabel
            // 
            this.signupLinklabel.AutoSize = true;
            this.signupLinklabel.Location = new System.Drawing.Point(153, 268);
            this.signupLinklabel.Name = "signupLinklabel";
            this.signupLinklabel.Size = new System.Drawing.Size(43, 13);
            this.signupLinklabel.TabIndex = 1;
            this.signupLinklabel.TabStop = true;
            this.signupLinklabel.Text = "Sign up";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(18, 268);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(138, 13);
            this.register.TabIndex = 7;
            this.register.Text = "Dont have an account?";
            this.register.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.Location = new System.Drawing.Point(101, 178);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(107, 13);
            this.forgotpass.TabIndex = 6;
            this.forgotpass.Text = "Forgot Password?";
            // 
            // signinTITLE
            // 
            this.signinTITLE.AutoSize = true;
            this.signinTITLE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinTITLE.Location = new System.Drawing.Point(15, 24);
            this.signinTITLE.Name = "signinTITLE";
            this.signinTITLE.Size = new System.Drawing.Size(194, 18);
            this.signinTITLE.TabIndex = 5;
            this.signinTITLE.Text = "Sign in to your account";
            this.signinTITLE.Click += new System.EventHandler(this.titlename_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(72, 216);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(75, 23);
            this.loginBTN.TabIndex = 4;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.White;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextBox.Location = new System.Drawing.Point(20, 148);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(183, 20);
            this.passTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Location = new System.Drawing.Point(20, 89);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(183, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(17, 130);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(17, 71);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email Address";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // chronobike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(589, 376);
            this.Controls.Add(this.loginPanel);
            this.Name = "chronobike";
            this.Text = "Chrono Bikes V1";
            this.Load += new System.EventHandler(this.chronobike_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label forgotpass;
        private System.Windows.Forms.Label signinTITLE;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.LinkLabel signupLinklabel;
    }
}


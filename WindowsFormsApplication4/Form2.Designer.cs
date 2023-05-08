namespace WindowsFormsApplication4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.signinPANEL = new System.Windows.Forms.Panel();
            this.signupTITLE = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.textBoxFNAME = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.textBoxLNAME = new System.Windows.Forms.TextBox();
            this.emailAdd = new System.Windows.Forms.Label();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textBoxPASS = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.textBoxAGE = new System.Windows.Forms.TextBox();
            this.signinPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinPANEL
            // 
            this.signinPANEL.BackColor = System.Drawing.Color.White;
            this.signinPANEL.Controls.Add(this.textBoxAGE);
            this.signinPANEL.Controls.Add(this.age);
            this.signinPANEL.Controls.Add(this.textBoxPASS);
            this.signinPANEL.Controls.Add(this.password);
            this.signinPANEL.Controls.Add(this.textBoxEMAIL);
            this.signinPANEL.Controls.Add(this.emailAdd);
            this.signinPANEL.Controls.Add(this.textBoxLNAME);
            this.signinPANEL.Controls.Add(this.lastName);
            this.signinPANEL.Controls.Add(this.textBoxFNAME);
            this.signinPANEL.Controls.Add(this.firstName);
            this.signinPANEL.Controls.Add(this.signupTITLE);
            this.signinPANEL.Location = new System.Drawing.Point(27, 26);
            this.signinPANEL.Name = "signinPANEL";
            this.signinPANEL.Size = new System.Drawing.Size(518, 314);
            this.signinPANEL.TabIndex = 2;
            // 
            // signupTITLE
            // 
            this.signupTITLE.AutoSize = true;
            this.signupTITLE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupTITLE.Location = new System.Drawing.Point(29, 25);
            this.signupTITLE.Name = "signupTITLE";
            this.signupTITLE.Size = new System.Drawing.Size(200, 18);
            this.signupTITLE.TabIndex = 6;
            this.signupTITLE.Text = "Sign up to your account";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(29, 69);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(78, 13);
            this.firstName.TabIndex = 7;
            this.firstName.Text = "First Name";
            // 
            // textBoxFNAME
            // 
            this.textBoxFNAME.BackColor = System.Drawing.Color.White;
            this.textBoxFNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFNAME.Location = new System.Drawing.Point(32, 84);
            this.textBoxFNAME.Name = "textBoxFNAME";
            this.textBoxFNAME.Size = new System.Drawing.Size(142, 20);
            this.textBoxFNAME.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(29, 121);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(75, 13);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "Last Name";
            // 
            // textBoxLNAME
            // 
            this.textBoxLNAME.BackColor = System.Drawing.Color.White;
            this.textBoxLNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLNAME.Location = new System.Drawing.Point(32, 136);
            this.textBoxLNAME.Name = "textBoxLNAME";
            this.textBoxLNAME.Size = new System.Drawing.Size(142, 20);
            this.textBoxLNAME.TabIndex = 10;
            // 
            // emailAdd
            // 
            this.emailAdd.AutoSize = true;
            this.emailAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdd.Location = new System.Drawing.Point(29, 176);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(100, 13);
            this.emailAdd.TabIndex = 11;
            this.emailAdd.Text = "Email Address";
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.BackColor = System.Drawing.Color.White;
            this.textBoxEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEMAIL.Location = new System.Drawing.Point(32, 192);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(142, 20);
            this.textBoxEMAIL.TabIndex = 12;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(29, 227);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 13);
            this.password.TabIndex = 13;
            this.password.Text = "Password";
            // 
            // textBoxPASS
            // 
            this.textBoxPASS.BackColor = System.Drawing.Color.White;
            this.textBoxPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPASS.Location = new System.Drawing.Point(32, 243);
            this.textBoxPASS.Name = "textBoxPASS";
            this.textBoxPASS.Size = new System.Drawing.Size(142, 20);
            this.textBoxPASS.TabIndex = 14;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(247, 69);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 13);
            this.age.TabIndex = 15;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // textBoxAGE
            // 
            this.textBoxAGE.BackColor = System.Drawing.Color.White;
            this.textBoxAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAGE.Location = new System.Drawing.Point(250, 84);
            this.textBoxAGE.Name = "textBoxAGE";
            this.textBoxAGE.Size = new System.Drawing.Size(142, 20);
            this.textBoxAGE.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 376);
            this.Controls.Add(this.signinPANEL);
            this.Name = "Form2";
            this.Text = "Form2";
            this.signinPANEL.ResumeLayout(false);
            this.signinPANEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signinPANEL;
        private System.Windows.Forms.Label signupTITLE;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox textBoxFNAME;
        private System.Windows.Forms.TextBox textBoxLNAME;
        private System.Windows.Forms.Label emailAdd;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxPASS;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBoxAGE;
        private System.Windows.Forms.Label age;
    }
}
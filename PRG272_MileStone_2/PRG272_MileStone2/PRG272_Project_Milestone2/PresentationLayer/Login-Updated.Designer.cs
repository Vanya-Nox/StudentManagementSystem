namespace PRG272_Project_Milestone2.PresentationLayer
{
    partial class Login_Updated
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameText = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login or Registration";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(142, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(121, 123);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(55, 13);
            this.UsernameText.TabIndex = 2;
            this.UsernameText.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(269, 116);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(293, 251);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(121, 196);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(53, 13);
            this.PasswordText.TabIndex = 5;
            this.PasswordText.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // Login_Updated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 316);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Name = "Login_Updated";
            this.Text = "Login_Updated";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox textBox1;
    }
}
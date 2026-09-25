using System;
using System.Windows.Forms;

namespace Sign_in___Sign_up
{
    partial class Form1
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
            this.signInGroup = new System.Windows.Forms.GroupBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.showSignInPassword = new System.Windows.Forms.CheckBox();
            this.signInPassword = new System.Windows.Forms.TextBox();
            this.signInPasswordLabel = new System.Windows.Forms.Label();
            this.signInUsername = new System.Windows.Forms.TextBox();
            this.signInUsernameLabel = new System.Windows.Forms.Label();
            this.signUpGroup = new System.Windows.Forms.GroupBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.showSignUpPassword = new System.Windows.Forms.CheckBox();
            this.signUpPassword = new System.Windows.Forms.TextBox();
            this.signUpPasswordLabel = new System.Windows.Forms.Label();
            this.signUpUsername = new System.Windows.Forms.TextBox();
            this.signUpUsernameLabel = new System.Windows.Forms.Label();
            this.signInGroup.SuspendLayout();
            this.signUpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInGroup
            // 
            this.signInGroup.Controls.Add(this.signInButton);
            this.signInGroup.Controls.Add(this.showSignInPassword);
            this.signInGroup.Controls.Add(this.signInPassword);
            this.signInGroup.Controls.Add(this.signInPasswordLabel);
            this.signInGroup.Controls.Add(this.signInUsername);
            this.signInGroup.Controls.Add(this.signInUsernameLabel);
            this.signInGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signInGroup.Location = new System.Drawing.Point(15, 25);
            this.signInGroup.Name = "signInGroup";
            this.signInGroup.Size = new System.Drawing.Size(277, 260);
            this.signInGroup.TabIndex = 0;
            this.signInGroup.TabStop = false;
            this.signInGroup.Text = "Sign In";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(42, 210);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(189, 35);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // showSignInPassword
            // 
            this.showSignInPassword.AutoSize = true;
            this.showSignInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSignInPassword.Location = new System.Drawing.Point(23, 171);
            this.showSignInPassword.Name = "showSignInPassword";
            this.showSignInPassword.Size = new System.Drawing.Size(134, 17);
            this.showSignInPassword.TabIndex = 4;
            this.showSignInPassword.Text = "Show me password";
            this.showSignInPassword.UseVisualStyleBackColor = true;
            this.showSignInPassword.CheckedChanged += new System.EventHandler(this.showSignInPassword_CheckedChanged);
            // 
            // signInPassword
            // 
            this.signInPassword.Location = new System.Drawing.Point(23, 124);
            this.signInPassword.Name = "signInPassword";
            this.signInPassword.Size = new System.Drawing.Size(231, 20);
            this.signInPassword.TabIndex = 3;
            this.signInPassword.UseSystemPasswordChar = true;
            // 
            // signInPasswordLabel
            // 
            this.signInPasswordLabel.AutoSize = true;
            this.signInPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInPasswordLabel.Location = new System.Drawing.Point(23, 107);
            this.signInPasswordLabel.Name = "signInPasswordLabel";
            this.signInPasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.signInPasswordLabel.TabIndex = 2;
            this.signInPasswordLabel.Text = "Password";
            // 
            // signInUsername
            // 
            this.signInUsername.Location = new System.Drawing.Point(23, 54);
            this.signInUsername.Name = "signInUsername";
            this.signInUsername.Size = new System.Drawing.Size(231, 20);
            this.signInUsername.TabIndex = 1;
            // 
            // signInUsernameLabel
            // 
            this.signInUsernameLabel.AutoSize = true;
            this.signInUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInUsernameLabel.Location = new System.Drawing.Point(23, 37);
            this.signInUsernameLabel.Name = "signInUsernameLabel";
            this.signInUsernameLabel.Size = new System.Drawing.Size(63, 13);
            this.signInUsernameLabel.TabIndex = 0;
            this.signInUsernameLabel.Text = "Username";
            // 
            // signUpGroup
            // 
            this.signUpGroup.Controls.Add(this.signUpButton);
            this.signUpGroup.Controls.Add(this.showSignUpPassword);
            this.signUpGroup.Controls.Add(this.signUpPassword);
            this.signUpGroup.Controls.Add(this.signUpPasswordLabel);
            this.signUpGroup.Controls.Add(this.signUpUsername);
            this.signUpGroup.Controls.Add(this.signUpUsernameLabel);
            this.signUpGroup.Location = new System.Drawing.Point(356, 25);
            this.signUpGroup.Name = "signUpGroup";
            this.signUpGroup.Size = new System.Drawing.Size(277, 260);
            this.signUpGroup.TabIndex = 1;
            this.signUpGroup.TabStop = false;
            this.signUpGroup.Text = "Sign Up";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(42, 210);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(189, 35);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "SIgn up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // showSignUpPassword
            // 
            this.showSignUpPassword.AutoSize = true;
            this.showSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSignUpPassword.Location = new System.Drawing.Point(23, 171);
            this.showSignUpPassword.Name = "showSignUpPassword";
            this.showSignUpPassword.Size = new System.Drawing.Size(134, 17);
            this.showSignUpPassword.TabIndex = 5;
            this.showSignUpPassword.Text = "Show me password";
            this.showSignUpPassword.UseVisualStyleBackColor = true;
            this.showSignUpPassword.CheckedChanged += new System.EventHandler(this.showSignUpPassword_CheckedChanged);
            // 
            // signUpPassword
            // 
            this.signUpPassword.Location = new System.Drawing.Point(23, 126);
            this.signUpPassword.Name = "signUpPassword";
            this.signUpPassword.Size = new System.Drawing.Size(231, 20);
            this.signUpPassword.TabIndex = 4;
            this.signUpPassword.UseSystemPasswordChar = true;
            // 
            // signUpPasswordLabel
            // 
            this.signUpPasswordLabel.AutoSize = true;
            this.signUpPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPasswordLabel.Location = new System.Drawing.Point(29, 107);
            this.signUpPasswordLabel.Name = "signUpPasswordLabel";
            this.signUpPasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.signUpPasswordLabel.TabIndex = 3;
            this.signUpPasswordLabel.Text = "Password";
            // 
            // signUpUsername
            // 
            this.signUpUsername.Location = new System.Drawing.Point(23, 54);
            this.signUpUsername.Name = "signUpUsername";
            this.signUpUsername.Size = new System.Drawing.Size(231, 20);
            this.signUpUsername.TabIndex = 2;
            // 
            // signUpUsernameLabel
            // 
            this.signUpUsernameLabel.AutoSize = true;
            this.signUpUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpUsernameLabel.Location = new System.Drawing.Point(27, 35);
            this.signUpUsernameLabel.Name = "signUpUsernameLabel";
            this.signUpUsernameLabel.Size = new System.Drawing.Size(63, 13);
            this.signUpUsernameLabel.TabIndex = 1;
            this.signUpUsernameLabel.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.signUpGroup);
            this.Controls.Add(this.signInGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.signInGroup.ResumeLayout(false);
            this.signInGroup.PerformLayout();
            this.signUpGroup.ResumeLayout(false);
            this.signUpGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (signUpUsername.Text == "" || signUpPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
            }
            else
            {
                savedUsername = signUpUsername.Text;
                savedPassword = signUpPassword.Text;

                MessageBox.Show("Sign up successful!");
            }
        }

        private void showSignUpPassword_CheckedChanged(object sender, EventArgs e)
        {
            signUpPassword.UseSystemPasswordChar = !showSignUpPassword.Checked;

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (savedUsername == "" || savedPassword == "")
            {
                MessageBox.Show("Please sign up first.");
            }
            else if (signInUsername.Text == savedUsername &&
                     signInPassword.Text == savedPassword)
            {
                MessageBox.Show("Sign in successful!");
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void showSignInPassword_CheckedChanged(object sender, EventArgs e)
        {
            signInPassword.UseSystemPasswordChar = !showSignInPassword.Checked;
        }

        #endregion

        private System.Windows.Forms.GroupBox signInGroup;
        private System.Windows.Forms.TextBox signInUsername;
        private System.Windows.Forms.Label signInUsernameLabel;
        private System.Windows.Forms.GroupBox signUpGroup;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.CheckBox showSignInPassword;
        private System.Windows.Forms.TextBox signInPassword;
        private System.Windows.Forms.Label signInPasswordLabel;
        private System.Windows.Forms.CheckBox showSignUpPassword;
        private System.Windows.Forms.TextBox signUpPassword;
        private System.Windows.Forms.Label signUpPasswordLabel;
        private System.Windows.Forms.TextBox signUpUsername;
        private System.Windows.Forms.Label signUpUsernameLabel;
        private System.Windows.Forms.Button signUpButton;
    }
}


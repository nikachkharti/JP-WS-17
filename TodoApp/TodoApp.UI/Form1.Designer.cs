namespace TodoApp.UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.newUserLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.headerLabel.Location = new System.Drawing.Point(85, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(219, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "ავტორიზაცია";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(12, 128);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(348, 27);
            this.emailValue.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 105);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 20);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "ელ-ფოსტა";
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(0, 240);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(372, 47);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "ავტორიზაცია";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // newUserLink
            // 
            this.newUserLink.AutoSize = true;
            this.newUserLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUserLink.Location = new System.Drawing.Point(184, 105);
            this.newUserLink.Name = "newUserLink";
            this.newUserLink.Size = new System.Drawing.Size(176, 20);
            this.newUserLink.TabIndex = 3;
            this.newUserLink.TabStop = true;
            this.newUserLink.Text = "ახალი მომხმარებელი";
            this.newUserLink.Click += new System.EventHandler(this.newUserLink_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.newUserLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ავტორიზაცია";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button loginBtn;
        private LinkLabel newUserLink;
    }
}
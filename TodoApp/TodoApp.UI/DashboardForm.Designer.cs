namespace TodoApp.UI
{
    partial class DashboardForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.planedIcon = new System.Windows.Forms.PictureBox();
            this.starPicture = new System.Windows.Forms.PictureBox();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.myProfileLabel = new System.Windows.Forms.Label();
            this.planedLabel = new System.Windows.Forms.Label();
            this.importantLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.TodoUserControlPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(1423, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(39, 28);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "***";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.planedIcon);
            this.sidebarPanel.Controls.Add(this.starPicture);
            this.sidebarPanel.Controls.Add(this.mainPicture);
            this.sidebarPanel.Controls.Add(this.logoPicture);
            this.sidebarPanel.Controls.Add(this.myProfileLabel);
            this.sidebarPanel.Controls.Add(this.planedLabel);
            this.sidebarPanel.Controls.Add(this.importantLabel);
            this.sidebarPanel.Controls.Add(this.mainLabel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(257, 758);
            this.sidebarPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TodoApp.UI.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(12, 714);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // planedIcon
            // 
            this.planedIcon.Image = global::TodoApp.UI.Properties.Resources.planned;
            this.planedIcon.Location = new System.Drawing.Point(12, 273);
            this.planedIcon.Name = "planedIcon";
            this.planedIcon.Size = new System.Drawing.Size(32, 32);
            this.planedIcon.TabIndex = 2;
            this.planedIcon.TabStop = false;
            // 
            // starPicture
            // 
            this.starPicture.Image = global::TodoApp.UI.Properties.Resources.staroutline_81125;
            this.starPicture.Location = new System.Drawing.Point(12, 204);
            this.starPicture.Name = "starPicture";
            this.starPicture.Size = new System.Drawing.Size(32, 32);
            this.starPicture.TabIndex = 2;
            this.starPicture.TabStop = false;
            // 
            // mainPicture
            // 
            this.mainPicture.Image = global::TodoApp.UI.Properties.Resources.home;
            this.mainPicture.Location = new System.Drawing.Point(12, 140);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(32, 32);
            this.mainPicture.TabIndex = 2;
            this.mainPicture.TabStop = false;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::TodoApp.UI.Properties.Resources.logo;
            this.logoPicture.Location = new System.Drawing.Point(50, 12);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(100, 100);
            this.logoPicture.TabIndex = 1;
            this.logoPicture.TabStop = false;
            // 
            // myProfileLabel
            // 
            this.myProfileLabel.AutoSize = true;
            this.myProfileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfileLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfileLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.myProfileLabel.Location = new System.Drawing.Point(50, 715);
            this.myProfileLabel.Name = "myProfileLabel";
            this.myProfileLabel.Size = new System.Drawing.Size(196, 31);
            this.myProfileLabel.TabIndex = 0;
            this.myProfileLabel.Text = "ჩემი პროფილი";
            this.myProfileLabel.Click += new System.EventHandler(this.myProfileLabel_Click);
            // 
            // planedLabel
            // 
            this.planedLabel.AutoSize = true;
            this.planedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.planedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.planedLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.planedLabel.Location = new System.Drawing.Point(50, 274);
            this.planedLabel.Name = "planedLabel";
            this.planedLabel.Size = new System.Drawing.Size(154, 31);
            this.planedLabel.TabIndex = 0;
            this.planedLabel.Text = "დაგეგმილი";
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importantLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importantLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.importantLabel.Location = new System.Drawing.Point(50, 205);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(142, 31);
            this.importantLabel.TabIndex = 0;
            this.importantLabel.Text = "ფავორიტი";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainLabel.Location = new System.Drawing.Point(50, 141);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(118, 31);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "მთავარი";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // TodoUserControlPanel
            // 
            this.TodoUserControlPanel.Location = new System.Drawing.Point(263, 56);
            this.TodoUserControlPanel.Name = "TodoUserControlPanel";
            this.TodoUserControlPanel.Size = new System.Drawing.Size(1189, 690);
            this.TodoUserControlPanel.TabIndex = 2;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 758);
            this.Controls.Add(this.TodoUserControlPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "მთავარი გვერდი";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Panel sidebarPanel;
        private Label mainLabel;
        private PictureBox mainPicture;
        private PictureBox logoPicture;
        private PictureBox starPicture;
        private Label importantLabel;
        private PictureBox pictureBox1;
        private PictureBox planedIcon;
        private Label myProfileLabel;
        private Label planedLabel;
        private Panel TodoUserControlPanel;
    }
}
namespace TodoApp.UI
{
    partial class TodosUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.titleValue = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionValue = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateValue = new System.Windows.Forms.DateTimePicker();
            this.statusValue = new System.Windows.Forms.ComboBox();
            this.priorityValue = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.editTodoBtn = new System.Windows.Forms.Button();
            this.addTodoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.BackColor = System.Drawing.SystemColors.Control;
            this.todoListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.todoListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 28;
            this.todoListBox.Location = new System.Drawing.Point(0, 0);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(610, 690);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            // 
            // titleValue
            // 
            this.titleValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleValue.Location = new System.Drawing.Point(616, 46);
            this.titleValue.Name = "titleValue";
            this.titleValue.Size = new System.Drawing.Size(565, 38);
            this.titleValue.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(616, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "სათაური";
            // 
            // descriptionValue
            // 
            this.descriptionValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionValue.Location = new System.Drawing.Point(615, 110);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(565, 156);
            this.descriptionValue.TabIndex = 3;
            this.descriptionValue.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(615, 87);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "აღწერა";
            // 
            // startDateValue
            // 
            this.startDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDateValue.CustomFormat = "yyy-MM-dd HH:mm";
            this.startDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateValue.Location = new System.Drawing.Point(616, 304);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(279, 34);
            this.startDateValue.TabIndex = 4;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(616, 281);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(70, 20);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "დაწყება";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(901, 281);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(100, 20);
            this.dueDateLabel.TabIndex = 2;
            this.dueDateLabel.Text = "დასრულება";
            // 
            // dueDateValue
            // 
            this.dueDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dueDateValue.CustomFormat = "yyy-MM-dd HH:mm";
            this.dueDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dueDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDateValue.Location = new System.Drawing.Point(901, 304);
            this.dueDateValue.Name = "dueDateValue";
            this.dueDateValue.Size = new System.Drawing.Size(279, 34);
            this.dueDateValue.TabIndex = 4;
            // 
            // statusValue
            // 
            this.statusValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusValue.FormattingEnabled = true;
            this.statusValue.Items.AddRange(new object[] {
            "შესასრულებელი",
            "მიმდინარე",
            "შესრულებული"});
            this.statusValue.Location = new System.Drawing.Point(616, 430);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(279, 36);
            this.statusValue.TabIndex = 5;
            // 
            // priorityValue
            // 
            this.priorityValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priorityValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priorityValue.FormattingEnabled = true;
            this.priorityValue.Items.AddRange(new object[] {
            "დაბალი",
            "საშუალო",
            "მაღალი",
            "გადაუდებელი"});
            this.priorityValue.Location = new System.Drawing.Point(902, 430);
            this.priorityValue.Name = "priorityValue";
            this.priorityValue.Size = new System.Drawing.Size(279, 36);
            this.priorityValue.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(617, 403);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(75, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "სტატუსი";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(902, 403);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(107, 20);
            this.priorityLabel.TabIndex = 2;
            this.priorityLabel.Text = "პრიორიტეტი";
            // 
            // editTodoBtn
            // 
            this.editTodoBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editTodoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTodoBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editTodoBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editTodoBtn.ForeColor = System.Drawing.Color.White;
            this.editTodoBtn.Location = new System.Drawing.Point(610, 637);
            this.editTodoBtn.Name = "editTodoBtn";
            this.editTodoBtn.Size = new System.Drawing.Size(579, 53);
            this.editTodoBtn.TabIndex = 6;
            this.editTodoBtn.Text = "რედაქტირება";
            this.editTodoBtn.UseVisualStyleBackColor = false;
            this.editTodoBtn.Click += new System.EventHandler(this.editTodoBtn_Click);
            // 
            // addTodoBtn
            // 
            this.addTodoBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addTodoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTodoBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addTodoBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTodoBtn.ForeColor = System.Drawing.Color.White;
            this.addTodoBtn.Location = new System.Drawing.Point(610, 584);
            this.addTodoBtn.Name = "addTodoBtn";
            this.addTodoBtn.Size = new System.Drawing.Size(579, 53);
            this.addTodoBtn.TabIndex = 6;
            this.addTodoBtn.Text = "ახალი საქმე";
            this.addTodoBtn.UseVisualStyleBackColor = false;
            // 
            // TodosUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addTodoBtn);
            this.Controls.Add(this.editTodoBtn);
            this.Controls.Add(this.priorityValue);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.dueDateValue);
            this.Controls.Add(this.startDateValue);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleValue);
            this.Controls.Add(this.todoListBox);
            this.Name = "TodosUserControl";
            this.Size = new System.Drawing.Size(1189, 690);
            this.Load += new System.EventHandler(this.TodosUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox todoListBox;
        private TextBox titleValue;
        private Label titleLabel;
        private RichTextBox descriptionValue;
        private Label descriptionLabel;
        private DateTimePicker startDateValue;
        private Label startDateLabel;
        private Label dueDateLabel;
        private DateTimePicker dueDateValue;
        private ComboBox statusValue;
        private ComboBox priorityValue;
        private Label statusLabel;
        private Label priorityLabel;
        private Button editTodoBtn;
        private Button addTodoBtn;
    }
}

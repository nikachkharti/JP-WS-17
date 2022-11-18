using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Services;
using TodoApp.Library;

namespace TodoApp.UI
{
    public partial class TodosUserControl : UserControl
    {
        private readonly User _loggedInUser;
        private readonly List<Library.Todo> todosForUser = new();
        public TodosUserControl(User loggedInUser)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            InitializeComponent();

            _loggedInUser = loggedInUser;
            todosForUser.AddRange(GlobalConfig.ConnectionType.GetAllTodosPerUser(loggedInUser));

#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void TodosUserControl_Load(object sender, EventArgs e)
        {
            todoListBox.DataSource = todosForUser;
            titleValue.Text = todosForUser[todoListBox.SelectedIndex].Title;
            descriptionValue.Text = todosForUser[todoListBox.SelectedIndex].Description;
            startDateValue.Value = todosForUser[todoListBox.SelectedIndex].StartDate;
            dueDateValue.Value = todosForUser[todoListBox.SelectedIndex].DueDate;
            statusValue.Text = todosForUser[todoListBox.SelectedIndex].Status;
            priorityValue.Text = todosForUser[todoListBox.SelectedIndex].Priority;
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleValue.Text = todosForUser[todoListBox.SelectedIndex].Title;
            descriptionValue.Text = todosForUser[todoListBox.SelectedIndex].Description;
            startDateValue.Value = todosForUser[todoListBox.SelectedIndex].StartDate;
            dueDateValue.Value = todosForUser[todoListBox.SelectedIndex].DueDate;
            statusValue.Text = todosForUser[todoListBox.SelectedIndex].Status;
            priorityValue.Text = todosForUser[todoListBox.SelectedIndex].Priority;
        }
    }
}

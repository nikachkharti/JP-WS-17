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
        private readonly List<Library.Todo> editedAllTodos = new();

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
            try
            {
                todoListBox.DataSource = todosForUser;
                titleValue.Text = todosForUser[todoListBox.SelectedIndex].Title;
                descriptionValue.Text = todosForUser[todoListBox.SelectedIndex].Description;
                startDateValue.Value = todosForUser[todoListBox.SelectedIndex].StartDate;
                dueDateValue.Value = todosForUser[todoListBox.SelectedIndex].DueDate;
                statusValue.Text = todosForUser[todoListBox.SelectedIndex].Status;
                priorityValue.Text = todosForUser[todoListBox.SelectedIndex].Priority;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 titleValue.Text = todosForUser[todoListBox.SelectedIndex].Title;
                 descriptionValue.Text = todosForUser[todoListBox.SelectedIndex].Description;
                 startDateValue.Value = todosForUser[todoListBox.SelectedIndex].StartDate;
                 dueDateValue.Value = todosForUser[todoListBox.SelectedIndex].DueDate;
                 statusValue.Text = todosForUser[todoListBox.SelectedIndex].Status;
                 priorityValue.Text = todosForUser[todoListBox.SelectedIndex].Priority; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editTodoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxesAreValid() && DateTimesAreValid() && StatusComboBoxIsValid() && PriorityComboBoxIsValid())
                {
                    Library.Todo todoToEdit = new()
                    {
                        Title = titleValue.Text,
                        Description = descriptionValue.Text,
                        StartDate = startDateValue.Value,
                        DueDate = dueDateValue.Value,
                        Status = statusValue.Text,
                        Priority = priorityValue.Text,
                        TodoId = todosForUser[todoListBox.SelectedIndex].TodoId
                    };

                    GlobalConfig.ConnectionType.EditTodo(todoToEdit);

                    editedAllTodos.AddRange(GlobalConfig.ConnectionType.GetAllTodosPerUser(_loggedInUser));

                    RefreshWindows();

                    MessageBox.Show("მონაცემები წარმატებით დარედაქტირდა", "მონაცემები დარედაქტირდა", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show("შემოყვანილი მონაცემები არასწორია", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool TextBoxesAreValid()
        {
            return !string.IsNullOrWhiteSpace(titleValue.Text) && !string.IsNullOrWhiteSpace(descriptionValue.Text);
        }
        private bool DateTimesAreValid()
        {
            return dueDateValue.Value >= startDateValue.Value;
        }
        private bool StatusComboBoxIsValid()
        {
            return statusValue.Text == "შესასრულებელი" || statusValue.Text == "მიმდინარე" || statusValue.Text == "შესრულებული";
        }        
        private bool PriorityComboBoxIsValid()
        {
            return priorityValue.Text == "დაბალი" || priorityValue.Text == "საშუალო" || priorityValue.Text == "მაღალი" || priorityValue.Text == "გადაუდებელი";
        }

        private void RefreshWindows()
        {
            todoListBox.DataSource = editedAllTodos;
            titleValue.Text = editedAllTodos[todoListBox.SelectedIndex].Title;
            descriptionValue.Text = editedAllTodos[todoListBox.SelectedIndex].Description;
            startDateValue.Value = editedAllTodos[todoListBox.SelectedIndex].StartDate;
            dueDateValue.Value = editedAllTodos[todoListBox.SelectedIndex].DueDate;
            statusValue.Text = editedAllTodos[todoListBox.SelectedIndex].Status;
            priorityValue.Text = editedAllTodos[todoListBox.SelectedIndex].Priority;
        }
    }
}

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
        List<Library.Todo> allTodosOfUser = new();

        public TodosUserControl(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
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
        private async void TodosUserControl_Load(object sender, EventArgs e)
        {
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                allTodosOfUser = await GlobalConfig.ConnectionType.GetAllTodosPerUser(_loggedInUser);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                todoListBox.DataSource = allTodosOfUser;
                titleValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Title;
                descriptionValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Description;
                startDateValue.Value = allTodosOfUser[todoListBox.SelectedIndex].StartDate;
                dueDateValue.Value = allTodosOfUser[todoListBox.SelectedIndex].DueDate;
                statusValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Status;
                priorityValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Priority;
            }
            catch
            {
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                todoListBox.DataSource = allTodosOfUser;
                titleValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Title;
                descriptionValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Description;
                startDateValue.Value = allTodosOfUser[todoListBox.SelectedIndex].StartDate;
                dueDateValue.Value = allTodosOfUser[todoListBox.SelectedIndex].DueDate;
                statusValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Status;
                priorityValue.Text = allTodosOfUser[todoListBox.SelectedIndex].Priority;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void editTodoBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesAreValid() && DateTimesAreValid() && StatusComboBoxIsValid() && PriorityComboBoxIsValid())
            {
                DialogResult editDialog = MessageBox.Show("ნამდვილად გსურთ საქმის რედაქტირება?", "საქმის რედაქტირება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editDialog == DialogResult.Yes)
                {
                    Library.Todo editedTodo = new()
                    {
                        TodoId = allTodosOfUser[todoListBox.SelectedIndex].TodoId,
                        Title = titleValue.Text,
                        Description = descriptionValue.Text,
                        StartDate = startDateValue.Value,
                        DueDate = dueDateValue.Value,
                        Status = statusValue.Text,
                        Priority = priorityValue.Text
                    };

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    await GlobalConfig.ConnectionType.EditTodo(editedTodo);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    //Refreshing data after update
                    allTodosOfUser = await GlobalConfig.ConnectionType.GetAllTodosPerUser(_loggedInUser);
                    todoListBox.DataSource = allTodosOfUser;
                    MessageBox.Show("თქვენს მიერ შემოყვანილი ინფორმაცია წარმატებით დარედაქტირდა", "წარმატებული ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შემოყვანილი ინფორმაცია არ არის კორექტული", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addTodoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxesAreValid() && DateTimesAreValid() && StatusComboBoxIsValid() && PriorityComboBoxIsValid())
                {
                    DialogResult addDialog = MessageBox.Show("ნამდვილად გსურთ საქმის დამატება?", "საქმის დამატება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (addDialog == DialogResult.Yes)
                    {
                        Library.Todo todoToAdd = new()
                        {
                            Title = titleValue.Text,
                            Description = descriptionValue.Text,
                            StartDate = startDateValue.Value,
                            DueDate = dueDateValue.Value,
                            Status = statusValue.Text,
                            Priority = priorityValue.Text,
                            UserId = _loggedInUser.UserId
                        };

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        await GlobalConfig.ConnectionType.AddTodo(todoToAdd);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                        //Refreshing data after update
                        allTodosOfUser = await GlobalConfig.ConnectionType.GetAllTodosPerUser(_loggedInUser);
                        todoListBox.DataSource = allTodosOfUser;
                        MessageBox.Show("თქვენს მიერ შემოყვანილი საქმე წარმატებით დაემატა", "საქმე დაემატა", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    }
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შემოყვანილი ინფორმაცია არ არის კორექტული", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClearForm()
        {
            titleValue.Text = string.Empty;
            descriptionValue.Text = string.Empty;
            startDateValue.Value = DateTime.Now;
            dueDateValue.Value = DateTime.Now;
            statusValue.Text = "შესასრულებელი";
            priorityValue.Text = "საშუალო";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

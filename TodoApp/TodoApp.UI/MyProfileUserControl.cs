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
    public partial class MyProfileUserControl : UserControl
    {
        private User _loggedInUser = new();
        public MyProfileUserControl(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }


        private async void MyProfileUserControl_Load(object sender, EventArgs e)
        {
            var user = await GlobalConfig.ConnectionType.GetUser(_loggedInUser);

            firstNameValue.Text = user.FirstName;
            lastNameValue.Text = user.LastName;
            emailValue.Text = user.Email;
        }
        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (TextBoxesAreValid() && EmailIsValid())
            {
                DialogResult editDialog = MessageBox.Show("ნამდვილად გსურთ მონაცემების შეცვლა?", "მონცაემების შეცვლა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editDialog == DialogResult.Yes)
                {
                    User userToEdit = new()
                    {
                        FirstName = firstNameValue.Text,
                        LastName = lastNameValue.Text,
                        Email = emailValue.Text,
                        UserId = _loggedInUser.UserId
                    };

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    await GlobalConfig.ConnectionType.EditUser(userToEdit);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    DashboardForm dashboardForm = new(userToEdit);

                    MessageBox.Show("ინფორმაცია მომხამრებლის შესახებ წარმატებით შეიცვალა", "ინფორმაციის შეცვლა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შემოყვანილი ინფორმაცია არ არის კორექტული", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TextBoxesAreValid()
        {
            return !string.IsNullOrWhiteSpace(firstNameValue.Text) && !string.IsNullOrWhiteSpace(lastNameValue.Text) && !string.IsNullOrWhiteSpace(emailValue.Text);
        }

        private bool EmailIsValid()
        {
            return emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
        }


    }
}

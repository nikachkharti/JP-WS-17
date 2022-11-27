using Todo.Services;
using TodoApp.Library;

namespace TodoApp.UI
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            User userToAdd = new()
                {
                    FirstName = firstNameValue.Text,
                    LastName = lastNameValue.Text,
                    Email = emailValue.Text
                };

            if (EmailIsValid())
            {
                if (await UserIsUnique(userToAdd))
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    await GlobalConfig.ConnectionType.RegisterUser(userToAdd);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    MessageBox.Show("გილოცავთ, თქვენ გაირეთ რეგისტრაცია წარმატებით", "მომხმარებელი დარეგისტრირდა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შეყვანილი მომხმარებელი უკვე არსებობს", "დუბლირებული მომხმარებელი", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შეყვანილი მონაცემები არასწორია, სცადეთ ხელახლა", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> UserIsUnique(User userToCheck)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.

            //return !GlobalConfig.ConnectionType.GetAllUsers().Any(x => x.Email.Equals(userToCheck.Email, StringComparison.OrdinalIgnoreCase));

            var allUsers = await GlobalConfig.ConnectionType.GetAllUsers();
            return !allUsers.Any(x => x.Email.Equals(userToCheck.Email, StringComparison.OrdinalIgnoreCase));

#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        private void ClearForm()
        {
            firstNameValue.Text = string.Empty;
            lastNameValue.Text = string.Empty;
            emailValue.Text = string.Empty;
        }
        private bool EmailIsValid()
        {
            return emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
        }
    }
}

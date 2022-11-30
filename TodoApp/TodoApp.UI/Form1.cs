using Todo.Services;
using TodoApp.Library;

namespace TodoApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static User? LoggedInUser { get; set; }

        private void newUserLink_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new();
            registerUserForm.ShowDialog();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmailIsValid())
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                LoggedInUser = await GlobalConfig.ConnectionType.LoginUser(emailValue.Text);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                if (await UserExists(LoggedInUser))
                {
                    DashboardForm dashboardForm = new(LoggedInUser);
                    dashboardForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შეყვანილი მომხმარებელი არ არსებობს", "არასწორი მომხმარებელი", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შეყვანილი ელ-ფოსტა არასწორია", "არასწორი მომხმარებელი", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task<bool> UserExists(User userToCheck)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var allUsers = await GlobalConfig.ConnectionType.GetAllUsers();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (allUsers.Any(x => x.Email.Equals(userToCheck.Email,StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }
            return false;
        }

        private void ClearForm() => emailValue.Text = string.Empty;
        private bool EmailIsValid() => emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
    }
}
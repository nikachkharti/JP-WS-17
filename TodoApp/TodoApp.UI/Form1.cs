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
        public User LoggedInUser { get; set; }

        private void newUserLink_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new();
            registerUserForm.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmailIsValid())
            {
                LoggedInUser = GlobalConfig.ConnectionType.LoginUser(emailValue.Text.Trim());

                if (UserExists(LoggedInUser))
                {
                    DashboardForm dashboardForm = new();
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


        private bool UserExists(User userToCheck)
        {
            var allUsers = GlobalConfig.ConnectionType.GetAllUsers();

            if (allUsers.Any(x => x.Email.Equals(userToCheck.Email)))
            {
                return true;
            }
            return false;
        }

        private void ClearForm() => emailValue.Text = string.Empty;
        private bool EmailIsValid() => emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
    }
}
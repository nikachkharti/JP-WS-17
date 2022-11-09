namespace TodoApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void newUserLink_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new();
            registerUserForm.ShowDialog();
        }
    }
}
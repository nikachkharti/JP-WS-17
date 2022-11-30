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
    public partial class DashboardForm : Form
    {
        private User _loggedInUser = new();
        public DashboardForm(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            TodoUserControlPanel.Controls.Add(new TodosUserControl(_loggedInUser));
        }
        private async void DashboardForm_Activated(object sender, EventArgs e)
        {
            User? editedUser = await GlobalConfig.ConnectionType.GetUser(_loggedInUser);
            welcomeLabel.Text = $"გამარჯობა {editedUser.FirstName}";
        }

        private void myProfileLabel_Click(object sender, EventArgs e)
        {
            TodoUserControlPanel.Controls.Clear();
#pragma warning disable CS8604 // Possible null reference argument.
            TodoUserControlPanel.Controls.Add(new MyProfileUserControl(_loggedInUser));
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {
            TodoUserControlPanel.Controls.Clear();
#pragma warning disable CS8604 // Possible null reference argument.
            TodoUserControlPanel.Controls.Add(new TodosUserControl(_loggedInUser));
#pragma warning restore CS8604 // Possible null reference argument.
        }

    }
}

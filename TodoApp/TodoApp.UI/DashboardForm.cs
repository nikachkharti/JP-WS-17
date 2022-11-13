using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.Library;

namespace TodoApp.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        public User LoggedInUser { get; set; }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoggedInUser = LoginForm.LoggedInUser;
            welcomeLabel.Text += LoggedInUser.FirstName;
        }
    }
}

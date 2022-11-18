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
        public User? LoggedInUser { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoggedInUser = LoginForm.LoggedInUser;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            welcomeLabel.Text += LoggedInUser.FirstName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}

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
        public static User? LoggedInUser { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.


            LoggedInUser = LoginForm.LoggedInUser;
            welcomeLabel.Text += LoggedInUser.FirstName;

            TodoUserControlPanel.Controls.Add(new TodosUserControl(LoggedInUser));


#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}

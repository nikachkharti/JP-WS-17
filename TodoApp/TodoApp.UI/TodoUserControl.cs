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
    public partial class TodoUserControl : UserControl
    {
        public TodoUserControl()
        {
            InitializeComponent();
        }

        public User LoggedInUser { get; set; }

        private void TodoUserControl_Load(object sender, EventArgs e)
        {
            LoggedInUser = LoginForm.LoggedInUser;
        }
    }
}

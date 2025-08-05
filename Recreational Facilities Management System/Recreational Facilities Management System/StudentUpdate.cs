using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreational_Facilities_Management_System
{
    public partial class StudentUpdate : Form
    {
        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            
        }
    }
}

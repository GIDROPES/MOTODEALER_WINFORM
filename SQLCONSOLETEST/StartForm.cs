using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCONSOLETEST
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminMode adminMode = new AdminMode();
            adminMode.Show();
            this.Hide();
            
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientMode client = new ClientMode();
            client.Show();
            this.Hide();
        }
    }
}

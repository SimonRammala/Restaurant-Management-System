using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace True_Food_Kitchen
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (rdb_yes.Checked == true)
            { 
                Loading_page next_page = new Loading_page();
                next_page.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}

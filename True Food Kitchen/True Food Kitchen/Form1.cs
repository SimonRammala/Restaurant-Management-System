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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (rdbYES.Checked == true)
            {
                //used to hide the current window and open the next windows
                this.Hide();
                Loading_page open_loading_page = new Loading_page();
                open_loading_page.Show();
            }
            else {
                //used to check if the user is certain about the choice
                DialogResult result = MessageBox.Show("Are you sure you want to close the application", "Cancel", MessageBoxButtons.YesNo ,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //used to close the appliction 
                    this.Close();
                }
                else 
                {
                    //used to allow the user to remain on the current window
                    this.Show();
                }

            }
        }
    }
}

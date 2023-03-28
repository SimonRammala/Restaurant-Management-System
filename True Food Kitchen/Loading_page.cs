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
    public partial class Loading_page : Form
    {
        public Loading_page()
        {
            InitializeComponent();
        }

        private void Loading_page_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(progressBar1.Minimum < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lbl_percentage.Text = progressBar1.Value.ToString() + " %";
            }


            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
            }


        }
    }
}

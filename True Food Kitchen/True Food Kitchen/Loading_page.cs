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
            //used to start the timer
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //used to increment to the value of the progressbar
            if (progressBar1.Minimum < progressBar1.Maximum -1)
            {
                progressBar1.Value = progressBar1.Value + 1;

            }

            //used to set the timer to false so the programe dose not crash the ram of computer
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
            }
            

        }
    }
}

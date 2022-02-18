using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Contact_Tracing_App_for_QR_Code
{
    public partial class Loading : Form
    {
        int ticks = 0;
        public Loading()
        {
            InitializeComponent();

        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            if (Viewbtn.Text == "View")
            {
                Viewbtn.Text = "Scanner";
                Process.Start("notepad.exe", "Data.txt");
                
            }
            else if(Viewbtn.Text == "Scanner") {
                Viewbtn.Text = "View";

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
          
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            ticks++;
                if (ticks == 5)
            {
                labelscan.Visible = true;
                Viewbtn.Visible = true;

            }
        }
    }
}

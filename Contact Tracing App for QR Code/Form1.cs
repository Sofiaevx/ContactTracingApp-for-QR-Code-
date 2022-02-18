using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; 
using AForge; 
using ZXing;
using ZXing.Aztec;
using System.Diagnostics;
using AForge.Video.DirectShow;
using AForge.Video;

namespace Contact_Tracing_App_for_QR_Code
{
    public partial class Form1 : Form
    {
        FilterInfoCollection Videocam;
        VideoCaptureDevice qrdisplay;
  
        public Form1()
        {
            InitializeComponent();
            
        }
        private void qrdisplay_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CameraDisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void ONOFFBtn_Click(object sender, EventArgs e)
        {
            if (ONOFFBtn.Text == "ON")
            {
                pictureBoxline.Visible = true;
                ONOFFBtn.Text = "OFF";
                qrdisplay = new VideoCaptureDevice(Videocam[0].MonikerString);
                qrdisplay.NewFrame += qrdisplay_NewFrame;
                qrdisplay.Start();
                synchronizer.Start();
                
            }
            else if (ONOFFBtn.Text == "OFF")
            {
               
                pictureBoxline.Visible = false;
                qrdisplay.Stop();
                synchronizer.Stop();
                ONOFFBtn.Text = "ON";
                CameraDisplay.Image = Image.FromFile("off.png");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Videocam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            pictureBoxline.BackColor = Color.Transparent;
            pictureBoxline.Parent = CameraDisplay;
        }

        private void synchronizer_Tick(object sender, EventArgs e)
        {
            ZXing.BarcodeReader barcode_Reader = new ZXing.BarcodeReader();
            ZXing.Result Qr_data = barcode_Reader.Decode((Bitmap)CameraDisplay.Image);

           if (Qr_data != null)
            {
                MessageBox.Show(Qr_data.ToString()); 
            }
        }
    }
}

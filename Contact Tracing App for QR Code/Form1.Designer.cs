
namespace Contact_Tracing_App_for_QR_Code
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CameraDisplay = new System.Windows.Forms.PictureBox();
            this.ONOFFBtn = new System.Windows.Forms.Button();
            this.synchronizer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxline = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CameraDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxline)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraDisplay
            // 
            this.CameraDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CameraDisplay.Image = ((System.Drawing.Image)(resources.GetObject("CameraDisplay.Image")));
            this.CameraDisplay.Location = new System.Drawing.Point(12, 12);
            this.CameraDisplay.Name = "CameraDisplay";
            this.CameraDisplay.Size = new System.Drawing.Size(250, 250);
            this.CameraDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CameraDisplay.TabIndex = 1;
            this.CameraDisplay.TabStop = false;
            // 
            // ONOFFBtn
            // 
            this.ONOFFBtn.Location = new System.Drawing.Point(191, 268);
            this.ONOFFBtn.Name = "ONOFFBtn";
            this.ONOFFBtn.Size = new System.Drawing.Size(71, 32);
            this.ONOFFBtn.TabIndex = 2;
            this.ONOFFBtn.Text = "ON";
            this.ONOFFBtn.UseVisualStyleBackColor = true;
            this.ONOFFBtn.Click += new System.EventHandler(this.ONOFFBtn_Click);
            // 
            // synchronizer
            // 
            this.synchronizer.Enabled = true;
            this.synchronizer.Interval = 1000;
            this.synchronizer.Tick += new System.EventHandler(this.synchronizer_Tick);
            // 
            // pictureBoxline
            // 
            this.pictureBoxline.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxline.Image")));
            this.pictureBoxline.Location = new System.Drawing.Point(-1, 10);
            this.pictureBoxline.Name = "pictureBoxline";
            this.pictureBoxline.Size = new System.Drawing.Size(273, 250);
            this.pictureBoxline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxline.TabIndex = 3;
            this.pictureBoxline.TabStop = false;
            this.pictureBoxline.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 305);
            this.Controls.Add(this.pictureBoxline);
            this.Controls.Add(this.ONOFFBtn);
            this.Controls.Add(this.CameraDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CameraDisplay;
        private System.Windows.Forms.Button ONOFFBtn;
        private System.Windows.Forms.Timer synchronizer;
        private System.Windows.Forms.PictureBox pictureBoxline;
    }
}



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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.synchronizer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CameraDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraDisplay
            // 
            this.CameraDisplay.Location = new System.Drawing.Point(12, 12);
            this.CameraDisplay.Name = "CameraDisplay";
            this.CameraDisplay.Size = new System.Drawing.Size(250, 250);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // synchronizer
            // 
            this.synchronizer.Enabled = true;
            this.synchronizer.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ONOFFBtn);
            this.Controls.Add(this.CameraDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App";
            ((System.ComponentModel.ISupportInitialize)(this.CameraDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CameraDisplay;
        private System.Windows.Forms.Button ONOFFBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer synchronizer;
    }
}


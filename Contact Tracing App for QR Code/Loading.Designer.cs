
namespace Contact_Tracing_App_for_QR_Code
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelscan = new System.Windows.Forms.Label();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelscan
            // 
            this.labelscan.AutoSize = true;
            this.labelscan.Font = new System.Drawing.Font("Microsoft Yi Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscan.Location = new System.Drawing.Point(15, 67);
            this.labelscan.Name = "labelscan";
            this.labelscan.Size = new System.Drawing.Size(234, 35);
            this.labelscan.TabIndex = 1;
            this.labelscan.Text = "Scan Completed";
            this.labelscan.Visible = false;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.Location = new System.Drawing.Point(172, 118);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(73, 34);
            this.Viewbtn.TabIndex = 2;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Visible = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 164);
            this.ControlBox = false;
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.labelscan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelscan;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Timer timer1;
    }
}
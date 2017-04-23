namespace CpuSimülasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblMBR = new System.Windows.Forms.Label();
            this.lblMAR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1347, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIR
            // 
            this.lblIR.BackColor = System.Drawing.Color.Yellow;
            this.lblIR.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIR.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIR.Location = new System.Drawing.Point(616, 448);
            this.lblIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(115, 26);
            this.lblIR.TabIndex = 1;
            this.lblIR.Text = "00000000";
            this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPC
            // 
            this.lblPC.BackColor = System.Drawing.Color.Yellow;
            this.lblPC.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPC.Location = new System.Drawing.Point(731, 235);
            this.lblPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(115, 26);
            this.lblPC.TabIndex = 2;
            this.lblPC.Text = "00000000";
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMBR
            // 
            this.lblMBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.lblMBR.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMBR.ForeColor = System.Drawing.Color.White;
            this.lblMBR.Location = new System.Drawing.Point(896, 384);
            this.lblMBR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMBR.Name = "lblMBR";
            this.lblMBR.Size = new System.Drawing.Size(116, 26);
            this.lblMBR.TabIndex = 3;
            this.lblMBR.Text = "00000000";
            this.lblMBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMAR
            // 
            this.lblMAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.lblMAR.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMAR.ForeColor = System.Drawing.Color.White;
            this.lblMAR.Location = new System.Drawing.Point(896, 122);
            this.lblMAR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(116, 26);
            this.lblMAR.TabIndex = 4;
            this.lblMAR.Text = "00000000";
            this.lblMAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 695);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMAR);
            this.Controls.Add(this.lblMBR);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1365, 766);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1363, 724);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblMBR;
        private System.Windows.Forms.Label lblMAR;
        private System.Windows.Forms.Panel panel1;
    }
}


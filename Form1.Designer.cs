namespace Final_Pro
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.MassB = new System.Windows.Forms.Button();
            this.MAINEB = new System.Windows.Forms.Button();
            this.VTB = new System.Windows.Forms.Button();
            this.NHB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(505, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose your state...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MassB
            // 
            this.MassB.AllowDrop = true;
            this.MassB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.MassB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassB.ForeColor = System.Drawing.SystemColors.Window;
            this.MassB.Location = new System.Drawing.Point(288, 657);
            this.MassB.Name = "MassB";
            this.MassB.Size = new System.Drawing.Size(185, 47);
            this.MassB.TabIndex = 3;
            this.MassB.Text = "Massachussets";
            this.MassB.UseVisualStyleBackColor = false;
            this.MassB.Visible = false;
            this.MassB.Click += new System.EventHandler(this.MassB_Click);
            // 
            // MAINEB
            // 
            this.MAINEB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.MAINEB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAINEB.ForeColor = System.Drawing.SystemColors.Window;
            this.MAINEB.Location = new System.Drawing.Point(919, 657);
            this.MAINEB.Name = "MAINEB";
            this.MAINEB.Size = new System.Drawing.Size(166, 47);
            this.MAINEB.TabIndex = 4;
            this.MAINEB.Text = " Maine";
            this.MAINEB.UseVisualStyleBackColor = false;
            this.MAINEB.Visible = false;
            this.MAINEB.Click += new System.EventHandler(this.MAINEB_Click);
            // 
            // VTB
            // 
            this.VTB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VTB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTB.ForeColor = System.Drawing.SystemColors.Window;
            this.VTB.Location = new System.Drawing.Point(718, 657);
            this.VTB.Name = "VTB";
            this.VTB.Size = new System.Drawing.Size(166, 47);
            this.VTB.TabIndex = 5;
            this.VTB.Text = "Vermont";
            this.VTB.UseVisualStyleBackColor = false;
            this.VTB.Visible = false;
            this.VTB.Click += new System.EventHandler(this.VTB_Click);
            // 
            // NHB
            // 
            this.NHB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.NHB.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHB.ForeColor = System.Drawing.SystemColors.Window;
            this.NHB.Location = new System.Drawing.Point(505, 658);
            this.NHB.Name = "NHB";
            this.NHB.Size = new System.Drawing.Size(181, 47);
            this.NHB.TabIndex = 6;
            this.NHB.Text = "New Hampshire";
            this.NHB.UseVisualStyleBackColor = false;
            this.NHB.Visible = false;
            this.NHB.Click += new System.EventHandler(this.NHB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox1.Image = global::Final_Pro.Properties.Resources._5491638;
            this.pictureBox1.Location = new System.Drawing.Point(827, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Pro.Properties.Resources.RandoEats2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NHB);
            this.Controls.Add(this.VTB);
            this.Controls.Add(this.MAINEB);
            this.Controls.Add(this.MassB);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "RandoEats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MassB;
        private System.Windows.Forms.Button MAINEB;
        private System.Windows.Forms.Button VTB;
        private System.Windows.Forms.Button NHB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


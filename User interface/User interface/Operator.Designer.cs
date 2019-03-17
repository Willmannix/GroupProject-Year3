namespace User_interface
{
    partial class Operator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operator));
            this.btnRequestS = new System.Windows.Forms.Button();
            this.btnCheckWO = new System.Windows.Forms.Button();
            this.btnRequestQC = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequestS
            // 
            this.btnRequestS.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRequestS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestS.Location = new System.Drawing.Point(34, 38);
            this.btnRequestS.Name = "btnRequestS";
            this.btnRequestS.Size = new System.Drawing.Size(697, 166);
            this.btnRequestS.TabIndex = 0;
            this.btnRequestS.Text = "Request Stock                                                      ";
            this.btnRequestS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequestS.UseVisualStyleBackColor = false;
            this.btnRequestS.Click += new System.EventHandler(this.btnRequestS_Click);
            // 
            // btnCheckWO
            // 
            this.btnCheckWO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCheckWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckWO.Location = new System.Drawing.Point(34, 249);
            this.btnCheckWO.Name = "btnCheckWO";
            this.btnCheckWO.Size = new System.Drawing.Size(697, 166);
            this.btnCheckWO.TabIndex = 1;
            this.btnCheckWO.Text = "View Word Order                                                  ";
            this.btnCheckWO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckWO.UseVisualStyleBackColor = false;
            this.btnCheckWO.Click += new System.EventHandler(this.btnCheckWO_Click);
            // 
            // btnRequestQC
            // 
            this.btnRequestQC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRequestQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestQC.Location = new System.Drawing.Point(34, 468);
            this.btnRequestQC.Name = "btnRequestQC";
            this.btnRequestQC.Size = new System.Drawing.Size(697, 166);
            this.btnRequestQC.TabIndex = 2;
            this.btnRequestQC.Text = "Request QC Check                                                 ";
            this.btnRequestQC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequestQC.UseVisualStyleBackColor = false;
            this.btnRequestQC.Click += new System.EventHandler(this.btnRequestQC_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Location = new System.Drawing.Point(17, 624);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(291, 112);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(10, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 112);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mark Stock as Broken";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Welcome);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 56);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are Logged in as Operator";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(617, 7);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(170, 39);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(940, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 748);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(106, 507);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Controls.Add(this.pictureBox3);
            this.Main.Controls.Add(this.pictureBox2);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.btnRequestQC);
            this.Main.Controls.Add(this.btnCheckWO);
            this.Main.Controls.Add(this.btnRequestS);
            this.Main.Location = new System.Drawing.Point(119, 109);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(750, 650);
            this.Main.TabIndex = 26;
            this.Main.TabStop = false;
            this.Main.Text = "Main";
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1253, 803);
            this.ControlBox = false;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operator";
            this.Text = "Operator";
            this.Load += new System.EventHandler(this.Operator_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequestS;
        private System.Windows.Forms.Button btnCheckWO;
        private System.Windows.Forms.Button btnRequestQC;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox Main;
    }
}
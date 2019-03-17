namespace User_interface
{
    partial class RequestQcCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestQcCheck));
            this.listBoxWorkOrders = new System.Windows.Forms.ListBox();
            this.buttonRequestQcCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxWorkOrders
            // 
            this.listBoxWorkOrders.FormattingEnabled = true;
            this.listBoxWorkOrders.Location = new System.Drawing.Point(46, 62);
            this.listBoxWorkOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxWorkOrders.Name = "listBoxWorkOrders";
            this.listBoxWorkOrders.Size = new System.Drawing.Size(91, 225);
            this.listBoxWorkOrders.TabIndex = 0;
            this.listBoxWorkOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkOrders_SelectedIndexChanged);
            // 
            // buttonRequestQcCheck
            // 
            this.buttonRequestQcCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRequestQcCheck.Location = new System.Drawing.Point(196, 123);
            this.buttonRequestQcCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRequestQcCheck.Name = "buttonRequestQcCheck";
            this.buttonRequestQcCheck.Size = new System.Drawing.Size(168, 66);
            this.buttonRequestQcCheck.TabIndex = 1;
            this.buttonRequestQcCheck.Text = "Request QC Check";
            this.buttonRequestQcCheck.UseVisualStyleBackColor = false;
            this.buttonRequestQcCheck.Click += new System.EventHandler(this.buttonRequestQcCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(304, 66);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RequestQcCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.buttonRequestQcCheck);
            this.Controls.Add(this.listBoxWorkOrders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RequestQcCheck";
            this.Text = "RequestQcCheck";
            this.Load += new System.EventHandler(this.RequestQcCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkOrders;
        private System.Windows.Forms.Button buttonRequestQcCheck;
        private System.Windows.Forms.Button btnExit;
    }
}
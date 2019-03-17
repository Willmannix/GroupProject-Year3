namespace User_interface
{
    partial class ApproveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveStock));
            this.StockRequestList = new System.Windows.Forms.ListBox();
            this.StockApproveList = new System.Windows.Forms.ListBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApproveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockRequestList
            // 
            this.StockRequestList.FormattingEnabled = true;
            this.StockRequestList.Location = new System.Drawing.Point(13, 13);
            this.StockRequestList.Name = "StockRequestList";
            this.StockRequestList.Size = new System.Drawing.Size(229, 368);
            this.StockRequestList.TabIndex = 0;
            this.StockRequestList.SelectedIndexChanged += new System.EventHandler(this.StockRequestList_SelectedIndexChanged);
            // 
            // StockApproveList
            // 
            this.StockApproveList.FormattingEnabled = true;
            this.StockApproveList.Location = new System.Drawing.Point(293, 12);
            this.StockApproveList.Name = "StockApproveList";
            this.StockApproveList.Size = new System.Drawing.Size(229, 368);
            this.StockApproveList.TabIndex = 1;
            this.StockApproveList.SelectedIndexChanged += new System.EventHandler(this.StockApproveList_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(645, 94);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(590, 97);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(49, 13);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnApproveAll
            // 
            this.btnApproveAll.Location = new System.Drawing.Point(645, 138);
            this.btnApproveAll.Name = "btnApproveAll";
            this.btnApproveAll.Size = new System.Drawing.Size(111, 38);
            this.btnApproveAll.TabIndex = 5;
            this.btnApproveAll.Text = "Approve All";
            this.btnApproveAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = ">>";
            // 
            // ApproveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApproveAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.StockApproveList);
            this.Controls.Add(this.StockRequestList);
            this.Name = "ApproveStock";
            this.Text = "ApproveStock";
            this.Load += new System.EventHandler(this.ApproveStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StockRequestList;
        private System.Windows.Forms.ListBox StockApproveList;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApproveAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}
namespace User_interface
{
    partial class AdvanceWOstage
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
            this.listBoxWorkOrders = new System.Windows.Forms.ListBox();
            this.textBoxStage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdvance = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxWorkOrders
            // 
            this.listBoxWorkOrders.FormattingEnabled = true;
            this.listBoxWorkOrders.ItemHeight = 16;
            this.listBoxWorkOrders.Location = new System.Drawing.Point(38, 57);
            this.listBoxWorkOrders.Name = "listBoxWorkOrders";
            this.listBoxWorkOrders.Size = new System.Drawing.Size(120, 164);
            this.listBoxWorkOrders.TabIndex = 0;
            this.listBoxWorkOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkOrders_SelectedIndexChanged);
            // 
            // textBoxStage
            // 
            this.textBoxStage.Location = new System.Drawing.Point(251, 77);
            this.textBoxStage.Name = "textBoxStage";
            this.textBoxStage.ReadOnly = true;
            this.textBoxStage.Size = new System.Drawing.Size(100, 22);
            this.textBoxStage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Stage";
            // 
            // buttonAdvance
            // 
            this.buttonAdvance.Location = new System.Drawing.Point(492, 57);
            this.buttonAdvance.Name = "buttonAdvance";
            this.buttonAdvance.Size = new System.Drawing.Size(160, 51);
            this.buttonAdvance.TabIndex = 3;
            this.buttonAdvance.Text = "Advance Stage";
            this.buttonAdvance.UseVisualStyleBackColor = true;
            this.buttonAdvance.Click += new System.EventHandler(this.buttonAdvance_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(492, 130);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(160, 51);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "CompleteWorkOrder";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(528, 383);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(260, 55);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdvanceWOstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonAdvance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStage);
            this.Controls.Add(this.listBoxWorkOrders);
            this.Name = "AdvanceWOstage";
            this.Text = "AdvanceWOstage";
            this.Load += new System.EventHandler(this.AdvanceWOstage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkOrders;
        private System.Windows.Forms.TextBox textBoxStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdvance;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonBack;
    }
}
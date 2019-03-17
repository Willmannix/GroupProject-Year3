namespace User_interface
{
    partial class AssignWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignWorkOrder));
            this.lstViewAssignWorkOrder = new System.Windows.Forms.ListView();
            this.txtAssignedOperator = new System.Windows.Forms.TextBox();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstViewAssignWorkOrder
            // 
            this.lstViewAssignWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewAssignWorkOrder.Location = new System.Drawing.Point(12, 74);
            this.lstViewAssignWorkOrder.Name = "lstViewAssignWorkOrder";
            this.lstViewAssignWorkOrder.Size = new System.Drawing.Size(240, 351);
            this.lstViewAssignWorkOrder.TabIndex = 1;
            this.lstViewAssignWorkOrder.UseCompatibleStateImageBehavior = false;
            this.lstViewAssignWorkOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstViewAssignWorkOrder_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(273, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 351);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // txtAssignedOperator
            // 
            this.txtAssignedOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignedOperator.Location = new System.Drawing.Point(561, 106);
            this.txtAssignedOperator.Name = "txtAssignedOperator";
            this.txtAssignedOperator.ReadOnly = true;
            this.txtAssignedOperator.Size = new System.Drawing.Size(223, 35);
            this.txtAssignedOperator.TabIndex = 3;
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrderNo.Location = new System.Drawing.Point(562, 195);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(222, 35);
            this.txtWorkOrderNo.TabIndex = 4;
            this.txtWorkOrderNo.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assigned Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Work Order No.";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.White;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(562, 256);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(222, 45);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(561, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AssignWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWorkOrderNo);
            this.Controls.Add(this.txtAssignedOperator);
            this.Controls.Add(this.lstViewAssignWorkOrder);
            this.Name = "AssignWorkOrder";
            this.ShowIcon = false;
            this.Text = "Assign Work Order";
            this.Load += new System.EventHandler(this.AssignWorkOrder_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewAssignWorkOrder;
        private System.Windows.Forms.TextBox txtAssignedOperator;
        private System.Windows.Forms.TextBox txtWorkOrderNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listView1;
    }
}
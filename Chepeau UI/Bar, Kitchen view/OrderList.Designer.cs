namespace Chepeau_UI
{
    partial class OrderList
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
            this.btn_off = new System.Windows.Forms.Button();
            this.lbl_timenow = new System.Windows.Forms.Label();
            this.btn_completedorders = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_off
            // 
            this.btn_off.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_off.Location = new System.Drawing.Point(371, 9);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(99, 54);
            this.btn_off.TabIndex = 46;
            this.btn_off.Text = "Log Out";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // lbl_timenow
            // 
            this.lbl_timenow.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timenow.Location = new System.Drawing.Point(105, 17);
            this.lbl_timenow.Name = "lbl_timenow";
            this.lbl_timenow.Size = new System.Drawing.Size(260, 56);
            this.lbl_timenow.TabIndex = 47;
            this.lbl_timenow.Text = "Time";
            this.lbl_timenow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_completedorders
            // 
            this.btn_completedorders.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_completedorders.Location = new System.Drawing.Point(12, 9);
            this.btn_completedorders.Name = "btn_completedorders";
            this.btn_completedorders.Size = new System.Drawing.Size(99, 54);
            this.btn_completedorders.TabIndex = 48;
            this.btn_completedorders.Text = "Completed Orders";
            this.btn_completedorders.UseVisualStyleBackColor = true;
            this.btn_completedorders.Click += new System.EventHandler(this.btn_completedorders_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(12, 76);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(458, 565);
            this.listViewOrders.TabIndex = 49;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.Click += new System.EventHandler(this.listViewOrders_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.btn_completedorders);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.lbl_timenow);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Label lbl_timenow;
        private System.Windows.Forms.Button btn_completedorders;
        private System.Windows.Forms.ListView listViewOrders;
    }
}
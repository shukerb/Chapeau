namespace Chepeau_UI
{
    partial class ManagerUI
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_tableOverview = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_StockOverview = new System.Windows.Forms.Button();
            this.btn_menuOverview = new System.Windows.Forms.Button();
            this.btn_UsersOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(229, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(109, 32);
            this.btn_logout.TabIndex = 12;
            this.btn_logout.Text = "LogOut";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_tableOverview
            // 
            this.btn_tableOverview.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tableOverview.Location = new System.Drawing.Point(64, 119);
            this.btn_tableOverview.Name = "btn_tableOverview";
            this.btn_tableOverview.Size = new System.Drawing.Size(224, 51);
            this.btn_tableOverview.TabIndex = 13;
            this.btn_tableOverview.Text = "Tables Overview";
            this.btn_tableOverview.UseVisualStyleBackColor = true;
            this.btn_tableOverview.Click += new System.EventHandler(this.btn_tableOverview_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(34, 27);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(0, 14);
            this.lbl_UserName.TabIndex = 14;
            // 
            // btn_StockOverview
            // 
            this.btn_StockOverview.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockOverview.Location = new System.Drawing.Point(64, 177);
            this.btn_StockOverview.Name = "btn_StockOverview";
            this.btn_StockOverview.Size = new System.Drawing.Size(224, 51);
            this.btn_StockOverview.TabIndex = 15;
            this.btn_StockOverview.Text = "Edit Stock";
            this.btn_StockOverview.UseVisualStyleBackColor = true;
            this.btn_StockOverview.Click += new System.EventHandler(this.btn_StockOverview_Click);
            // 
            // btn_menuOverview
            // 
            this.btn_menuOverview.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuOverview.Location = new System.Drawing.Point(64, 235);
            this.btn_menuOverview.Name = "btn_menuOverview";
            this.btn_menuOverview.Size = new System.Drawing.Size(224, 51);
            this.btn_menuOverview.TabIndex = 16;
            this.btn_menuOverview.Text = "Edit Menu";
            this.btn_menuOverview.UseVisualStyleBackColor = true;
            this.btn_menuOverview.Click += new System.EventHandler(this.btn_menuOverview_Click);
            // 
            // btn_UsersOverview
            // 
            this.btn_UsersOverview.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UsersOverview.Location = new System.Drawing.Point(64, 292);
            this.btn_UsersOverview.Name = "btn_UsersOverview";
            this.btn_UsersOverview.Size = new System.Drawing.Size(224, 51);
            this.btn_UsersOverview.TabIndex = 17;
            this.btn_UsersOverview.Text = "Edit Users";
            this.btn_UsersOverview.UseVisualStyleBackColor = true;
            this.btn_UsersOverview.Click += new System.EventHandler(this.btn_UsersOverview_Click);
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 408);
            this.Controls.Add(this.btn_UsersOverview);
            this.Controls.Add(this.btn_menuOverview);
            this.Controls.Add(this.btn_StockOverview);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_tableOverview);
            this.Controls.Add(this.btn_logout);
            this.Name = "ManagerUI";
            this.Text = "ManagerUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_tableOverview;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_StockOverview;
        private System.Windows.Forms.Button btn_menuOverview;
        private System.Windows.Forms.Button btn_UsersOverview;
    }
}
﻿namespace Chepeau_UI
{
    partial class Order_Table
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
            this.lbl_timenow = new System.Windows.Forms.Label();
            this.lbl_timetbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_prepare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_timenow
            // 
            this.lbl_timenow.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timenow.Location = new System.Drawing.Point(152, 12);
            this.lbl_timenow.Name = "lbl_timenow";
            this.lbl_timenow.Size = new System.Drawing.Size(196, 56);
            this.lbl_timenow.TabIndex = 33;
            this.lbl_timenow.Text = "Time";
            this.lbl_timenow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_timetbl
            // 
            this.lbl_timetbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timetbl.Location = new System.Drawing.Point(333, 96);
            this.lbl_timetbl.Name = "lbl_timetbl";
            this.lbl_timetbl.Size = new System.Drawing.Size(143, 35);
            this.lbl_timetbl.TabIndex = 32;
            this.lbl_timetbl.Text = "Unknown";
            this.lbl_timetbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "Order Content";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(13, 134);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(458, 440);
            this.listViewOrder.TabIndex = 30;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(385, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 53);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.Location = new System.Drawing.Point(12, 580);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(457, 61);
            this.btn_complete.TabIndex = 34;
            this.btn_complete.Text = "Finish Order";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // btn_prepare
            // 
            this.btn_prepare.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prepare.Location = new System.Drawing.Point(14, 580);
            this.btn_prepare.Name = "btn_prepare";
            this.btn_prepare.Size = new System.Drawing.Size(457, 61);
            this.btn_prepare.TabIndex = 35;
            this.btn_prepare.Text = "Start Preparing";
            this.btn_prepare.UseVisualStyleBackColor = true;
            this.btn_prepare.Click += new System.EventHandler(this.btn_prepare_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Created At:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Order_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.btn_prepare);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.lbl_timenow);
            this.Controls.Add(this.lbl_timetbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "Order_Table";
            this.Text = "OrderTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_timenow;
        private System.Windows.Forms.Label lbl_timetbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_prepare;
        private System.Windows.Forms.Label label1;
    }
}
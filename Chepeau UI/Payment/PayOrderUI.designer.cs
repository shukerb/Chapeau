﻿namespace Chepeau_UI
{
    partial class PayOrderUI
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
            this.btn_Pay = new System.Windows.Forms.Button();
            this.listViewPay = new System.Windows.Forms.ListView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_TotalPriceTxt = new System.Windows.Forms.Label();
            this.lbl_TipTxt = new System.Windows.Forms.Label();
            this.txtBx_Tip = new System.Windows.Forms.TextBox();
            this.lbl_OrderListTxt = new System.Windows.Forms.Label();
            this.lbl1_EuroSignTxt = new System.Windows.Forms.Label();
            this.lbl_VATtxt = new System.Windows.Forms.Label();
            this.btn_addTip = new System.Windows.Forms.Button();
            this.btn_ClearTip = new System.Windows.Forms.Button();
            this.lbl3_EuroSignTxt = new System.Windows.Forms.Label();
            this.lbl2_EuroSignTxt = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.Location = new System.Drawing.Point(65, 676);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(364, 78);
            this.btn_Pay.TabIndex = 0;
            this.btn_Pay.Text = "Pay ";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // listViewPay
            // 
            this.listViewPay.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPay.GridLines = true;
            this.listViewPay.Location = new System.Drawing.Point(65, 84);
            this.listViewPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewPay.MultiSelect = false;
            this.listViewPay.Name = "listViewPay";
            this.listViewPay.Size = new System.Drawing.Size(363, 339);
            this.listViewPay.TabIndex = 2;
            this.listViewPay.UseCompatibleStateImageBehavior = false;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(304, 15);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 47);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_TotalPriceTxt
            // 
            this.lbl_TotalPriceTxt.AutoSize = true;
            this.lbl_TotalPriceTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPriceTxt.Location = new System.Drawing.Point(67, 613);
            this.lbl_TotalPriceTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalPriceTxt.Name = "lbl_TotalPriceTxt";
            this.lbl_TotalPriceTxt.Size = new System.Drawing.Size(61, 26);
            this.lbl_TotalPriceTxt.TabIndex = 5;
            this.lbl_TotalPriceTxt.Text = "Total";
            // 
            // lbl_TipTxt
            // 
            this.lbl_TipTxt.AutoSize = true;
            this.lbl_TipTxt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipTxt.Location = new System.Drawing.Point(67, 441);
            this.lbl_TipTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TipTxt.Name = "lbl_TipTxt";
            this.lbl_TipTxt.Size = new System.Drawing.Size(42, 27);
            this.lbl_TipTxt.TabIndex = 7;
            this.lbl_TipTxt.Text = "Tip";
            // 
            // txtBx_Tip
            // 
            this.txtBx_Tip.Location = new System.Drawing.Point(153, 442);
            this.txtBx_Tip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBx_Tip.Name = "txtBx_Tip";
            this.txtBx_Tip.Size = new System.Drawing.Size(169, 22);
            this.txtBx_Tip.TabIndex = 8;
            // 
            // lbl_OrderListTxt
            // 
            this.lbl_OrderListTxt.AutoSize = true;
            this.lbl_OrderListTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderListTxt.Location = new System.Drawing.Point(64, 38);
            this.lbl_OrderListTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderListTxt.Name = "lbl_OrderListTxt";
            this.lbl_OrderListTxt.Size = new System.Drawing.Size(177, 44);
            this.lbl_OrderListTxt.TabIndex = 9;
            this.lbl_OrderListTxt.Text = "Order List";
            // 
            // lbl1_EuroSignTxt
            // 
            this.lbl1_EuroSignTxt.AutoSize = true;
            this.lbl1_EuroSignTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_EuroSignTxt.Location = new System.Drawing.Point(332, 441);
            this.lbl1_EuroSignTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1_EuroSignTxt.Name = "lbl1_EuroSignTxt";
            this.lbl1_EuroSignTxt.Size = new System.Drawing.Size(24, 26);
            this.lbl1_EuroSignTxt.TabIndex = 10;
            this.lbl1_EuroSignTxt.Text = "€";
            // 
            // lbl_VATtxt
            // 
            this.lbl_VATtxt.AutoSize = true;
            this.lbl_VATtxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VATtxt.Location = new System.Drawing.Point(67, 567);
            this.lbl_VATtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VATtxt.Name = "lbl_VATtxt";
            this.lbl_VATtxt.Size = new System.Drawing.Size(51, 26);
            this.lbl_VATtxt.TabIndex = 12;
            this.lbl_VATtxt.Text = "VAT";
            // 
            // btn_addTip
            // 
            this.btn_addTip.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTip.Location = new System.Drawing.Point(65, 485);
            this.btn_addTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addTip.Name = "btn_addTip";
            this.btn_addTip.Size = new System.Drawing.Size(179, 54);
            this.btn_addTip.TabIndex = 15;
            this.btn_addTip.Text = "Add Tip";
            this.btn_addTip.UseVisualStyleBackColor = true;
            this.btn_addTip.Click += new System.EventHandler(this.btn_addTip_Click);
            // 
            // btn_ClearTip
            // 
            this.btn_ClearTip.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearTip.Location = new System.Drawing.Point(251, 485);
            this.btn_ClearTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ClearTip.Name = "btn_ClearTip";
            this.btn_ClearTip.Size = new System.Drawing.Size(179, 54);
            this.btn_ClearTip.TabIndex = 16;
            this.btn_ClearTip.Text = "Clear Tip";
            this.btn_ClearTip.UseVisualStyleBackColor = true;
            this.btn_ClearTip.Click += new System.EventHandler(this.btn_ClearTip_Click);
            // 
            // lbl3_EuroSignTxt
            // 
            this.lbl3_EuroSignTxt.AutoSize = true;
            this.lbl3_EuroSignTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3_EuroSignTxt.Location = new System.Drawing.Point(332, 613);
            this.lbl3_EuroSignTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3_EuroSignTxt.Name = "lbl3_EuroSignTxt";
            this.lbl3_EuroSignTxt.Size = new System.Drawing.Size(24, 26);
            this.lbl3_EuroSignTxt.TabIndex = 17;
            this.lbl3_EuroSignTxt.Text = "€";
            // 
            // lbl2_EuroSignTxt
            // 
            this.lbl2_EuroSignTxt.AutoSize = true;
            this.lbl2_EuroSignTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_EuroSignTxt.Location = new System.Drawing.Point(332, 567);
            this.lbl2_EuroSignTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2_EuroSignTxt.Name = "lbl2_EuroSignTxt";
            this.lbl2_EuroSignTxt.Size = new System.Drawing.Size(24, 26);
            this.lbl2_EuroSignTxt.TabIndex = 18;
            this.lbl2_EuroSignTxt.Text = "€";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VAT.Location = new System.Drawing.Point(192, 567);
            this.lbl_VAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(0, 26);
            this.lbl_VAT.TabIndex = 19;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(192, 613);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(0, 26);
            this.lbl_TotalPrice.TabIndex = 20;
            // 
            // PayOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 767);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.lbl_VAT);
            this.Controls.Add(this.lbl2_EuroSignTxt);
            this.Controls.Add(this.lbl3_EuroSignTxt);
            this.Controls.Add(this.btn_ClearTip);
            this.Controls.Add(this.btn_addTip);
            this.Controls.Add(this.lbl_VATtxt);
            this.Controls.Add(this.lbl1_EuroSignTxt);
            this.Controls.Add(this.lbl_OrderListTxt);
            this.Controls.Add(this.txtBx_Tip);
            this.Controls.Add(this.lbl_TipTxt);
            this.Controls.Add(this.lbl_TotalPriceTxt);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listViewPay);
            this.Controls.Add(this.btn_Pay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PayOrderUI";
            this.Text = "Pay Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_TotalPriceTxt;
        private System.Windows.Forms.Label lbl_TipTxt;
        public System.Windows.Forms.ListView listViewPay;
        public System.Windows.Forms.TextBox txtBx_Tip;
        private System.Windows.Forms.Label lbl_OrderListTxt;
        private System.Windows.Forms.Label lbl1_EuroSignTxt;
        private System.Windows.Forms.Label lbl_VATtxt;
        private System.Windows.Forms.Button btn_addTip;
        private System.Windows.Forms.Button btn_ClearTip;
        private System.Windows.Forms.Label lbl3_EuroSignTxt;
        private System.Windows.Forms.Label lbl2_EuroSignTxt;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_TotalPrice;
    }
}
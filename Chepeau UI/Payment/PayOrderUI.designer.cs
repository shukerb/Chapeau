namespace Chepeau_UI
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
            this.btn_payCard = new System.Windows.Forms.Button();
            this.btn_payCash = new System.Windows.Forms.Button();
            this.listViewPay = new System.Windows.Forms.ListView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_totalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_VAT = new System.Windows.Forms.TextBox();
            this.btn_addTip = new System.Windows.Forms.Button();
            this.btn_ClearTip = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_payCard
            // 
            this.btn_payCard.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payCard.Location = new System.Drawing.Point(49, 591);
            this.btn_payCard.Name = "btn_payCard";
            this.btn_payCard.Size = new System.Drawing.Size(273, 44);
            this.btn_payCard.TabIndex = 0;
            this.btn_payCard.Text = "Pay Card";
            this.btn_payCard.UseVisualStyleBackColor = true;
            this.btn_payCard.Click += new System.EventHandler(this.btn_PayWithCard_Click);
            // 
            // btn_payCash
            // 
            this.btn_payCash.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payCash.Location = new System.Drawing.Point(49, 541);
            this.btn_payCash.Name = "btn_payCash";
            this.btn_payCash.Size = new System.Drawing.Size(273, 44);
            this.btn_payCash.TabIndex = 1;
            this.btn_payCash.Text = "Pay Cash";
            this.btn_payCash.UseVisualStyleBackColor = true;
            this.btn_payCash.Click += new System.EventHandler(this.btn_payCash_Click);
            // 
            // listViewPay
            // 
            this.listViewPay.GridLines = true;
            this.listViewPay.Location = new System.Drawing.Point(49, 68);
            this.listViewPay.MultiSelect = false;
            this.listViewPay.Name = "listViewPay";
            this.listViewPay.Size = new System.Drawing.Size(273, 276);
            this.listViewPay.TabIndex = 2;
            this.listViewPay.UseCompatibleStateImageBehavior = false;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(258, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 24);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.Location = new System.Drawing.Point(115, 498);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(128, 20);
            this.lbl_totalPrice.TabIndex = 4;
            this.lbl_totalPrice.TextChanged += new System.EventHandler(this.lbl_totalPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tip";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.Location = new System.Drawing.Point(115, 359);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(128, 20);
            this.lbl_Tip.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "VAT";
            // 
            // txtBx_VAT
            // 
            this.txtBx_VAT.Location = new System.Drawing.Point(115, 462);
            this.txtBx_VAT.Name = "txtBx_VAT";
            this.txtBx_VAT.ReadOnly = true;
            this.txtBx_VAT.Size = new System.Drawing.Size(128, 20);
            this.txtBx_VAT.TabIndex = 13;
            // 
            // btn_addTip
            // 
            this.btn_addTip.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTip.Location = new System.Drawing.Point(49, 394);
            this.btn_addTip.Name = "btn_addTip";
            this.btn_addTip.Size = new System.Drawing.Size(134, 44);
            this.btn_addTip.TabIndex = 15;
            this.btn_addTip.Text = "Add Tip";
            this.btn_addTip.UseVisualStyleBackColor = true;
            this.btn_addTip.Click += new System.EventHandler(this.btn_addTip_Click);
            // 
            // btn_ClearTip
            // 
            this.btn_ClearTip.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearTip.Location = new System.Drawing.Point(188, 394);
            this.btn_ClearTip.Name = "btn_ClearTip";
            this.btn_ClearTip.Size = new System.Drawing.Size(134, 44);
            this.btn_ClearTip.TabIndex = 16;
            this.btn_ClearTip.Text = "Clear Tip";
            this.btn_ClearTip.UseVisualStyleBackColor = true;
            this.btn_ClearTip.Click += new System.EventHandler(this.btn_ClearTip_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "€";
            // 
            // PayOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 664);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ClearTip);
            this.Controls.Add(this.btn_addTip);
            this.Controls.Add(this.txtBx_VAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listViewPay);
            this.Controls.Add(this.btn_payCash);
            this.Controls.Add(this.btn_payCard);
            this.Name = "PayOrderUI";
            this.Text = "Pay Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_payCard;
        private System.Windows.Forms.Button btn_payCash;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewPay;
        public System.Windows.Forms.TextBox lbl_totalPrice;
        public System.Windows.Forms.TextBox lbl_Tip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBx_VAT;
        private System.Windows.Forms.Button btn_addTip;
        private System.Windows.Forms.Button btn_ClearTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
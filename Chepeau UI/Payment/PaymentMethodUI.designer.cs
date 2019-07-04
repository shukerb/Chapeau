namespace Chepeau_UI
{
    partial class PaymentMethodUI
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
            this.btn_PayVisa = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1_EuroSignTxt = new System.Windows.Forms.Label();
            this.btn_PayCash = new System.Windows.Forms.Button();
            this.btn_PayPin = new System.Windows.Forms.Button();
            this.btn_PayMaestro = new System.Windows.Forms.Button();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_PayVisa
            // 
            this.btn_PayVisa.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayVisa.Location = new System.Drawing.Point(58, 354);
            this.btn_PayVisa.Name = "btn_PayVisa";
            this.btn_PayVisa.Size = new System.Drawing.Size(264, 41);
            this.btn_PayVisa.TabIndex = 0;
            this.btn_PayVisa.Text = "Visa";
            this.btn_PayVisa.UseVisualStyleBackColor = true;
            this.btn_PayVisa.Click += new System.EventHandler(this.btn_PayVisa_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(230, 31);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 49);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // lbl1_EuroSignTxt
            // 
            this.lbl1_EuroSignTxt.AutoSize = true;
            this.lbl1_EuroSignTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_EuroSignTxt.Location = new System.Drawing.Point(248, 123);
            this.lbl1_EuroSignTxt.Name = "lbl1_EuroSignTxt";
            this.lbl1_EuroSignTxt.Size = new System.Drawing.Size(19, 21);
            this.lbl1_EuroSignTxt.TabIndex = 11;
            this.lbl1_EuroSignTxt.Text = "€";
            // 
            // btn_PayCash
            // 
            this.btn_PayCash.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayCash.Location = new System.Drawing.Point(58, 177);
            this.btn_PayCash.Name = "btn_PayCash";
            this.btn_PayCash.Size = new System.Drawing.Size(264, 41);
            this.btn_PayCash.TabIndex = 13;
            this.btn_PayCash.Text = "Cash";
            this.btn_PayCash.UseVisualStyleBackColor = true;
            this.btn_PayCash.Click += new System.EventHandler(this.btn_PayCash_Click);
            // 
            // btn_PayPin
            // 
            this.btn_PayPin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayPin.Location = new System.Drawing.Point(58, 235);
            this.btn_PayPin.Name = "btn_PayPin";
            this.btn_PayPin.Size = new System.Drawing.Size(264, 43);
            this.btn_PayPin.TabIndex = 14;
            this.btn_PayPin.Text = "Pin";
            this.btn_PayPin.UseVisualStyleBackColor = true;
            this.btn_PayPin.Click += new System.EventHandler(this.btn_PayPin_Click);
            // 
            // btn_PayMaestro
            // 
            this.btn_PayMaestro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayMaestro.Location = new System.Drawing.Point(58, 295);
            this.btn_PayMaestro.Name = "btn_PayMaestro";
            this.btn_PayMaestro.Size = new System.Drawing.Size(264, 43);
            this.btn_PayMaestro.TabIndex = 15;
            this.btn_PayMaestro.Text = "Maestro";
            this.btn_PayMaestro.UseVisualStyleBackColor = true;
            this.btn_PayMaestro.Click += new System.EventHandler(this.btn_PayMaestro_Click);
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(183, 123);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(45, 21);
            this.lbl_TotalPrice.TabIndex = 16;
            this.lbl_TotalPrice.Text = "?????";
            // 
            // PaymentMethodUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.btn_PayMaestro);
            this.Controls.Add(this.btn_PayPin);
            this.Controls.Add(this.btn_PayCash);
            this.Controls.Add(this.lbl1_EuroSignTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_PayVisa);
            this.Name = "PaymentMethodUI";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PayVisa;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1_EuroSignTxt;
        private System.Windows.Forms.Button btn_PayCash;
        private System.Windows.Forms.Button btn_PayPin;
        private System.Windows.Forms.Button btn_PayMaestro;
        private System.Windows.Forms.Label lbl_TotalPrice;
    }
}
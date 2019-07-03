namespace Chepeau_UI
{
    partial class Card_payment
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
            this.btn_checkPin = new System.Windows.Forms.Button();
            this.txtBx_pin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txtBx_fullPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1_EuroSignTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_checkPin
            // 
            this.btn_checkPin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkPin.Location = new System.Drawing.Point(57, 274);
            this.btn_checkPin.Name = "btn_checkPin";
            this.btn_checkPin.Size = new System.Drawing.Size(223, 96);
            this.btn_checkPin.TabIndex = 0;
            this.btn_checkPin.Text = "Check Pin";
            this.btn_checkPin.UseVisualStyleBackColor = true;
            this.btn_checkPin.Click += new System.EventHandler(this.btn_checkPin_Click);
            // 
            // txtBx_pin
            // 
            this.txtBx_pin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_pin.Location = new System.Drawing.Point(154, 195);
            this.txtBx_pin.Name = "txtBx_pin";
            this.txtBx_pin.PasswordChar = '*';
            this.txtBx_pin.Size = new System.Drawing.Size(100, 23);
            this.txtBx_pin.TabIndex = 1;
            this.txtBx_pin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "(must be 4 digits)";
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
            // txtBx_fullPrice
            // 
            this.txtBx_fullPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_fullPrice.Location = new System.Drawing.Point(154, 130);
            this.txtBx_fullPrice.Name = "txtBx_fullPrice";
            this.txtBx_fullPrice.Size = new System.Drawing.Size(100, 23);
            this.txtBx_fullPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // lbl1_EuroSignTxt
            // 
            this.lbl1_EuroSignTxt.AutoSize = true;
            this.lbl1_EuroSignTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_EuroSignTxt.Location = new System.Drawing.Point(260, 132);
            this.lbl1_EuroSignTxt.Name = "lbl1_EuroSignTxt";
            this.lbl1_EuroSignTxt.Size = new System.Drawing.Size(19, 21);
            this.lbl1_EuroSignTxt.TabIndex = 11;
            this.lbl1_EuroSignTxt.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "€";
            // 
            // Card_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1_EuroSignTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_fullPrice);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_pin);
            this.Controls.Add(this.btn_checkPin);
            this.Name = "Card_payment";
            this.Text = "Card_payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checkPin;
        private System.Windows.Forms.TextBox txtBx_pin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txtBx_fullPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1_EuroSignTxt;
        private System.Windows.Forms.Label label4;
    }
}
namespace Chepeau_UI
{
    partial class CompletedOrders
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.listViewCompleted = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timenow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 56);
            this.label2.TabIndex = 26;
            this.label2.Text = "Orders Completed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(376, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 57);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listViewCompleted
            // 
            this.listViewCompleted.Location = new System.Drawing.Point(17, 116);
            this.listViewCompleted.Name = "listViewCompleted";
            this.listViewCompleted.Size = new System.Drawing.Size(453, 525);
            this.listViewCompleted.TabIndex = 31;
            this.listViewCompleted.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timenow
            // 
            this.lbl_timenow.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timenow.Location = new System.Drawing.Point(12, 9);
            this.lbl_timenow.Name = "lbl_timenow";
            this.lbl_timenow.Size = new System.Drawing.Size(196, 56);
            this.lbl_timenow.TabIndex = 34;
            this.lbl_timenow.Text = "Time";
            this.lbl_timenow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompletedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.lbl_timenow);
            this.Controls.Add(this.listViewCompleted);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Name = "CompletedOrders";
            this.Text = "Completed Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListView listViewCompleted;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timenow;
    }
}
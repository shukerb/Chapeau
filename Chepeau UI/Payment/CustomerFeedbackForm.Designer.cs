namespace Chepeau_UI
{
    partial class CustomerFeedbackFormUI
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
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.txtBx_Feedback = new System.Windows.Forms.RichTextBox();
            this.lbl_CommentText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Feedback.Location = new System.Drawing.Point(58, 289);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(161, 53);
            this.btn_Feedback.TabIndex = 0;
            this.btn_Feedback.Text = "Leave Feedback";
            this.btn_Feedback.UseVisualStyleBackColor = true;
            this.btn_Feedback.Click += new System.EventHandler(this.btn_Feedback_Click);
            // 
            // txtBx_Feedback
            // 
            this.txtBx_Feedback.Location = new System.Drawing.Point(35, 40);
            this.txtBx_Feedback.Name = "txtBx_Feedback";
            this.txtBx_Feedback.Size = new System.Drawing.Size(196, 234);
            this.txtBx_Feedback.TabIndex = 1;
            this.txtBx_Feedback.Text = "";
            // 
            // lbl_CommentText
            // 
            this.lbl_CommentText.AutoSize = true;
            this.lbl_CommentText.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CommentText.Location = new System.Drawing.Point(40, 14);
            this.lbl_CommentText.Name = "lbl_CommentText";
            this.lbl_CommentText.Size = new System.Drawing.Size(102, 23);
            this.lbl_CommentText.TabIndex = 2;
            this.lbl_CommentText.Text = "Comment:";
            // 
            // CustomerFeedbackFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 370);
            this.Controls.Add(this.lbl_CommentText);
            this.Controls.Add(this.txtBx_Feedback);
            this.Controls.Add(this.btn_Feedback);
            this.Name = "CustomerFeedbackFormUI";
            this.Text = "CustomerFeedbackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.RichTextBox txtBx_Feedback;
        private System.Windows.Forms.Label lbl_CommentText;
    }
}
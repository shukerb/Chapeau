namespace Chepeau_UI
{
    partial class AddCommentToItemUI
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
            this.lbl_Add = new System.Windows.Forms.Label();
            this.tbox_Comment = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.tbox_Amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add.Location = new System.Drawing.Point(12, 17);
            this.lbl_Add.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(402, 63);
            this.lbl_Add.TabIndex = 0;
            this.lbl_Add.Text = "Write Comment";
            // 
            // tbox_Comment
            // 
            this.tbox_Comment.Location = new System.Drawing.Point(22, 103);
            this.tbox_Comment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbox_Comment.Multiline = true;
            this.tbox_Comment.Name = "tbox_Comment";
            this.tbox_Comment.Size = new System.Drawing.Size(679, 325);
            this.tbox_Comment.TabIndex = 1;
            this.tbox_Comment.TextChanged += new System.EventHandler(this.tbox_Comment_TextChanged);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apply.Location = new System.Drawing.Point(15, 534);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(693, 81);
            this.btn_Apply.TabIndex = 2;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(445, 447);
            this.btn_Plus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(122, 75);
            this.btn_Plus.TabIndex = 3;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(579, 447);
            this.btn_Minus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(122, 75);
            this.btn_Minus.TabIndex = 4;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(29, 447);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(213, 63);
            this.lbl_Amount.TabIndex = 5;
            this.lbl_Amount.Text = "Amount";
            // 
            // tbox_Amount
            // 
            this.tbox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Amount.Location = new System.Drawing.Point(303, 447);
            this.tbox_Amount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbox_Amount.Multiline = true;
            this.tbox_Amount.Name = "tbox_Amount";
            this.tbox_Amount.ReadOnly = true;
            this.tbox_Amount.Size = new System.Drawing.Size(120, 71);
            this.tbox_Amount.TabIndex = 6;
            // 
            // AddCommentToItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 645);
            this.Controls.Add(this.tbox_Amount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.tbox_Comment);
            this.Controls.Add(this.lbl_Add);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCommentToItemUI";
            this.Text = "Add Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.TextBox tbox_Comment;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox tbox_Amount;
    }
}
namespace Chepeau_UI
{
    partial class ChooseMenuTypeUI
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
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.btn_Dinner = new System.Windows.Forms.Button();
            this.btn_Drinks = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lunch.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Lunch.Location = new System.Drawing.Point(12, 131);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(340, 61);
            this.btn_Lunch.TabIndex = 0;
            this.btn_Lunch.Text = "Lunch";
            this.btn_Lunch.UseVisualStyleBackColor = false;
            this.btn_Lunch.Click += new System.EventHandler(this.btn_Lunch_Click);
            // 
            // btn_Dinner
            // 
            this.btn_Dinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Dinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dinner.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Dinner.Location = new System.Drawing.Point(12, 198);
            this.btn_Dinner.Name = "btn_Dinner";
            this.btn_Dinner.Size = new System.Drawing.Size(340, 61);
            this.btn_Dinner.TabIndex = 1;
            this.btn_Dinner.Text = "Dinner";
            this.btn_Dinner.UseVisualStyleBackColor = false;
            this.btn_Dinner.Click += new System.EventHandler(this.btn_Dinner_Click);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drinks.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Drinks.Location = new System.Drawing.Point(12, 265);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(340, 61);
            this.btn_Drinks.TabIndex = 2;
            this.btn_Drinks.Text = "Drinks";
            this.btn_Drinks.UseVisualStyleBackColor = false;
            this.btn_Drinks.Click += new System.EventHandler(this.btn_Drinks_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.LightGray;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Confirm.Location = new System.Drawing.Point(12, 17);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(340, 73);
            this.btn_Confirm.TabIndex = 14;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ChooseMenuTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Drinks);
            this.Controls.Add(this.btn_Dinner);
            this.Controls.Add(this.btn_Lunch);
            this.Name = "ChooseMenuTypeUI";
            this.Text = "Take Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.Button btn_Dinner;
        private System.Windows.Forms.Button btn_Drinks;
        private System.Windows.Forms.Button btn_Confirm;
    }
}
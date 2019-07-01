namespace Chepeau_UI
{
    partial class TableInformationUI
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
            this.lv_Order = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_TableNumber = new System.Windows.Forms.Label();
            this.btn_takeOrder = new System.Windows.Forms.Button();
            this.btn_payBill = new System.Windows.Forms.Button();
            this.btn_occupy = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_orderList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelReservation = new System.Windows.Forms.Button();
            this.btn_alterOrder = new System.Windows.Forms.Button();
            this.btn_deleteItems = new System.Windows.Forms.Button();
            this.clb_orderItems = new System.Windows.Forms.CheckedListBox();
            this.btn_confirmDelete = new System.Windows.Forms.Button();
            this.btn_sendOrder = new System.Windows.Forms.Button();
            this.btn_OrderServed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Order
            // 
            this.lv_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemAmount});
            this.lv_Order.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Order.GridLines = true;
            this.lv_Order.Location = new System.Drawing.Point(11, 82);
            this.lv_Order.Name = "lv_Order";
            this.lv_Order.Size = new System.Drawing.Size(338, 253);
            this.lv_Order.TabIndex = 0;
            this.lv_Order.UseCompatibleStateImageBehavior = false;
            this.lv_Order.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 231;
            // 
            // ItemAmount
            // 
            this.ItemAmount.Text = "Amount";
            this.ItemAmount.Width = 103;
            // 
            // lbl_TableNumber
            // 
            this.lbl_TableNumber.AutoSize = true;
            this.lbl_TableNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableNumber.Location = new System.Drawing.Point(169, 14);
            this.lbl_TableNumber.Name = "lbl_TableNumber";
            this.lbl_TableNumber.Size = new System.Drawing.Size(0, 21);
            this.lbl_TableNumber.TabIndex = 1;
            // 
            // btn_takeOrder
            // 
            this.btn_takeOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takeOrder.Location = new System.Drawing.Point(65, 352);
            this.btn_takeOrder.Name = "btn_takeOrder";
            this.btn_takeOrder.Size = new System.Drawing.Size(240, 32);
            this.btn_takeOrder.TabIndex = 2;
            this.btn_takeOrder.Text = "Take Order";
            this.btn_takeOrder.UseVisualStyleBackColor = true;
            this.btn_takeOrder.Click += new System.EventHandler(this.btn_takeOrder_Click);
            // 
            // btn_payBill
            // 
            this.btn_payBill.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payBill.Location = new System.Drawing.Point(65, 446);
            this.btn_payBill.Name = "btn_payBill";
            this.btn_payBill.Size = new System.Drawing.Size(240, 32);
            this.btn_payBill.TabIndex = 3;
            this.btn_payBill.Text = "Pay Bill";
            this.btn_payBill.UseVisualStyleBackColor = true;
            this.btn_payBill.Click += new System.EventHandler(this.btn_payBill_Click);
            // 
            // btn_occupy
            // 
            this.btn_occupy.BackColor = System.Drawing.Color.Red;
            this.btn_occupy.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_occupy.Location = new System.Drawing.Point(111, 221);
            this.btn_occupy.Name = "btn_occupy";
            this.btn_occupy.Size = new System.Drawing.Size(144, 114);
            this.btn_occupy.TabIndex = 4;
            this.btn_occupy.Text = "Occupy";
            this.btn_occupy.UseVisualStyleBackColor = false;
            this.btn_occupy.Click += new System.EventHandler(this.btn_occupy_Click);
            // 
            // btn_reserve
            // 
            this.btn_reserve.BackColor = System.Drawing.Color.Yellow;
            this.btn_reserve.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserve.Location = new System.Drawing.Point(111, 81);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(144, 114);
            this.btn_reserve.TabIndex = 5;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = false;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(268, 13);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 24);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_orderList
            // 
            this.lbl_orderList.AutoSize = true;
            this.lbl_orderList.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderList.Location = new System.Drawing.Point(12, 49);
            this.lbl_orderList.Name = "lbl_orderList";
            this.lbl_orderList.Size = new System.Drawing.Size(83, 21);
            this.lbl_orderList.TabIndex = 9;
            this.lbl_orderList.Text = "Order List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Table Number";
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelReservation.Location = new System.Drawing.Point(12, 494);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(98, 26);
            this.btn_cancelReservation.TabIndex = 11;
            this.btn_cancelReservation.Text = "Free Table";
            this.btn_cancelReservation.UseVisualStyleBackColor = true;
            this.btn_cancelReservation.Click += new System.EventHandler(this.btn_cancelReservation_Click_1);
            // 
            // btn_alterOrder
            // 
            this.btn_alterOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterOrder.Location = new System.Drawing.Point(65, 352);
            this.btn_alterOrder.Name = "btn_alterOrder";
            this.btn_alterOrder.Size = new System.Drawing.Size(114, 32);
            this.btn_alterOrder.TabIndex = 12;
            this.btn_alterOrder.Text = "Alter Order";
            this.btn_alterOrder.UseVisualStyleBackColor = true;
            this.btn_alterOrder.Click += new System.EventHandler(this.btn_alterOrder_Click_1);
            // 
            // btn_deleteItems
            // 
            this.btn_deleteItems.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteItems.Location = new System.Drawing.Point(191, 352);
            this.btn_deleteItems.Name = "btn_deleteItems";
            this.btn_deleteItems.Size = new System.Drawing.Size(114, 32);
            this.btn_deleteItems.TabIndex = 13;
            this.btn_deleteItems.Text = "Delete Items";
            this.btn_deleteItems.UseVisualStyleBackColor = true;
            this.btn_deleteItems.Click += new System.EventHandler(this.btn_deleteItems_Click);
            // 
            // clb_orderItems
            // 
            this.clb_orderItems.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_orderItems.FormattingEnabled = true;
            this.clb_orderItems.Location = new System.Drawing.Point(11, 81);
            this.clb_orderItems.Name = "clb_orderItems";
            this.clb_orderItems.Size = new System.Drawing.Size(341, 257);
            this.clb_orderItems.TabIndex = 14;
            // 
            // btn_confirmDelete
            // 
            this.btn_confirmDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmDelete.Location = new System.Drawing.Point(65, 352);
            this.btn_confirmDelete.Name = "btn_confirmDelete";
            this.btn_confirmDelete.Size = new System.Drawing.Size(240, 32);
            this.btn_confirmDelete.TabIndex = 15;
            this.btn_confirmDelete.Text = "Confirm";
            this.btn_confirmDelete.UseVisualStyleBackColor = true;
            this.btn_confirmDelete.Click += new System.EventHandler(this.btn_confirmDelete_Click);
            // 
            // btn_sendOrder
            // 
            this.btn_sendOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendOrder.Location = new System.Drawing.Point(65, 401);
            this.btn_sendOrder.Name = "btn_sendOrder";
            this.btn_sendOrder.Size = new System.Drawing.Size(240, 32);
            this.btn_sendOrder.TabIndex = 16;
            this.btn_sendOrder.Text = "Send Order";
            this.btn_sendOrder.UseVisualStyleBackColor = true;
            this.btn_sendOrder.Click += new System.EventHandler(this.btn_sendOrder_Click);
            // 
            // btn_OrderServed
            // 
            this.btn_OrderServed.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderServed.Location = new System.Drawing.Point(251, 493);
            this.btn_OrderServed.Name = "btn_OrderServed";
            this.btn_OrderServed.Size = new System.Drawing.Size(98, 26);
            this.btn_OrderServed.TabIndex = 17;
            this.btn_OrderServed.Text = "Served";
            this.btn_OrderServed.UseVisualStyleBackColor = true;
            this.btn_OrderServed.Click += new System.EventHandler(this.btn_OrderServed_Click);
            // 
            // TableInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 531);
            this.Controls.Add(this.btn_OrderServed);
            this.Controls.Add(this.lv_Order);
            this.Controls.Add(this.btn_sendOrder);
            this.Controls.Add(this.btn_confirmDelete);
            this.Controls.Add(this.clb_orderItems);
            this.Controls.Add(this.btn_deleteItems);
            this.Controls.Add(this.btn_alterOrder);
            this.Controls.Add(this.btn_cancelReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_orderList);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.btn_occupy);
            this.Controls.Add(this.btn_payBill);
            this.Controls.Add(this.btn_takeOrder);
            this.Controls.Add(this.lbl_TableNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableInformationUI";
            this.Text = "Table Information";
            //this.Load += new System.EventHandler(this.TableInformationUI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Order;
        private System.Windows.Forms.Label lbl_TableNumber;
        private System.Windows.Forms.Button btn_takeOrder;
        private System.Windows.Forms.Button btn_payBill;
        private System.Windows.Forms.Button btn_occupy;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_orderList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelReservation;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemAmount;
        private System.Windows.Forms.Button btn_alterOrder;
        private System.Windows.Forms.Button btn_deleteItems;
        private System.Windows.Forms.CheckedListBox clb_orderItems;
        private System.Windows.Forms.Button btn_confirmDelete;
        private System.Windows.Forms.Button btn_sendOrder;
        private System.Windows.Forms.Button btn_OrderServed;
    }
}
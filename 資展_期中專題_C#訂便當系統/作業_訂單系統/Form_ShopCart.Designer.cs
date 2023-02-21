namespace 作業_訂單系統
{
    partial class Form_ShopCart
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
            this.lblShopCart = new System.Windows.Forms.Label();
            this.lblAcount = new System.Windows.Forms.Label();
            this.txtorderTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtorderAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtorderName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbboxAddRice = new System.Windows.Forms.ComboBox();
            this.listBoxShopCart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShopCartTotal = new System.Windows.Forms.Label();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.btnCleanAll = new System.Windows.Forms.Button();
            this.btnCItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShopCart
            // 
            this.lblShopCart.AutoSize = true;
            this.lblShopCart.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShopCart.Location = new System.Drawing.Point(338, 9);
            this.lblShopCart.Name = "lblShopCart";
            this.lblShopCart.Size = new System.Drawing.Size(164, 47);
            this.lblShopCart.TabIndex = 0;
            this.lblShopCart.Text = "購物車";
            // 
            // lblAcount
            // 
            this.lblAcount.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAcount.Location = new System.Drawing.Point(12, 9);
            this.lblAcount.Name = "lblAcount";
            this.lblAcount.Size = new System.Drawing.Size(193, 64);
            this.lblAcount.TabIndex = 24;
            this.lblAcount.Text = "請先登入帳號";
            // 
            // txtorderTel
            // 
            this.txtorderTel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtorderTel.Location = new System.Drawing.Point(928, 294);
            this.txtorderTel.Multiline = true;
            this.txtorderTel.Name = "txtorderTel";
            this.txtorderTel.Size = new System.Drawing.Size(154, 39);
            this.txtorderTel.TabIndex = 30;
            this.txtorderTel.TextChanged += new System.EventHandler(this.txtorderTel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(923, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "電話";
            // 
            // txtorderAdress
            // 
            this.txtorderAdress.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtorderAdress.Location = new System.Drawing.Point(928, 375);
            this.txtorderAdress.Multiline = true;
            this.txtorderAdress.Name = "txtorderAdress";
            this.txtorderAdress.Size = new System.Drawing.Size(256, 133);
            this.txtorderAdress.TabIndex = 28;
            this.txtorderAdress.TextChanged += new System.EventHandler(this.txtorderAdress_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(923, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "外送地址";
            // 
            // txtorderName
            // 
            this.txtorderName.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtorderName.Location = new System.Drawing.Point(928, 221);
            this.txtorderName.Multiline = true;
            this.txtorderName.Name = "txtorderName";
            this.txtorderName.Size = new System.Drawing.Size(154, 39);
            this.txtorderName.TabIndex = 26;
            this.txtorderName.TextChanged += new System.EventHandler(this.txtorderName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(923, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "訂購人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(928, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "加飯";
            // 
            // cbboxAddRice
            // 
            this.cbboxAddRice.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbboxAddRice.FormattingEnabled = true;
            this.cbboxAddRice.Location = new System.Drawing.Point(1004, 66);
            this.cbboxAddRice.Name = "cbboxAddRice";
            this.cbboxAddRice.Size = new System.Drawing.Size(140, 35);
            this.cbboxAddRice.TabIndex = 31;
            this.cbboxAddRice.SelectedIndexChanged += new System.EventHandler(this.cbboxAddRice_SelectedIndexChanged);
            // 
            // listBoxShopCart
            // 
            this.listBoxShopCart.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxShopCart.FormattingEnabled = true;
            this.listBoxShopCart.ItemHeight = 23;
            this.listBoxShopCart.Location = new System.Drawing.Point(12, 66);
            this.listBoxShopCart.Name = "listBoxShopCart";
            this.listBoxShopCart.Size = new System.Drawing.Size(894, 441);
            this.listBoxShopCart.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 36);
            this.label2.TabIndex = 40;
            this.label2.Text = "注意!!外送金額需滿 150 元";
            // 
            // lblShopCartTotal
            // 
            this.lblShopCartTotal.AutoSize = true;
            this.lblShopCartTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShopCartTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShopCartTotal.ForeColor = System.Drawing.Color.Red;
            this.lblShopCartTotal.Location = new System.Drawing.Point(955, 516);
            this.lblShopCartTotal.Name = "lblShopCartTotal";
            this.lblShopCartTotal.Size = new System.Drawing.Size(201, 40);
            this.lblShopCartTotal.TabIndex = 41;
            this.lblShopCartTotal.Text = "訂單總價    元";
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendOrder.Location = new System.Drawing.Point(971, 610);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(214, 74);
            this.btnSendOrder.TabIndex = 44;
            this.btnSendOrder.Text = "送出訂單";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnCleanAll
            // 
            this.btnCleanAll.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCleanAll.Location = new System.Drawing.Point(751, 610);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(214, 74);
            this.btnCleanAll.TabIndex = 43;
            this.btnCleanAll.Text = "清除所有品項";
            this.btnCleanAll.UseVisualStyleBackColor = true;
            this.btnCleanAll.Click += new System.EventHandler(this.btnCleanAll_Click);
            // 
            // btnCItem
            // 
            this.btnCItem.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCItem.Location = new System.Drawing.Point(531, 610);
            this.btnCItem.Name = "btnCItem";
            this.btnCItem.Size = new System.Drawing.Size(214, 74);
            this.btnCItem.TabIndex = 42;
            this.btnCItem.Text = "移除所選品項";
            this.btnCItem.UseVisualStyleBackColor = true;
            this.btnCItem.Click += new System.EventHandler(this.btnCItem_Click);
            // 
            // Form_ShopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1196, 696);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnCleanAll);
            this.Controls.Add(this.btnCItem);
            this.Controls.Add(this.lblShopCartTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxShopCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbboxAddRice);
            this.Controls.Add(this.txtorderTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtorderAdress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtorderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAcount);
            this.Controls.Add(this.lblShopCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ShopCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.Form_ShopCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopCart;
        private System.Windows.Forms.Label lblAcount;
        private System.Windows.Forms.TextBox txtorderTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtorderAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtorderName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbboxAddRice;
        private System.Windows.Forms.ListBox listBoxShopCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShopCartTotal;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.Button btnCleanAll;
        private System.Windows.Forms.Button btnCItem;
    }
}
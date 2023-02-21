namespace 作業_訂單系統
{
    partial class OrderDtails
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
            this.lblProductsName = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbboxAddVa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbboxAddEgg = new System.Windows.Forms.ComboBox();
            this.pboxProducts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductsName
            // 
            this.lblProductsName.AutoSize = true;
            this.lblProductsName.BackColor = System.Drawing.Color.Gold;
            this.lblProductsName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductsName.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductsName.Location = new System.Drawing.Point(96, 9);
            this.lblProductsName.Name = "lblProductsName";
            this.lblProductsName.Size = new System.Drawing.Size(130, 30);
            this.lblProductsName.TabIndex = 2;
            this.lblProductsName.Text = "商品名稱";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblid.Location = new System.Drawing.Point(56, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(34, 28);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(611, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "價格";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.LightGreen;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(699, 54);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 28);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "價格";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCount.Location = new System.Drawing.Point(704, 102);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(65, 40);
            this.txtCount.TabIndex = 6;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(611, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "數量";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCart.Location = new System.Drawing.Point(587, 307);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(195, 74);
            this.btnAddCart.TabIndex = 10;
            this.btnAddCart.Text = "加入購物車";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(601, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "總價";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTotal.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(703, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(582, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "加菜脯";
            // 
            // cbboxAddVa
            // 
            this.cbboxAddVa.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbboxAddVa.FormattingEnabled = true;
            this.cbboxAddVa.Location = new System.Drawing.Point(687, 204);
            this.cbboxAddVa.Name = "cbboxAddVa";
            this.cbboxAddVa.Size = new System.Drawing.Size(84, 35);
            this.cbboxAddVa.TabIndex = 39;
            this.cbboxAddVa.SelectedIndexChanged += new System.EventHandler(this.cbboxAddVa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(611, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "加蛋";
            // 
            // cbboxAddEgg
            // 
            this.cbboxAddEgg.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbboxAddEgg.FormattingEnabled = true;
            this.cbboxAddEgg.Location = new System.Drawing.Point(687, 152);
            this.cbboxAddEgg.Name = "cbboxAddEgg";
            this.cbboxAddEgg.Size = new System.Drawing.Size(84, 35);
            this.cbboxAddEgg.TabIndex = 37;
            this.cbboxAddEgg.SelectedIndexChanged += new System.EventHandler(this.cbboxAddEgg_SelectedIndexChanged);
            // 
            // pboxProducts
            // 
            this.pboxProducts.Location = new System.Drawing.Point(57, 54);
            this.pboxProducts.Name = "pboxProducts";
            this.pboxProducts.Size = new System.Drawing.Size(482, 327);
            this.pboxProducts.TabIndex = 41;
            this.pboxProducts.TabStop = false;
            // 
            // OrderDtails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.pboxProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbboxAddVa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbboxAddEgg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblProductsName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderDtails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "購物資訊";
            this.Load += new System.EventHandler(this.OrderDtails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductsName;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbboxAddVa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbboxAddEgg;
        private System.Windows.Forms.PictureBox pboxProducts;
    }
}
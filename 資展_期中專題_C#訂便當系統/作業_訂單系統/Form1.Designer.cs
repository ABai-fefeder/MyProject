namespace 作業_訂單系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.listViewItem = new System.Windows.Forms.ListView();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btnShopCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "鄧園雞腿飯 訂購系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(373, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 5;
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.LightGreen;
            this.lbl單價.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(491, 690);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(0, 28);
            this.lbl單價.TabIndex = 6;
            // 
            // listViewItem
            // 
            this.listViewItem.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewItem.HideSelection = false;
            this.listViewItem.Location = new System.Drawing.Point(41, 86);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(514, 603);
            this.listViewItem.TabIndex = 24;
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.ItemActivate += new System.EventHandler(this.listViewItem_ItemActivate);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderList.Location = new System.Drawing.Point(561, 625);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(169, 64);
            this.btnOrderList.TabIndex = 27;
            this.btnOrderList.Text = "訂單管理";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMember.Location = new System.Drawing.Point(561, 555);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(169, 64);
            this.btnMember.TabIndex = 28;
            this.btnMember.Text = "會員管理";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProducts.Location = new System.Drawing.Point(561, 485);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(169, 64);
            this.btnProducts.TabIndex = 29;
            this.btnProducts.Text = "商品管理";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btn登入
            // 
            this.btn登入.FlatAppearance.BorderSize = 0;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Image = global::作業_訂單系統.Properties.Resources.login1;
            this.btn登入.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn登入.Location = new System.Drawing.Point(3, 89);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(100, 90);
            this.btn登入.TabIndex = 26;
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btnShopCart
            // 
            this.btnShopCart.FlatAppearance.BorderSize = 0;
            this.btnShopCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopCart.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShopCart.Image = global::作業_訂單系統.Properties.Resources.DEapL7Ohji1;
            this.btnShopCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShopCart.Location = new System.Drawing.Point(3, 3);
            this.btnShopCart.Name = "btnShopCart";
            this.btnShopCart.Size = new System.Drawing.Size(100, 90);
            this.btnShopCart.TabIndex = 25;
            this.btnShopCart.UseVisualStyleBackColor = true;
            this.btnShopCart.Click += new System.EventHandler(this.btnShopCart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShopCart);
            this.panel1.Controls.Add(this.btn登入);
            this.panel1.Location = new System.Drawing.Point(561, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 207);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(768, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.listViewItem);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂單系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.Button btnShopCart;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace GrocerCheckout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlCheckout = new TabControl();
            AddItem = new TabPage();
            btnClear = new Button();
            btnAdd = new Button();
            nmrQty = new NumericUpDown();
            lblQty = new Label();
            txtPrdPrice = new TextBox();
            lblPrdPrice = new Label();
            lblPrdName = new Label();
            txtPrdName = new TextBox();
            ViewCart = new TabPage();
            btnEmptyCart = new Button();
            btnLoad = new Button();
            listProducts = new ListView();
            Checkout = new TabPage();
            Options = new TabPage();
            tabControlCheckout.SuspendLayout();
            AddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQty).BeginInit();
            ViewCart.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCheckout
            // 
            tabControlCheckout.Controls.Add(AddItem);
            tabControlCheckout.Controls.Add(ViewCart);
            tabControlCheckout.Controls.Add(Checkout);
            tabControlCheckout.Controls.Add(Options);
            tabControlCheckout.Dock = DockStyle.Fill;
            tabControlCheckout.Location = new Point(0, 0);
            tabControlCheckout.Name = "tabControlCheckout";
            tabControlCheckout.SelectedIndex = 0;
            tabControlCheckout.Size = new Size(484, 450);
            tabControlCheckout.TabIndex = 0;
            // 
            // AddItem
            // 
            AddItem.Controls.Add(btnClear);
            AddItem.Controls.Add(btnAdd);
            AddItem.Controls.Add(nmrQty);
            AddItem.Controls.Add(lblQty);
            AddItem.Controls.Add(txtPrdPrice);
            AddItem.Controls.Add(lblPrdPrice);
            AddItem.Controls.Add(lblPrdName);
            AddItem.Controls.Add(txtPrdName);
            AddItem.Location = new Point(4, 24);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(476, 422);
            AddItem.TabIndex = 0;
            AddItem.Text = "Add Items";
            AddItem.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(8, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(393, 391);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nmrQty
            // 
            nmrQty.Location = new Point(67, 155);
            nmrQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQty.Name = "nmrQty";
            nmrQty.Size = new Size(401, 23);
            nmrQty.TabIndex = 5;
            nmrQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(8, 155);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 4;
            lblQty.Text = "Quantity";
            // 
            // txtPrdPrice
            // 
            txtPrdPrice.Location = new Point(8, 115);
            txtPrdPrice.Name = "txtPrdPrice";
            txtPrdPrice.Size = new Size(460, 23);
            txtPrdPrice.TabIndex = 3;
            // 
            // lblPrdPrice
            // 
            lblPrdPrice.AutoSize = true;
            lblPrdPrice.Location = new Point(8, 97);
            lblPrdPrice.Name = "lblPrdPrice";
            lblPrdPrice.Size = new Size(78, 15);
            lblPrdPrice.TabIndex = 2;
            lblPrdPrice.Text = "Product Price";
            // 
            // lblPrdName
            // 
            lblPrdName.AutoSize = true;
            lblPrdName.Location = new Point(8, 40);
            lblPrdName.Name = "lblPrdName";
            lblPrdName.Size = new Size(84, 15);
            lblPrdName.TabIndex = 1;
            lblPrdName.Text = "Product Name";
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(8, 58);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(460, 23);
            txtPrdName.TabIndex = 0;
            // 
            // ViewCart
            // 
            ViewCart.Controls.Add(btnEmptyCart);
            ViewCart.Controls.Add(btnLoad);
            ViewCart.Controls.Add(listProducts);
            ViewCart.Location = new Point(4, 24);
            ViewCart.Name = "ViewCart";
            ViewCart.Size = new Size(476, 422);
            ViewCart.TabIndex = 1;
            ViewCart.Text = "View Cart";
            ViewCart.UseVisualStyleBackColor = true;
            // 
            // btnEmptyCart
            // 
            btnEmptyCart.Location = new Point(3, 396);
            btnEmptyCart.Name = "btnEmptyCart";
            btnEmptyCart.Size = new Size(213, 23);
            btnEmptyCart.TabIndex = 2;
            btnEmptyCart.Text = "Empty Cart";
            btnEmptyCart.UseVisualStyleBackColor = true;
            btnEmptyCart.Click += btnEmptyCart_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(285, 396);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(188, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Cart";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // listProducts
            // 
            listProducts.Location = new Point(3, 3);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(470, 387);
            listProducts.TabIndex = 0;
            listProducts.UseCompatibleStateImageBehavior = false;
            // 
            // Checkout
            // 
            Checkout.Location = new Point(4, 24);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(476, 422);
            Checkout.TabIndex = 2;
            Checkout.Text = "Checkout";
            Checkout.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            Options.Location = new Point(4, 24);
            Options.Name = "Options";
            Options.Size = new Size(476, 422);
            Options.TabIndex = 3;
            Options.Text = "Options";
            Options.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(tabControlCheckout);
            Name = "Form1";
            Text = "Checkout";
            tabControlCheckout.ResumeLayout(false);
            AddItem.ResumeLayout(false);
            AddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQty).EndInit();
            ViewCart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCheckout;
        private TabPage AddItem;
        private TabPage ViewCart;
        private TabPage Checkout;
        private TabPage Options;
        private Button btnClear;
        private Button btnAdd;
        private NumericUpDown nmrQty;
        private Label lblQty;
        private TextBox txtPrdPrice;
        private Label lblPrdPrice;
        private Label lblPrdName;
        private TextBox txtPrdName;
        private ListView listProducts;
        private Button btnEmptyCart;
        private Button btnLoad;
    }
}

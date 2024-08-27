namespace GrocerCheckout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeList();
        }
        Product product;
        Stack<Product> stack = new Stack<Product>();
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFrom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtPrdName.Text;
            int qty = (int)nmrQty.Value;
            string sPrice = txtPrdPrice.Text.Trim();
            sPrice = sPrice.Replace('.', ',');
            try
            {
                double price = double.Parse(sPrice);
                product = new Product(name, price, qty);
                stack.Push(product);
                resetFrom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Price. Please try again.");
            }
        }
        private void resetFrom()
        {
            txtPrdName.Clear();
            txtPrdPrice.Clear();
            nmrQty.Value = 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            populateList();
        }
        private void initializeList()
        {
            listProducts.View = View.Details;
            listProducts.Columns.Add("", 0);
            listProducts.Columns.Add("Product Name", 200);
            listProducts.Columns.Add("Product Price", 100);
            listProducts.Columns.Add("Quantity", 70);
            listProducts.Columns.Add("Total", 100);
        }
        private void populateList()
        {
            clearList();
            foreach (var item in stack)
            {
                ListViewItem prod = new ListViewItem();
                prod.SubItems.Add(item.getName());
                prod.SubItems.Add("R " + item.getPrice());
                prod.SubItems.Add("" + item.getQty());
                prod.SubItems.Add("R " + item.getTotal());
                listProducts.Items.Add(prod);
            }
        }
        private void clearList()
        {
            listProducts.Items.Clear();
        }
        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            int itemsRemoved = stack.Count;
            for(int i = stack.Count; i > 0; i--)
            {
                stack.Pop();
            }
            MessageBox.Show($"Removed {itemsRemoved} items from cart");
            populateList();
        }
    }
}

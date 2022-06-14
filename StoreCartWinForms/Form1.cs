using StoreCartWinForms.Model;

namespace StoreCartWinForms
{
    public partial class Form1 : Form
    {
        private StoreDBContext storeContext;
        private List<Product> listOfProducts = new List<Product>();
        private bool open = false;

        private void Add()
        {
            if (open == true)
            {
                if (productNameTxt.Text != String.Empty)
                {
                    var newProduct = new Product
                    {
                        ProductName = productNameTxt.Text,
                        Quanity = Convert.ToInt16(quanityTxt.Text),
                        Price = Convert.ToDecimal(priceTxt.Text),
                    };
                    listOfProducts.Add(newProduct);
                    ListViewItem lvItem = new ListViewItem(newProduct.ProductName);
                    lvItem.SubItems.Add(Convert.ToString(newProduct.Quanity));
                    lvItem.SubItems.Add(Convert.ToString(newProduct.Price));
                    productList.Items.Add(lvItem);

                }
                else
                {
                    MessageBox.Show("Uzupełnij wszystkie pola");
                }
            }
            if (open == false)
            {
                ShowPanel();
            }
        }

        private void Update()
        {
            if (productList.SelectedItems.Count > 0)
            {
                productList.SelectedItems[0].SubItems[0].Text = productNameTxt.Text;
                productList.SelectedItems[0].SubItems[1].Text = quanityTxt.Text;
                productList.SelectedItems[0].SubItems[2].Text = priceTxt.Text;

                var index = productList.Items.IndexOf(productList.SelectedItems[0]);
                listOfProducts[index].ProductName = productNameTxt.Text;
                listOfProducts[index].Quanity = Convert.ToInt16(quanityTxt.Text);
                listOfProducts[index].Price = Convert.ToDecimal(priceTxt.Text);

                ClearProductText();
            }
        }

        private void Delete()
        {
            if (productList.SelectedItems.Count > 0)
            {
                var index = productList.Items.IndexOf(productList.SelectedItems[0]);
                listOfProducts.RemoveAt(index);
                productList.Items.RemoveAt(productList.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Wybierz rekord, który chcesz usunąć");
            }
        }

        private void SaveToXml()
        {

        }

        private void SaveToDb()
        {
            if (listOfProducts.Count != 0 && nameTxt.Text != String.Empty && surnameTxt.Text != String.Empty)
            {
                var newClient = new Client
                {
                    Name = nameTxt.Text,
                    Surname = surnameTxt.Text,
                    DateOfBirth = birthDate.Value
                };

                newClient.Products = new List<Product>();

                foreach (var product in listOfProducts)
                {
                    newClient.Products.Add(product);
                }

                storeContext.Clients.Add(newClient);
                storeContext.SaveChanges();

                for (int i = listOfProducts.Count - 1; i >= 0; i--)
                {
                    productList.Items.RemoveAt(i);
                }

                listOfProducts.Clear();
                nameTxt.Text = String.Empty;
                surnameTxt.Text = String.Empty;
                HidePanel();
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
        }

        private void SelectClicked()
        {
            productNameTxt.Text = productList.SelectedItems[0].SubItems[0].Text;
            quanityTxt.Text = productList.SelectedItems[0].SubItems[1].Text;
            priceTxt.Text = productList.SelectedItems[0].SubItems[2].Text;
        }

        private void ClearProductText()
        {
            productNameTxt.Text = "";
            priceTxt.Text = "";
            quanityTxt.Text = "";
        }

        private void ShowPanel()
        {
            if (open == false)
            {
                panel3.Show();
                open = true;
            }
        }

        private void HidePanel()
        {
            if (open == true)
            {
                panel3.Hide();
                open = false;
            }
        }

        private bool IsDecimalFormat(string input)
        {
            Decimal dummy;
            return Decimal.TryParse(input, out dummy);
        }

        public Form1()
        {
            InitializeComponent();
            storeContext = new StoreDBContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HidePanel();
            ClearProductText();

        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            Delete();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveToDb();
        }

        private void productList_MouseClick_1(object sender, MouseEventArgs e)
        {
            SelectClicked();
        }

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveToXml();
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {  
            if (!IsDecimalFormat(priceTxt.Text) && priceTxt.Text != String.Empty || priceTxt.Text == "0")
            {
                MessageBox.Show("Niedozwolony znak");
                priceTxt.Text = priceTxt.Text.Remove(priceTxt.Text.Length - 1);
            }
        }

        private void quanityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void surnameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void quanityTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
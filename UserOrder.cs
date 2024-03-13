using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StroyModern
{
    public partial class UserOrder : Form
    {
        string connectionString = "Server=localhost;Port=5432;Database=ZoomirDB;User Id=postgres;Password=qwerty123";
        private decimal TotalAmount { get; set; }
        private List<Product> products;
        private Dictionary<Product, int> selectedProductsCount;
        private DbMethods dbMethods;
        public UserOrder()
        {
            dbMethods = new DbMethods();
            InitializeComponent();
        }
        public void AddProductsToLayoutPanel(List<Product> products, Dictionary<Product, int> selectedProductsCount)
        {
            this.products = products;
            this.selectedProductsCount = selectedProductsCount;
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Height = 90,
                    Width = flowLayoutPanelOrder.Width - 5,
                    BorderStyle = BorderStyle.FixedSingle,

                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile($"C:\\Users\\serzl\\Desktop\\Выходной ДЭ\\товары\\{product.Title}.jpg"),
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Location = new Point(20, 5),
                    Width = 85,
                    Height = 80,
                };
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                Label titleLabel = new Label
                {
                    Text = $"Название: \n{product.Title}",
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopLeft,
                    Location = new Point(120, 20),
                    Width = 150,
                    Height = 150,
                    Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10)
                };
                titleLabel.MouseClick += HandleRightClickOnProduct;
                Label costLabel = new Label
                {
                    Text = $"Стоимость: \n {product.Cost:C}",
                    Location = new Point(650, 20),
                    Width = 100,
                    Height = 50,
                    Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
                };

                

                Label quantityLabel = new Label
                {
                    Text = $"Количество: \n {(selectedProductsCount.ContainsKey(product) ? selectedProductsCount[product] : 0)}",
                    Location = new Point(300, 20),
                    Width = 200,
                    Height = 50,
                    Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
                };



                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(titleLabel);
                productPanel.Controls.Add(costLabel);
                productPanel.Controls.Add(quantityLabel);

                flowLayoutPanelOrder.Controls.Add(productPanel);
            }
            CalculateTotalAmount();
            totalAmountLabel.Text = $"Общая сумма заказа: {TotalAmount:C}";
        }

        private void UpdateLayoutPanel()
        {
            flowLayoutPanelOrder.Controls.Clear();
            AddProductsToLayoutPanel(products, selectedProductsCount);
            CalculateTotalAmount();
        }
        private void HandleRightClickOnProduct(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Label clickedLabel = (Label)sender;
                Product clickedProduct = products.FirstOrDefault(p => p.Title == clickedLabel.Text.Split('\n')[1].Trim());

                if (clickedProduct != null)
                {
                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem removeFromOrderMenuItem = new ToolStripMenuItem("Удалить из заказа");
                    removeFromOrderMenuItem.Click += (menuItemSender, menuItemEventArgs) =>
                    {
                        if (selectedProductsCount.ContainsKey(clickedProduct))
                        {
                            if (selectedProductsCount[clickedProduct] == 1)
                            {
                                products.Remove(clickedProduct);
                                selectedProductsCount.Remove(clickedProduct);
                            }
                            else
                            {
                                selectedProductsCount[clickedProduct]--;
                            }
                            UpdateLayoutPanel();
                        }
                    };

                    contextMenu.Items.Add(removeFromOrderMenuItem);

                    contextMenu.Show(clickedLabel, e.Location);
                }
            }
        }

        private void CalculateTotalAmount()
        {
            TotalAmount = 0;
            foreach (var product in products)
            {
                int quantity = selectedProductsCount.ContainsKey(product) ? selectedProductsCount[product] : 0;
                TotalAmount += product.Cost * quantity;
            }
        }
        private void buttonCreateOrder_Click_1(object sender, EventArgs e)
        {
            string FullName;
            string adress;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

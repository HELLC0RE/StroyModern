namespace StroyModern
{
    partial class ProductsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.showOrder = new System.Windows.Forms.Button();
            this.emailMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // flowLayoutPanelPagination
            // 
            this.flowLayoutPanelPagination.Location = new System.Drawing.Point(571, 619);
            this.flowLayoutPanelPagination.Margin = new System.Windows.Forms.Padding(680, 590, 3, 3);
            this.flowLayoutPanelPagination.Name = "flowLayoutPanelPagination";
            this.flowLayoutPanelPagination.Size = new System.Drawing.Size(190, 30);
            this.flowLayoutPanelPagination.TabIndex = 4;
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(207, 55);
            this.filterBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(167, 23);
            this.filterBox.TabIndex = 8;
            this.filterBox.Text = "Фильтрация";
            this.filterBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.filterBox_DrawItem);
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // sortBox
            // 
            this.sortBox.DropDownWidth = 189;
            this.sortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По наименованию (по возрастанию)",
            "По наименованию (по убыванию)",
            "По стоимости (по возрастанию)",
            "По стоимости (по убыванию)"});
            this.sortBox.Location = new System.Drawing.Point(24, 55);
            this.sortBox.Margin = new System.Windows.Forms.Padding(2);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(167, 23);
            this.sortBox.TabIndex = 7;
            this.sortBox.Text = "Сортировка";
            this.sortBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SortBox_DrawItem);
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.Location = new System.Drawing.Point(24, 9);
            this.searchText.Margin = new System.Windows.Forms.Padding(2);
            this.searchText.MaxLength = 200;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(350, 26);
            this.searchText.TabIndex = 6;
            this.searchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.searchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(24, 107);
            this.flowLayoutPanelProducts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(737, 500);
            this.flowLayoutPanelProducts.TabIndex = 5;
            // 
            // showOrder
            // 
            this.showOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showOrder.Location = new System.Drawing.Point(425, 26);
            this.showOrder.Name = "showOrder";
            this.showOrder.Size = new System.Drawing.Size(100, 38);
            this.showOrder.TabIndex = 10;
            this.showOrder.Text = "Показать заказ";
            this.showOrder.UseVisualStyleBackColor = true;
            this.showOrder.Click += new System.EventHandler(this.showOrder_Click);
            // 
            // emailMessage
            // 
            this.emailMessage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailMessage.Location = new System.Drawing.Point(571, 26);
            this.emailMessage.Name = "emailMessage";
            this.emailMessage.Size = new System.Drawing.Size(100, 38);
            this.emailMessage.TabIndex = 11;
            this.emailMessage.Text = "Отправить рассылку";
            this.emailMessage.UseVisualStyleBackColor = true;
            this.emailMessage.Click += new System.EventHandler(this.emailMessage_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.emailMessage);
            this.Controls.Add(this.showOrder);
            this.Controls.Add(this.flowLayoutPanelPagination);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "ProductsList";
            this.Text = "ProductsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPagination;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Button showOrder;
        private System.Windows.Forms.Button emailMessage;
    }
}
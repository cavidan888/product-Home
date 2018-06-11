namespace yourself
{
    partial class Form1
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
            this.prodcutName = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ProductsListView = new System.Windows.Forms.RichTextBox();
            this.CategorySelecter = new System.Windows.Forms.ComboBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.AddCategoryBox = new System.Windows.Forms.TextBox();
            this.categoryTwo = new System.Windows.Forms.ComboBox();
            this.ShowCatProdcut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.alphabetic = new System.Windows.Forms.RichTextBox();
            this.orderAlphabetic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodcutName
            // 
            this.prodcutName.Location = new System.Drawing.Point(8, 7);
            this.prodcutName.Name = "prodcutName";
            this.prodcutName.Size = new System.Drawing.Size(169, 20);
            this.prodcutName.TabIndex = 0;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(8, 37);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(169, 20);
            this.ProductPrice.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(69, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(102, 108);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ProductsListView
            // 
            this.ProductsListView.Location = new System.Drawing.Point(419, 4);
            this.ProductsListView.Name = "ProductsListView";
            this.ProductsListView.Size = new System.Drawing.Size(253, 159);
            this.ProductsListView.TabIndex = 5;
            this.ProductsListView.Text = "";
            // 
            // CategorySelecter
            // 
            this.CategorySelecter.FormattingEnabled = true;
            this.CategorySelecter.Location = new System.Drawing.Point(8, 67);
            this.CategorySelecter.Name = "CategorySelecter";
            this.CategorySelecter.Size = new System.Drawing.Size(169, 21);
            this.CategorySelecter.TabIndex = 6;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(73, 182);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(104, 23);
            this.AddCategoryButton.TabIndex = 7;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddCategoryBox
            // 
            this.AddCategoryBox.Location = new System.Drawing.Point(8, 156);
            this.AddCategoryBox.Name = "AddCategoryBox";
            this.AddCategoryBox.Size = new System.Drawing.Size(169, 20);
            this.AddCategoryBox.TabIndex = 8;
            // 
            // categoryTwo
            // 
            this.categoryTwo.FormattingEnabled = true;
            this.categoryTwo.Location = new System.Drawing.Point(8, 211);
            this.categoryTwo.Name = "categoryTwo";
            this.categoryTwo.Size = new System.Drawing.Size(169, 21);
            this.categoryTwo.TabIndex = 9;
            // 
            // ShowCatProdcut
            // 
            this.ShowCatProdcut.Location = new System.Drawing.Point(73, 244);
            this.ShowCatProdcut.Name = "ShowCatProdcut";
            this.ShowCatProdcut.Size = new System.Drawing.Size(104, 36);
            this.ShowCatProdcut.TabIndex = 10;
            this.ShowCatProdcut.Text = "Show Category Products";
            this.ShowCatProdcut.UseVisualStyleBackColor = true;
            this.ShowCatProdcut.Click += new System.EventHandler(this.ShowCatProdcut_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(266, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(147, 20);
            this.Search.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(302, 47);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(419, 184);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(253, 96);
            this.searchBox.TabIndex = 14;
            this.searchBox.Text = "";
            // 
            // alphabetic
            // 
            this.alphabetic.Location = new System.Drawing.Point(419, 302);
            this.alphabetic.Name = "alphabetic";
            this.alphabetic.Size = new System.Drawing.Size(253, 133);
            this.alphabetic.TabIndex = 15;
            this.alphabetic.Text = "";
            // 
            // orderAlphabetic
            // 
            this.orderAlphabetic.Location = new System.Drawing.Point(102, 355);
            this.orderAlphabetic.Name = "orderAlphabetic";
            this.orderAlphabetic.Size = new System.Drawing.Size(75, 26);
            this.orderAlphabetic.TabIndex = 16;
            this.orderAlphabetic.Text = "Alphabetic";
            this.orderAlphabetic.UseVisualStyleBackColor = true;
            this.orderAlphabetic.Click += new System.EventHandler(this.orderAlphabetic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 476);
            this.Controls.Add(this.orderAlphabetic);
            this.Controls.Add(this.alphabetic);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ShowCatProdcut);
            this.Controls.Add(this.categoryTwo);
            this.Controls.Add(this.AddCategoryBox);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategorySelecter);
            this.Controls.Add(this.ProductsListView);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.prodcutName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodcutName;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RichTextBox ProductsListView;
        private System.Windows.Forms.ComboBox CategorySelecter;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.TextBox AddCategoryBox;
        private System.Windows.Forms.ComboBox categoryTwo;
        private System.Windows.Forms.Button ShowCatProdcut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.RichTextBox alphabetic;
        private System.Windows.Forms.Button orderAlphabetic;
    }
}


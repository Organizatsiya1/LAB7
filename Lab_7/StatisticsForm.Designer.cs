namespace Lab_7
{
    partial class StatisticsForm
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
            dataGridView1 = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            OrdersNumb = new DataGridViewTextBoxColumn();
            SpentMoney = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            TypeDishes = new DataGridViewTextBoxColumn();
            FoodNumb = new DataGridViewTextBoxColumn();
            labelAllOrders = new Label();
            SortFoodByName = new Button();
            SortFoodByNumber = new Button();
            SortClientsByID = new Button();
            SortClientsByName = new Button();
            SortClientsByOrders = new Button();
            SortClientsByMoney = new Button();
            label2 = new Label();
            label3 = new Label();
            SortFoodByType = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            buttonFilterByDate = new Button();
            comboBoxFoodCategory = new ComboBox();
            labelFilterTypeDishes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, OrdersNumb, SpentMoney });
            dataGridView1.Location = new Point(519, 228);
            dataGridView1.Margin = new Padding(3, 5, 3, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(435, 441);
            dataGridView1.TabIndex = 0;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.Width = 50;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // OrdersNumb
            // 
            OrdersNumb.HeaderText = "Кол-во заказов";
            OrdersNumb.MinimumWidth = 6;
            OrdersNumb.Name = "OrdersNumb";
            OrdersNumb.Width = 80;
            // 
            // SpentMoney
            // 
            SpentMoney.HeaderText = "Потрачено";
            SpentMoney.MinimumWidth = 6;
            SpentMoney.Name = "SpentMoney";
            SpentMoney.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FoodName, TypeDishes, FoodNumb });
            dataGridView2.Location = new Point(9, 228);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(504, 441);
            dataGridView2.TabIndex = 1;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "Название";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.Width = 200;
            // 
            // TypeDishes
            // 
            TypeDishes.HeaderText = "Тип блюда";
            TypeDishes.MinimumWidth = 6;
            TypeDishes.Name = "TypeDishes";
            TypeDishes.ReadOnly = true;
            TypeDishes.Width = 150;
            // 
            // FoodNumb
            // 
            FoodNumb.HeaderText = "Кол-во заказов";
            FoodNumb.MinimumWidth = 6;
            FoodNumb.Name = "FoodNumb";
            FoodNumb.Width = 125;
            // 
            // labelAllOrders
            // 
            labelAllOrders.AutoSize = true;
            labelAllOrders.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            labelAllOrders.ForeColor = SystemColors.ControlLightLight;
            labelAllOrders.Location = new Point(27, 21);
            labelAllOrders.Name = "labelAllOrders";
            labelAllOrders.Size = new Size(0, 29);
            labelAllOrders.TabIndex = 2;
            // 
            // SortFoodByName
            // 
            SortFoodByName.BackColor = Color.FromArgb(99, 58, 52);
            SortFoodByName.Cursor = Cursors.Hand;
            SortFoodByName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortFoodByName.ForeColor = Color.White;
            SortFoodByName.Location = new Point(62, 189);
            SortFoodByName.Margin = new Padding(3, 4, 3, 4);
            SortFoodByName.Name = "SortFoodByName";
            SortFoodByName.Size = new Size(195, 31);
            SortFoodByName.TabIndex = 3;
            SortFoodByName.Text = "Названию";
            SortFoodByName.UseVisualStyleBackColor = false;
            SortFoodByName.Click += SortFoodByName_Click;
            // 
            // SortFoodByNumber
            // 
            SortFoodByNumber.BackColor = Color.FromArgb(99, 58, 52);
            SortFoodByNumber.Cursor = Cursors.Hand;
            SortFoodByNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortFoodByNumber.ForeColor = Color.White;
            SortFoodByNumber.Location = new Point(411, 190);
            SortFoodByNumber.Margin = new Padding(3, 4, 3, 4);
            SortFoodByNumber.Name = "SortFoodByNumber";
            SortFoodByNumber.Size = new Size(102, 31);
            SortFoodByNumber.TabIndex = 4;
            SortFoodByNumber.Text = "Частоте";
            SortFoodByNumber.UseVisualStyleBackColor = false;
            SortFoodByNumber.Click += SortFoodByNumber_Click;
            // 
            // SortClientsByID
            // 
            SortClientsByID.BackColor = Color.FromArgb(99, 58, 52);
            SortClientsByID.Cursor = Cursors.Hand;
            SortClientsByID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortClientsByID.ForeColor = Color.White;
            SortClientsByID.Location = new Point(568, 189);
            SortClientsByID.Margin = new Padding(3, 5, 3, 5);
            SortClientsByID.Name = "SortClientsByID";
            SortClientsByID.Size = new Size(52, 31);
            SortClientsByID.TabIndex = 5;
            SortClientsByID.Text = "ID";
            SortClientsByID.UseVisualStyleBackColor = false;
            SortClientsByID.Click += SortClientsByID_Click;
            // 
            // SortClientsByName
            // 
            SortClientsByName.BackColor = Color.FromArgb(99, 58, 52);
            SortClientsByName.Cursor = Cursors.Hand;
            SortClientsByName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortClientsByName.ForeColor = Color.White;
            SortClientsByName.Location = new Point(626, 189);
            SortClientsByName.Margin = new Padding(3, 5, 3, 5);
            SortClientsByName.Name = "SortClientsByName";
            SortClientsByName.Size = new Size(106, 31);
            SortClientsByName.TabIndex = 6;
            SortClientsByName.Text = "Имени";
            SortClientsByName.UseVisualStyleBackColor = false;
            SortClientsByName.Click += SortClientsByName_Click;
            // 
            // SortClientsByOrders
            // 
            SortClientsByOrders.BackColor = Color.FromArgb(99, 58, 52);
            SortClientsByOrders.Cursor = Cursors.Hand;
            SortClientsByOrders.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortClientsByOrders.ForeColor = Color.White;
            SortClientsByOrders.Location = new Point(738, 188);
            SortClientsByOrders.Margin = new Padding(3, 5, 3, 5);
            SortClientsByOrders.Name = "SortClientsByOrders";
            SortClientsByOrders.Size = new Size(91, 31);
            SortClientsByOrders.TabIndex = 7;
            SortClientsByOrders.Text = "Заказам";
            SortClientsByOrders.UseVisualStyleBackColor = false;
            SortClientsByOrders.Click += SortClientsByOrders_Click;
            // 
            // SortClientsByMoney
            // 
            SortClientsByMoney.BackColor = Color.FromArgb(99, 58, 52);
            SortClientsByMoney.Cursor = Cursors.Hand;
            SortClientsByMoney.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortClientsByMoney.ForeColor = Color.White;
            SortClientsByMoney.Location = new Point(835, 188);
            SortClientsByMoney.Margin = new Padding(3, 5, 3, 5);
            SortClientsByMoney.Name = "SortClientsByMoney";
            SortClientsByMoney.Size = new Size(119, 32);
            SortClientsByMoney.TabIndex = 8;
            SortClientsByMoney.Text = "Потраченным";
            SortClientsByMoney.UseVisualStyleBackColor = false;
            SortClientsByMoney.Click += SortClientsByMoney_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(165, 147);
            label2.Name = "label2";
            label2.Size = new Size(209, 29);
            label2.TabIndex = 9;
            label2.Text = "Сортировать по";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(635, 137);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 10;
            label3.Text = "Сортировать по";
            // 
            // SortFoodByType
            // 
            SortFoodByType.BackColor = Color.FromArgb(99, 58, 52);
            SortFoodByType.Cursor = Cursors.Hand;
            SortFoodByType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SortFoodByType.ForeColor = Color.White;
            SortFoodByType.Location = new Point(263, 189);
            SortFoodByType.Margin = new Padding(3, 4, 3, 4);
            SortFoodByType.Name = "SortFoodByType";
            SortFoodByType.Size = new Size(142, 31);
            SortFoodByType.TabIndex = 11;
            SortFoodByType.Text = "Типу блюда";
            SortFoodByType.UseVisualStyleBackColor = false;
            SortFoodByType.Click += SortFoodByType_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Cursor = Cursors.Hand;
            dateTimePickerFrom.Location = new Point(746, 60);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(180, 27);
            dateTimePickerFrom.TabIndex = 12;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Cursor = Cursors.Hand;
            dateTimePickerTo.Location = new Point(746, 90);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(180, 27);
            dateTimePickerTo.TabIndex = 13;
            // 
            // buttonFilterByDate
            // 
            buttonFilterByDate.BackColor = Color.FromArgb(99, 58, 52);
            buttonFilterByDate.Cursor = Cursors.Hand;
            buttonFilterByDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonFilterByDate.ForeColor = Color.White;
            buttonFilterByDate.Location = new Point(561, 60);
            buttonFilterByDate.Name = "buttonFilterByDate";
            buttonFilterByDate.Size = new Size(166, 57);
            buttonFilterByDate.TabIndex = 14;
            buttonFilterByDate.Text = "Фильтровать по дате";
            buttonFilterByDate.UseVisualStyleBackColor = false;
            buttonFilterByDate.Click += buttonFilterByDate_Click;
            // 
            // comboBoxFoodCategory
            // 
            comboBoxFoodCategory.FormattingEnabled = true;
            comboBoxFoodCategory.Items.AddRange(new object[] { "Все", "Аперитив", "Антре", "Основное блюдо", "Антреме", "Десерт", "Дижестив" });
            comboBoxFoodCategory.Location = new Point(300, 89);
            comboBoxFoodCategory.Name = "comboBoxFoodCategory";
            comboBoxFoodCategory.Size = new Size(213, 28);
            comboBoxFoodCategory.TabIndex = 15;
            comboBoxFoodCategory.SelectedIndexChanged += comboBoxFoodCategory_SelectedIndexChanged;
            // 
            // labelFilterTypeDishes
            // 
            labelFilterTypeDishes.AutoSize = true;
            labelFilterTypeDishes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFilterTypeDishes.ForeColor = Color.White;
            labelFilterTypeDishes.Location = new Point(9, 85);
            labelFilterTypeDishes.Name = "labelFilterTypeDishes";
            labelFilterTypeDishes.Size = new Size(287, 28);
            labelFilterTypeDishes.TabIndex = 16;
            labelFilterTypeDishes.Text = "Фильтровать по типу блюда:";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(966, 683);
            Controls.Add(labelFilterTypeDishes);
            Controls.Add(comboBoxFoodCategory);
            Controls.Add(buttonFilterByDate);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(SortFoodByType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SortClientsByMoney);
            Controls.Add(SortClientsByOrders);
            Controls.Add(SortClientsByName);
            Controls.Add(SortClientsByID);
            Controls.Add(SortFoodByNumber);
            Controls.Add(SortFoodByName);
            Controls.Add(labelAllOrders);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn OrdersNumb;
        private DataGridViewTextBoxColumn SpentMoney;
        private Label labelAllOrders;
        private Button SortFoodByName;
        private Button SortFoodByNumber;
        private Button SortClientsByID;
        private Button SortClientsByName;
        private Button SortClientsByOrders;
        private Button SortClientsByMoney;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn TypeDishes;
        private DataGridViewTextBoxColumn FoodNumb;
        private Button SortFoodByType;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonFilterByDate;
        private ComboBox comboBoxFoodCategory;
        private Label labelFilterTypeDishes;
    }
}
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
            dataGridView2 = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            FoodNumb = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            OrdersNumb = new DataGridViewTextBoxColumn();
            SpentMoney = new DataGridViewTextBoxColumn();
            label1 = new Label();
            SortFoodByName = new Button();
            SortFoodByNumber = new Button();
            SortClientsByID = new Button();
            SortClientsByName = new Button();
            SortClientsByOrders = new Button();
            SortClientsByMoney = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, OrdersNumb, SpentMoney });
            dataGridView1.Location = new Point(415, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(373, 331);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FoodName, FoodNumb });
            dataGridView2.Location = new Point(24, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(343, 331);
            dataGridView2.TabIndex = 1;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "Название";
            FoodName.Name = "FoodName";
            FoodName.Width = 150;
            // 
            // FoodNumb
            // 
            FoodNumb.HeaderText = "Кол-во заказов";
            FoodNumb.Name = "FoodNumb";
            FoodNumb.Width = 150;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.Name = "IDColumn";
            IDColumn.Width = 50;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.Name = "NameColumn";
            // 
            // OrdersNumb
            // 
            OrdersNumb.HeaderText = "Кол-во заказов";
            OrdersNumb.Name = "OrdersNumb";
            OrdersNumb.Width = 80;
            // 
            // SpentMoney
            // 
            SpentMoney.HeaderText = "Потрачено";
            SpentMoney.Name = "SpentMoney";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 2;
            label1.Text = "Всего заказов:";
            // 
            // SortFoodByName
            // 
            SortFoodByName.Location = new Point(76, 73);
            SortFoodByName.Name = "SortFoodByName";
            SortFoodByName.Size = new Size(126, 24);
            SortFoodByName.TabIndex = 3;
            SortFoodByName.Text = "Названию";
            SortFoodByName.UseVisualStyleBackColor = true;
            SortFoodByName.Click += SortFoodByName_Click;
            // 
            // SortFoodByNumber
            // 
            SortFoodByNumber.Location = new Point(233, 74);
            SortFoodByNumber.Name = "SortFoodByNumber";
            SortFoodByNumber.Size = new Size(123, 23);
            SortFoodByNumber.TabIndex = 4;
            SortFoodByNumber.Text = "Чатсоте";
            SortFoodByNumber.UseVisualStyleBackColor = true;
            // 
            // SortClientsByID
            // 
            SortClientsByID.Location = new Point(455, 74);
            SortClientsByID.Name = "SortClientsByID";
            SortClientsByID.Size = new Size(51, 23);
            SortClientsByID.TabIndex = 5;
            SortClientsByID.Text = "ID";
            SortClientsByID.UseVisualStyleBackColor = true;
            // 
            // SortClientsByName
            // 
            SortClientsByName.Location = new Point(521, 74);
            SortClientsByName.Name = "SortClientsByName";
            SortClientsByName.Size = new Size(75, 23);
            SortClientsByName.TabIndex = 6;
            SortClientsByName.Text = "Имени";
            SortClientsByName.UseVisualStyleBackColor = true;
            // 
            // SortClientsByOrders
            // 
            SortClientsByOrders.Location = new Point(613, 74);
            SortClientsByOrders.Name = "SortClientsByOrders";
            SortClientsByOrders.Size = new Size(64, 23);
            SortClientsByOrders.TabIndex = 7;
            SortClientsByOrders.Text = "Заказам";
            SortClientsByOrders.UseVisualStyleBackColor = true;
            // 
            // SortClientsByMoney
            // 
            SortClientsByMoney.Location = new Point(683, 74);
            SortClientsByMoney.Name = "SortClientsByMoney";
            SortClientsByMoney.Size = new Size(103, 23);
            SortClientsByMoney.TabIndex = 8;
            SortClientsByMoney.Text = "Потраченным";
            SortClientsByMoney.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 55);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 9;
            label2.Text = "Сортировать по";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 55);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 10;
            label3.Text = "Сортировать по";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SortClientsByMoney);
            Controls.Add(SortClientsByOrders);
            Controls.Add(SortClientsByName);
            Controls.Add(SortClientsByID);
            Controls.Add(SortFoodByNumber);
            Controls.Add(SortFoodByName);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn FoodNumb;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn OrdersNumb;
        private DataGridViewTextBoxColumn SpentMoney;
        private Label label1;
        private Button SortFoodByName;
        private Button SortFoodByNumber;
        private Button SortClientsByID;
        private Button SortClientsByName;
        private Button SortClientsByOrders;
        private Button SortClientsByMoney;
        private Label label2;
        private Label label3;
    }
}
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
            FoodNumb = new DataGridViewTextBoxColumn();
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
            dataGridView1.Location = new Point(474, 143);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(426, 441);
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { FoodName, FoodNumb });
            dataGridView2.Location = new Point(27, 143);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(392, 441);
            dataGridView2.TabIndex = 1;
            // 
            // FoodName
            // 
            FoodName.HeaderText = "Название";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.Width = 150;
            // 
            // FoodNumb
            // 
            FoodNumb.HeaderText = "Кол-во заказов";
            FoodNumb.MinimumWidth = 6;
            FoodNumb.Name = "FoodNumb";
            FoodNumb.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(195, 29);
            label1.TabIndex = 2;
            label1.Text = "Всего заказов:";
            // 
            // SortFoodByName
            // 
            SortFoodByName.Location = new Point(78, 99);
            SortFoodByName.Margin = new Padding(3, 4, 3, 4);
            SortFoodByName.Name = "SortFoodByName";
            SortFoodByName.Size = new Size(144, 32);
            SortFoodByName.TabIndex = 3;
            SortFoodByName.Text = "Названию";
            SortFoodByName.UseVisualStyleBackColor = true;
            SortFoodByName.Click += SortFoodByName_Click;
            // 
            // SortFoodByNumber
            // 
            SortFoodByNumber.Location = new Point(228, 99);
            SortFoodByNumber.Margin = new Padding(3, 4, 3, 4);
            SortFoodByNumber.Name = "SortFoodByNumber";
            SortFoodByNumber.Size = new Size(153, 31);
            SortFoodByNumber.TabIndex = 4;
            SortFoodByNumber.Text = "Чатсоте";
            SortFoodByNumber.UseVisualStyleBackColor = true;
            // 
            // SortClientsByID
            // 
            SortClientsByID.Location = new Point(520, 99);
            SortClientsByID.Margin = new Padding(3, 4, 3, 4);
            SortClientsByID.Name = "SortClientsByID";
            SortClientsByID.Size = new Size(58, 31);
            SortClientsByID.TabIndex = 5;
            SortClientsByID.Text = "ID";
            SortClientsByID.UseVisualStyleBackColor = true;
            // 
            // SortClientsByName
            // 
            SortClientsByName.Location = new Point(584, 99);
            SortClientsByName.Margin = new Padding(3, 4, 3, 4);
            SortClientsByName.Name = "SortClientsByName";
            SortClientsByName.Size = new Size(111, 31);
            SortClientsByName.TabIndex = 6;
            SortClientsByName.Text = "Имени";
            SortClientsByName.UseVisualStyleBackColor = true;
            // 
            // SortClientsByOrders
            // 
            SortClientsByOrders.Location = new Point(701, 99);
            SortClientsByOrders.Margin = new Padding(3, 4, 3, 4);
            SortClientsByOrders.Name = "SortClientsByOrders";
            SortClientsByOrders.Size = new Size(80, 31);
            SortClientsByOrders.TabIndex = 7;
            SortClientsByOrders.Text = "Заказам";
            SortClientsByOrders.UseVisualStyleBackColor = true;
            // 
            // SortClientsByMoney
            // 
            SortClientsByMoney.Location = new Point(787, 99);
            SortClientsByMoney.Margin = new Padding(3, 4, 3, 4);
            SortClientsByMoney.Name = "SortClientsByMoney";
            SortClientsByMoney.Size = new Size(112, 31);
            SortClientsByMoney.TabIndex = 8;
            SortClientsByMoney.Text = "Потраченным";
            SortClientsByMoney.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(108, 52);
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
            label3.Location = new Point(584, 52);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 10;
            label3.Text = "Сортировать по";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(914, 600);
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
namespace Lab_7
{
    partial class Order
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
            Food = new DataGridViewTextBoxColumn();
            label1 = new Label();
            OrderIDLabe = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DateLabe = new Label();
            TypeLabe = new Label();
            CostLabe = new Label();
            BehaviourLabe = new Label();
            PayementLabe = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Food });
            dataGridView1.Location = new Point(278, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 307);
            dataGridView1.TabIndex = 0;
            // 
            // Food
            // 
            Food.HeaderText = "Блюда";
            Food.Name = "Food";
            Food.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 1;
            label1.Text = "Заказ";
            // 
            // OrderIDLabe
            // 
            OrderIDLabe.AutoSize = true;
            OrderIDLabe.Font = new Font("Segoe UI", 20F);
            OrderIDLabe.Location = new Point(278, 9);
            OrderIDLabe.Name = "OrderIDLabe";
            OrderIDLabe.Size = new Size(49, 37);
            OrderIDLabe.TabIndex = 2;
            OrderIDLabe.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(39, 134);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 3;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(47, 190);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 4;
            label3.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 5;
            label4.Text = "Стоимость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(2, 320);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 6;
            label5.Text = "Статус оплаты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(39, 281);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 7;
            label6.Text = "Статус";
            // 
            // DateLabe
            // 
            DateLabe.AutoSize = true;
            DateLabe.Font = new Font("Segoe UI", 15F);
            DateLabe.Location = new Point(147, 134);
            DateLabe.Name = "DateLabe";
            DateLabe.Size = new Size(65, 28);
            DateLabe.TabIndex = 8;
            DateLabe.Text = "label7";
            // 
            // TypeLabe
            // 
            TypeLabe.AutoSize = true;
            TypeLabe.Font = new Font("Segoe UI", 15F);
            TypeLabe.Location = new Point(147, 190);
            TypeLabe.Name = "TypeLabe";
            TypeLabe.Size = new Size(65, 28);
            TypeLabe.TabIndex = 9;
            TypeLabe.Text = "label7";
            // 
            // CostLabe
            // 
            CostLabe.AutoSize = true;
            CostLabe.Font = new Font("Segoe UI", 15F);
            CostLabe.Location = new Point(147, 239);
            CostLabe.Name = "CostLabe";
            CostLabe.Size = new Size(65, 28);
            CostLabe.TabIndex = 10;
            CostLabe.Text = "label7";
            // 
            // BehaviourLabe
            // 
            BehaviourLabe.AutoSize = true;
            BehaviourLabe.Font = new Font("Segoe UI", 15F);
            BehaviourLabe.Location = new Point(147, 281);
            BehaviourLabe.Name = "BehaviourLabe";
            BehaviourLabe.Size = new Size(65, 28);
            BehaviourLabe.TabIndex = 11;
            BehaviourLabe.Text = "label7";
            // 
            // PayementLabe
            // 
            PayementLabe.AutoSize = true;
            PayementLabe.Font = new Font("Segoe UI", 15F);
            PayementLabe.Location = new Point(147, 320);
            PayementLabe.Name = "PayementLabe";
            PayementLabe.Size = new Size(65, 28);
            PayementLabe.TabIndex = 12;
            PayementLabe.Text = "label7";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(PayementLabe);
            Controls.Add(BehaviourLabe);
            Controls.Add(CostLabe);
            Controls.Add(TypeLabe);
            Controls.Add(DateLabe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OrderIDLabe);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Food;
        private Label label1;
        private Label OrderIDLabe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label DateLabe;
        private Label TypeLabe;
        private Label CostLabe;
        private Label BehaviourLabe;
        private Label PayementLabe;
    }
}
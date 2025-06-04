namespace Lab_7
{
    partial class Profile
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OrdersGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            PhoneBox = new TextBox();
            StreetBox = new TextBox();
            HouseBox = new TextBox();
            FlatBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 0;
            label1.Text = "Профиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(57, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 37);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(42, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 37);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 3;
            label4.Text = "Телефон";
            // 
            // OrdersGrid
            // 
            OrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGrid.Columns.AddRange(new DataGridViewColumn[] { ID });
            OrdersGrid.Location = new Point(312, 117);
            OrdersGrid.Name = "OrdersGrid";
            OrdersGrid.Size = new Size(145, 272);
            OrdersGrid.TabIndex = 4;
            
            // 
            // ID
            // 
            ID.HeaderText = "ID заказа";
            ID.Name = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(335, 77);
            label5.Name = "label5";
            label5.Size = new Size(104, 37);
            label5.TabIndex = 5;
            label5.Text = "Заказы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(32, 258);
            label6.Name = "label6";
            label6.Size = new Size(91, 37);
            label6.TabIndex = 6;
            label6.Text = "Адрес";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(35, 310);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 7;
            label7.Text = "Улица";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(48, 348);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 8;
            label8.Text = "Дом";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 382);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 9;
            label9.Text = "Квартира";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(142, 92);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(100, 23);
            IDBox.TabIndex = 10;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(142, 147);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 11;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(142, 211);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(100, 23);
            PhoneBox.TabIndex = 12;
            // 
            // StreetBox
            // 
            StreetBox.Location = new Point(95, 310);
            StreetBox.Name = "StreetBox";
            StreetBox.Size = new Size(100, 23);
            StreetBox.TabIndex = 13;
            // 
            // HouseBox
            // 
            HouseBox.Location = new Point(95, 346);
            HouseBox.Name = "HouseBox";
            HouseBox.Size = new Size(100, 23);
            HouseBox.TabIndex = 14;
            // 
            // FlatBox
            // 
            FlatBox.Location = new Point(95, 384);
            FlatBox.Name = "FlatBox";
            FlatBox.Size = new Size(100, 23);
            FlatBox.TabIndex = 15;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(FlatBox);
            Controls.Add(HouseBox);
            Controls.Add(StreetBox);
            Controls.Add(PhoneBox);
            Controls.Add(NameBox);
            Controls.Add(IDBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(OrdersGrid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView OrdersGrid;
        private DataGridViewTextBoxColumn ID;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox IDBox;
        private TextBox NameBox;
        private TextBox PhoneBox;
        private TextBox StreetBox;
        private TextBox HouseBox;
        private TextBox FlatBox;
    }
}
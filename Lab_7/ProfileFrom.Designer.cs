namespace Lab_7
{
    partial class ProfileFrom
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(26, 69);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 0;
            label1.Text = "Профиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(204, 74);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(204, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(201, 150);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Телефон";
            // 
            // OrdersGrid
            // 
            OrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGrid.Columns.AddRange(new DataGridViewColumn[] { ID });
            OrdersGrid.Location = new Point(656, 13);
            OrdersGrid.Margin = new Padding(3, 4, 3, 4);
            OrdersGrid.Name = "OrdersGrid";
            OrdersGrid.RowHeadersWidth = 51;
            OrdersGrid.Size = new Size(206, 333);
            OrdersGrid.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID заказа";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(263, 22);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 5;
            label5.Text = "Заказы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(263, 196);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 6;
            label6.Text = "Адрес";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(208, 243);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 7;
            label7.Text = "Улица";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(204, 283);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 8;
            label8.Text = "Дом";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(207, 321);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 9;
            label9.Text = "Квартира";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            IDBox.ForeColor = SystemColors.ControlLightLight;
            IDBox.Location = new Point(384, 71);
            IDBox.Margin = new Padding(3, 4, 3, 4);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(251, 30);
            IDBox.TabIndex = 10;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            NameBox.ForeColor = SystemColors.ControlLightLight;
            NameBox.Location = new Point(384, 109);
            NameBox.Margin = new Padding(3, 4, 3, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(251, 30);
            NameBox.TabIndex = 11;
            // 
            // PhoneBox
            // 
            PhoneBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            PhoneBox.ForeColor = SystemColors.ControlLightLight;
            PhoneBox.Location = new Point(384, 147);
            PhoneBox.Margin = new Padding(3, 4, 3, 4);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(156, 30);
            PhoneBox.TabIndex = 12;
            // 
            // StreetBox
            // 
            StreetBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            StreetBox.ForeColor = SystemColors.ControlLightLight;
            StreetBox.Location = new Point(368, 240);
            StreetBox.Margin = new Padding(3, 4, 3, 4);
            StreetBox.Name = "StreetBox";
            StreetBox.Size = new Size(225, 30);
            StreetBox.TabIndex = 13;
            // 
            // HouseBox
            // 
            HouseBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            HouseBox.ForeColor = SystemColors.ControlLightLight;
            HouseBox.Location = new Point(368, 278);
            HouseBox.Margin = new Padding(3, 4, 3, 4);
            HouseBox.Name = "HouseBox";
            HouseBox.Size = new Size(114, 30);
            HouseBox.TabIndex = 14;
            // 
            // FlatBox
            // 
            FlatBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            FlatBox.ForeColor = SystemColors.ControlLightLight;
            FlatBox.Location = new Point(368, 316);
            FlatBox.Margin = new Padding(3, 4, 3, 4);
            FlatBox.Name = "FlatBox";
            FlatBox.Size = new Size(114, 30);
            FlatBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(12, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // ProfileFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(871, 357);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfileFrom";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
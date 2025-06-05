namespace Lab_7
{
    partial class ProfileForm
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
            StreetBox = new TextBox();
            HouseBox = new TextBox();
            FlatBox = new TextBox();
            PhoneBox = new MaskedTextBox();
            SaveProfile = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(178, 12);
            label1.Name = "label1";
            label1.Size = new Size(201, 57);
            label1.TabIndex = 0;
            label1.Text = "Профиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 212);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(14, 169);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(14, 255);
            label4.Name = "label4";
            label4.Size = new Size(141, 32);
            label4.TabIndex = 3;
            label4.Text = "Телефон";
            // 
            // OrdersGrid
            // 
            OrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGrid.Columns.AddRange(new DataGridViewColumn[] { ID });
            OrdersGrid.Location = new Point(357, 140);
            OrdersGrid.Margin = new Padding(3, 4, 3, 4);
            OrdersGrid.Name = "OrdersGrid";
            OrdersGrid.RowHeadersWidth = 51;
            OrdersGrid.Size = new Size(210, 363);
            OrdersGrid.TabIndex = 4;
            OrdersGrid.CellDoubleClick += OrdersGrid_CellDoubleClick;
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
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(383, 87);
            label5.Name = "label5";
            label5.Size = new Size(128, 46);
            label5.TabIndex = 5;
            label5.Text = "Заказы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(115, 315);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 6;
            label6.Text = "Адрес";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(14, 380);
            label7.Name = "label7";
            label7.Size = new Size(89, 29);
            label7.TabIndex = 7;
            label7.Text = "Улица";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(14, 425);
            label8.Name = "label8";
            label8.Size = new Size(70, 29);
            label8.TabIndex = 8;
            label8.Text = "Дом";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(14, 474);
            label9.Name = "label9";
            label9.Size = new Size(130, 29);
            label9.TabIndex = 9;
            label9.Text = "Квартира";
            // 
            // IDBox
            // 
            IDBox.ForeColor = SystemColors.ControlLightLight;
            IDBox.Location = new Point(178, 176);
            IDBox.Margin = new Padding(3, 4, 3, 4);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(162, 27);
            IDBox.TabIndex = 10;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(178, 217);
            NameBox.Margin = new Padding(3, 4, 3, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(162, 27);
            NameBox.TabIndex = 11;
            // 
            // StreetBox
            // 
            StreetBox.Location = new Point(178, 384);
            StreetBox.Margin = new Padding(3, 4, 3, 4);
            StreetBox.Name = "StreetBox";
            StreetBox.Size = new Size(162, 27);
            StreetBox.TabIndex = 13;
            // 
            // HouseBox
            // 
            HouseBox.Location = new Point(178, 429);
            HouseBox.Margin = new Padding(3, 4, 3, 4);
            HouseBox.Name = "HouseBox";
            HouseBox.Size = new Size(162, 27);
            HouseBox.TabIndex = 14;
            // 
            // FlatBox
            // 
            FlatBox.Location = new Point(178, 476);
            FlatBox.Margin = new Padding(3, 4, 3, 4);
            FlatBox.Name = "FlatBox";
            FlatBox.Size = new Size(162, 27);
            FlatBox.TabIndex = 15;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(213, 260);
            PhoneBox.Margin = new Padding(3, 4, 3, 4);
            PhoneBox.Mask = "(999) 000-0000";
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(127, 27);
            PhoneBox.TabIndex = 16;
            // 
            // SaveProfile
            // 
            SaveProfile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveProfile.Location = new Point(383, 526);
            SaveProfile.Margin = new Padding(3, 4, 3, 4);
            SaveProfile.Name = "SaveProfile";
            SaveProfile.Size = new Size(134, 43);
            SaveProfile.TabIndex = 17;
            SaveProfile.Text = "Сохранить";
            SaveProfile.UseVisualStyleBackColor = true;
            SaveProfile.Click += SaveProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(579, 600);
            Controls.Add(pictureBox1);
            Controls.Add(SaveProfile);
            Controls.Add(PhoneBox);
            Controls.Add(FlatBox);
            Controls.Add(HouseBox);
            Controls.Add(StreetBox);
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
            Name = "ProfileForm";
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
        private TextBox StreetBox;
        private TextBox HouseBox;
        private TextBox FlatBox;
        private MaskedTextBox PhoneBox;
        private Button SaveProfile;
        private PictureBox pictureBox1;
    }
}
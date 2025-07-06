namespace Lab_7
{
    partial class OrderForClientForm
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
            listViewCart = new ListView();
            columnHeaderNameDishes = new ColumnHeader();
            columnHeaderCount = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            lblCart = new Label();
            lblOrderCost = new Label();
            lblDeliveryCost = new Label();
            lblTotalCost = new Label();
            lblDeliveryType = new Label();
            cbDeliveryType = new ComboBox();
            gbRecipient = new GroupBox();
            rbSelf = new RadioButton();
            rbOther = new RadioButton();
            lblStreet = new Label();
            tbStreet = new TextBox();
            lblHouse = new Label();
            tbHouse = new TextBox();
            lblApartment = new Label();
            tbApartment = new TextBox();
            lblRecipientName = new Label();
            tbRecipientName = new TextBox();
            lblRecipientPhone = new Label();
            tbRecipientPhone = new TextBox();
            lblPaymentType = new Label();
            cbPaymentType = new ComboBox();
            lblComments = new Label();
            tbComments = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            gbRecipient.SuspendLayout();
            SuspendLayout();
            // 
            // listViewCart
            // 
            listViewCart.BackColor = Color.FromArgb(234, 215, 209);
            listViewCart.Columns.AddRange(new ColumnHeader[] { columnHeaderNameDishes, columnHeaderCount, columnHeaderPrice });
            listViewCart.FullRowSelect = true;
            listViewCart.GridLines = true;
            listViewCart.Location = new Point(16, 40);
            listViewCart.Name = "listViewCart";
            listViewCart.Size = new Size(360, 237);
            listViewCart.TabIndex = 1;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = View.Details;
            listViewCart.DoubleClick += listViewCart_DoubleClick;
            // 
            // columnHeaderNameDishes
            // 
            columnHeaderNameDishes.Text = "Название блюда";
            columnHeaderNameDishes.Width = 170;
            // 
            // columnHeaderCount
            // 
            columnHeaderCount.Text = "Кол-во";
            columnHeaderCount.Width = 80;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Сумма";
            columnHeaderPrice.Width = 100;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(16, 9);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(84, 25);
            lblCart.TabIndex = 3;
            lblCart.Text = "Корзина";
            // 
            // lblOrderCost
            // 
            lblOrderCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrderCost.ForeColor = Color.White;
            lblOrderCost.Location = new Point(390, 40);
            lblOrderCost.Name = "lblOrderCost";
            lblOrderCost.Size = new Size(290, 23);
            lblOrderCost.TabIndex = 4;
            lblOrderCost.Text = "Стоимость заказа:";
            // 
            // lblDeliveryCost
            // 
            lblDeliveryCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeliveryCost.ForeColor = Color.White;
            lblDeliveryCost.Location = new Point(390, 70);
            lblDeliveryCost.Name = "lblDeliveryCost";
            lblDeliveryCost.Size = new Size(290, 23);
            lblDeliveryCost.TabIndex = 5;
            lblDeliveryCost.Text = "Стоимость доставки:";
            // 
            // lblTotalCost
            // 
            lblTotalCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalCost.ForeColor = Color.White;
            lblTotalCost.Location = new Point(390, 100);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(290, 25);
            lblTotalCost.TabIndex = 6;
            lblTotalCost.Text = "Итоговая сумма:";
            // 
            // lblDeliveryType
            // 
            lblDeliveryType.AutoSize = true;
            lblDeliveryType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDeliveryType.ForeColor = Color.White;
            lblDeliveryType.Location = new Point(390, 140);
            lblDeliveryType.Name = "lblDeliveryType";
            lblDeliveryType.Size = new Size(128, 25);
            lblDeliveryType.TabIndex = 7;
            lblDeliveryType.Text = "Тип доставки:";
            // 
            // cbDeliveryType
            // 
            cbDeliveryType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeliveryType.FormattingEnabled = true;
            cbDeliveryType.Items.AddRange(new object[] { "Самовывоз", "Доставка" });
            cbDeliveryType.Location = new Point(524, 137);
            cbDeliveryType.Name = "cbDeliveryType";
            cbDeliveryType.Size = new Size(156, 28);
            cbDeliveryType.TabIndex = 8;
            // 
            // gbRecipient
            // 
            gbRecipient.Controls.Add(rbSelf);
            gbRecipient.Controls.Add(rbOther);
            gbRecipient.ForeColor = Color.White;
            gbRecipient.Location = new Point(390, 180);
            gbRecipient.Name = "gbRecipient";
            gbRecipient.Size = new Size(290, 50);
            gbRecipient.TabIndex = 9;
            gbRecipient.TabStop = false;
            gbRecipient.Text = "Получатель";
            // 
            // rbSelf
            // 
            rbSelf.AutoSize = true;
            rbSelf.Checked = true;
            rbSelf.ForeColor = Color.White;
            rbSelf.Location = new Point(15, 22);
            rbSelf.Name = "rbSelf";
            rbSelf.Size = new Size(64, 24);
            rbSelf.TabIndex = 0;
            rbSelf.TabStop = true;
            rbSelf.Text = "Себе";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.ForeColor = Color.White;
            rbOther.Location = new Point(139, 20);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(89, 24);
            rbOther.TabIndex = 1;
            rbOther.Text = "Другому";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblStreet.ForeColor = Color.White;
            lblStreet.Location = new Point(390, 297);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(62, 23);
            lblStreet.TabIndex = 10;
            lblStreet.Text = "Улица:";
            // 
            // tbStreet
            // 
            tbStreet.Location = new Point(468, 294);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(212, 27);
            tbStreet.TabIndex = 11;
            // 
            // lblHouse
            // 
            lblHouse.AutoSize = true;
            lblHouse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblHouse.ForeColor = Color.White;
            lblHouse.Location = new Point(390, 332);
            lblHouse.Name = "lblHouse";
            lblHouse.Size = new Size(49, 23);
            lblHouse.TabIndex = 12;
            lblHouse.Text = "Дом:";
            // 
            // tbHouse
            // 
            tbHouse.Location = new Point(468, 329);
            tbHouse.Name = "tbHouse";
            tbHouse.Size = new Size(52, 27);
            tbHouse.TabIndex = 13;
            // 
            // lblApartment
            // 
            lblApartment.AutoSize = true;
            lblApartment.ForeColor = Color.White;
            lblApartment.Location = new Point(540, 332);
            lblApartment.Name = "lblApartment";
            lblApartment.Size = new Size(78, 20);
            lblApartment.TabIndex = 14;
            lblApartment.Text = "Квартира:";
            // 
            // tbApartment
            // 
            tbApartment.Location = new Point(620, 329);
            tbApartment.Name = "tbApartment";
            tbApartment.Size = new Size(60, 27);
            tbApartment.TabIndex = 15;
            // 
            // lblRecipientName
            // 
            lblRecipientName.AutoSize = true;
            lblRecipientName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblRecipientName.ForeColor = Color.White;
            lblRecipientName.Location = new Point(390, 367);
            lblRecipientName.Name = "lblRecipientName";
            lblRecipientName.Size = new Size(49, 23);
            lblRecipientName.TabIndex = 16;
            lblRecipientName.Text = "Имя:";
            // 
            // tbRecipientName
            // 
            tbRecipientName.Location = new Point(468, 364);
            tbRecipientName.Name = "tbRecipientName";
            tbRecipientName.Size = new Size(212, 27);
            tbRecipientName.TabIndex = 17;
            // 
            // lblRecipientPhone
            // 
            lblRecipientPhone.AutoSize = true;
            lblRecipientPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblRecipientPhone.ForeColor = Color.White;
            lblRecipientPhone.Location = new Point(390, 402);
            lblRecipientPhone.Name = "lblRecipientPhone";
            lblRecipientPhone.Size = new Size(81, 23);
            lblRecipientPhone.TabIndex = 18;
            lblRecipientPhone.Text = "Телефон:";
            // 
            // tbRecipientPhone
            // 
            tbRecipientPhone.Location = new Point(524, 399);
            tbRecipientPhone.Name = "tbRecipientPhone";
            tbRecipientPhone.Size = new Size(156, 27);
            tbRecipientPhone.TabIndex = 19;
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPaymentType.ForeColor = Color.White;
            lblPaymentType.Location = new Point(390, 254);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(108, 23);
            lblPaymentType.TabIndex = 20;
            lblPaymentType.Text = "Вид оплаты:";
            // 
            // cbPaymentType
            // 
            cbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentType.FormattingEnabled = true;
            cbPaymentType.Items.AddRange(new object[] { "Наличные", "Карта", "QR‑код", "Биометрия" });
            cbPaymentType.Location = new Point(560, 246);
            cbPaymentType.Name = "cbPaymentType";
            cbPaymentType.Size = new Size(120, 28);
            cbPaymentType.TabIndex = 21;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblComments.ForeColor = Color.White;
            lblComments.Location = new Point(16, 291);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(135, 25);
            lblComments.TabIndex = 22;
            lblComments.Text = "Комментарий:";
            // 
            // tbComments
            // 
            tbComments.Location = new Point(16, 319);
            tbComments.Multiline = true;
            tbComments.Name = "tbComments";
            tbComments.Size = new Size(360, 68);
            tbComments.TabIndex = 23;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(99, 58, 52);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(16, 399);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(185, 32);
            btnConfirm.TabIndex = 24;
            btnConfirm.Text = "Подтвердить";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DimGray;
            btnBack.Cursor = Cursors.Hand;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(207, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 32);
            btnBack.TabIndex = 25;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // OrderForClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(707, 438);
            Controls.Add(listViewCart);
            Controls.Add(lblCart);
            Controls.Add(lblOrderCost);
            Controls.Add(lblDeliveryCost);
            Controls.Add(lblTotalCost);
            Controls.Add(lblDeliveryType);
            Controls.Add(cbDeliveryType);
            Controls.Add(gbRecipient);
            Controls.Add(lblStreet);
            Controls.Add(tbStreet);
            Controls.Add(lblHouse);
            Controls.Add(tbHouse);
            Controls.Add(lblApartment);
            Controls.Add(tbApartment);
            Controls.Add(lblRecipientName);
            Controls.Add(tbRecipientName);
            Controls.Add(lblRecipientPhone);
            Controls.Add(tbRecipientPhone);
            Controls.Add(lblPaymentType);
            Controls.Add(cbPaymentType);
            Controls.Add(lblComments);
            Controls.Add(tbComments);
            Controls.Add(btnConfirm);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrderForClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформление заказа";
            gbRecipient.ResumeLayout(false);
            gbRecipient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewCart;
        private Label lblCart;
        private Label lblOrderCost;
        private Label lblDeliveryCost;
        private Label lblTotalCost;
        private Label lblDeliveryType;
        private ComboBox cbDeliveryType;
        private GroupBox gbRecipient;
        private RadioButton rbSelf;
        private RadioButton rbOther;
        private Label lblStreet;
        private TextBox tbStreet;
        private Label lblHouse;
        private TextBox tbHouse;
        private Label lblApartment;
        private TextBox tbApartment;
        private Label lblRecipientName;
        private TextBox tbRecipientName;
        private Label lblRecipientPhone;
        private TextBox tbRecipientPhone;
        private Label lblPaymentType;
        private ComboBox cbPaymentType;
        private Label lblComments;
        private TextBox tbComments;
        private Button btnConfirm;
        private Button btnBack;
        private ColumnHeader columnHeaderNameDishes;
        private ColumnHeader columnHeaderCount;
        private ColumnHeader columnHeaderPrice;
    }
}
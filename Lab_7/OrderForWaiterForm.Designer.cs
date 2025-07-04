namespace Lab_7
{
    partial class OrderForWaiterForm
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
            listViewDishes = new ListView();
            gbGroupingPresets = new GroupBox();
            rbCustomGrouping = new RadioButton();
            rbStandardGrouping = new RadioButton();
            labelTotalCost = new Label();
            lblDelivery = new Label();
            cbDeliveryType = new ComboBox();
            lblClientId = new Label();
            tbClientId = new TextBox();
            lblTableNumber = new Label();
            cbTableNumber = new ComboBox();
            lblComments = new Label();
            tbComments = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            gbGroupingPresets.SuspendLayout();
            SuspendLayout();
            // 
            // listViewDishes
            // 
            listViewDishes.AllowDrop = true;
            listViewDishes.FullRowSelect = true;
            listViewDishes.GridLines = true;
            listViewDishes.Location = new Point(12, 12);
            listViewDishes.Name = "listViewDishes";
            listViewDishes.Size = new Size(480, 400);
            listViewDishes.TabIndex = 0;
            listViewDishes.UseCompatibleStateImageBehavior = false;
            listViewDishes.View = View.Details;
            listViewDishes.Columns.Add("Название блюда", 300);
            listViewDishes.Columns.Add("Цена, руб.", 100);
            // 
            // gbGroupingPresets
            // 
            gbGroupingPresets.Controls.Add(rbCustomGrouping);
            gbGroupingPresets.Controls.Add(rbStandardGrouping);
            gbGroupingPresets.Location = new Point(510, 12);
            gbGroupingPresets.Name = "gbGroupingPresets";
            gbGroupingPresets.Size = new Size(260, 70);
            gbGroupingPresets.TabIndex = 1;
            gbGroupingPresets.TabStop = false;
            gbGroupingPresets.Text = "Выберите группировку";
            // 
            // rbCustomGrouping
            // 
            rbCustomGrouping.AutoSize = true;
            rbCustomGrouping.Location = new Point(140, 30);
            rbCustomGrouping.Name = "rbCustomGrouping";
            rbCustomGrouping.Size = new Size(105, 24);
            rbCustomGrouping.TabIndex = 1;
            rbCustomGrouping.TabStop = true;
            rbCustomGrouping.Text = "Кастомная";
            rbCustomGrouping.UseVisualStyleBackColor = true;
            // 
            // rbStandardGrouping
            // 
            rbStandardGrouping.AutoSize = true;
            rbStandardGrouping.Location = new Point(15, 30);
            rbStandardGrouping.Name = "rbStandardGrouping";
            rbStandardGrouping.Size = new Size(118, 24);
            rbStandardGrouping.TabIndex = 0;
            rbStandardGrouping.TabStop = true;
            rbStandardGrouping.Text = "Стандартная";
            rbStandardGrouping.UseVisualStyleBackColor = true;
            // 
            // labelTotalCost
            // 
            labelTotalCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalCost.ForeColor = Color.White;
            labelTotalCost.Location = new Point(510, 100);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(260, 23);
            labelTotalCost.TabIndex = 2;
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.ForeColor = Color.White;
            lblDelivery.Location = new Point(510, 140);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(104, 20);
            lblDelivery.TabIndex = 3;
            lblDelivery.Text = "Тип доставки:";
            // 
            // cbDeliveryType
            // 
            cbDeliveryType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeliveryType.FormattingEnabled = true;
            cbDeliveryType.Items.AddRange(new object[] { "Самовывоз", "Доставка" });
            cbDeliveryType.Location = new Point(650, 137);
            cbDeliveryType.Name = "cbDeliveryType";
            cbDeliveryType.Size = new Size(120, 28);
            cbDeliveryType.TabIndex = 4;
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.ForeColor = Color.White;
            lblClientId.Location = new Point(510, 180);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new Size(86, 20);
            lblClientId.TabIndex = 5;
            lblClientId.Text = "ID клиента:";
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(650, 177);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(120, 27);
            tbClientId.TabIndex = 6;
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.ForeColor = Color.White;
            lblTableNumber.Location = new Point(510, 220);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(118, 20);
            lblTableNumber.TabIndex = 7;
            lblTableNumber.Text = "Номер столика:";
            // 
            // cbTableNumber
            // 
            cbTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTableNumber.FormattingEnabled = true;
            cbTableNumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbTableNumber.Location = new Point(650, 217);
            cbTableNumber.Name = "cbTableNumber";
            cbTableNumber.Size = new Size(120, 28);
            cbTableNumber.TabIndex = 8;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.ForeColor = Color.White;
            lblComments.Location = new Point(510, 260);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(110, 20);
            lblComments.TabIndex = 9;
            lblComments.Text = "Комментарий:";
            // 
            // tbComments
            // 
            tbComments.Location = new Point(510, 285);
            tbComments.Multiline = true;
            tbComments.Name = "tbComments";
            tbComments.Size = new Size(260, 80);
            tbComments.TabIndex = 10;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(99, 58, 52);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(510, 380);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 32);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Подтвердить";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(650, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 32);
            btnBack.TabIndex = 12;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // OrderForWaiterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(800, 430);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(tbComments);
            Controls.Add(lblComments);
            Controls.Add(cbTableNumber);
            Controls.Add(lblTableNumber);
            Controls.Add(tbClientId);
            Controls.Add(lblClientId);
            Controls.Add(cbDeliveryType);
            Controls.Add(lblDelivery);
            Controls.Add(labelTotalCost);
            Controls.Add(gbGroupingPresets);
            Controls.Add(listViewDishes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrderForWaiterForm";
            Text = "Оформление заказа";
            gbGroupingPresets.ResumeLayout(false);
            gbGroupingPresets.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDishes;
        private GroupBox gbGroupingPresets;
        private RadioButton rbStandardGrouping;
        private RadioButton rbCustomGrouping;
        private Label labelTotalCost;
        private Label lblDelivery;
        private ComboBox cbDeliveryType;
        private Label lblClientId;
        private TextBox tbClientId;
        private Label lblTableNumber;
        private ComboBox cbTableNumber;
        private Label lblComments;
        private TextBox tbComments;
        private Button btnConfirm;
        private Button btnBack;
    }
}
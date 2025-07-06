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
            listViewDishes.Size = new Size(406, 400);
            listViewDishes.TabIndex = 0;
            listViewDishes.UseCompatibleStateImageBehavior = false;
            listViewDishes.View = View.Details;
            // 
            // gbGroupingPresets
            // 
            gbGroupingPresets.Controls.Add(rbCustomGrouping);
            gbGroupingPresets.Controls.Add(rbStandardGrouping);
            gbGroupingPresets.ForeColor = Color.White;
            gbGroupingPresets.Location = new Point(437, 12);
            gbGroupingPresets.Name = "gbGroupingPresets";
            gbGroupingPresets.Size = new Size(270, 70);
            gbGroupingPresets.TabIndex = 1;
            gbGroupingPresets.TabStop = false;
            gbGroupingPresets.Text = "Выберите группировку";
            // 
            // rbCustomGrouping
            // 
            rbCustomGrouping.AutoSize = true;
            rbCustomGrouping.ForeColor = Color.White;
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
            rbStandardGrouping.ForeColor = Color.White;
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
            labelTotalCost.Location = new Point(437, 100);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(270, 23);
            labelTotalCost.TabIndex = 2;
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDelivery.ForeColor = Color.White;
            lblDelivery.Location = new Point(437, 140);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(128, 25);
            lblDelivery.TabIndex = 3;
            lblDelivery.Text = "Тип доставки:";
            // 
            // cbDeliveryType
            // 
            cbDeliveryType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeliveryType.FormattingEnabled = true;
            cbDeliveryType.Items.AddRange(new object[] { "Самовывоз", "Доставка" });
            cbDeliveryType.Location = new Point(587, 137);
            cbDeliveryType.Name = "cbDeliveryType";
            cbDeliveryType.Size = new Size(120, 28);
            cbDeliveryType.TabIndex = 4;
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblClientId.ForeColor = Color.White;
            lblClientId.Location = new Point(437, 179);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new Size(107, 25);
            lblClientId.TabIndex = 5;
            lblClientId.Text = "ID клиента:";
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(587, 177);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(120, 27);
            tbClientId.TabIndex = 6;
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTableNumber.ForeColor = Color.White;
            lblTableNumber.Location = new Point(437, 220);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(145, 25);
            lblTableNumber.TabIndex = 7;
            lblTableNumber.Text = "Номер столика:";
            // 
            // cbTableNumber
            // 
            cbTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTableNumber.FormattingEnabled = true;
            cbTableNumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbTableNumber.Location = new Point(587, 217);
            cbTableNumber.Name = "cbTableNumber";
            cbTableNumber.Size = new Size(120, 28);
            cbTableNumber.TabIndex = 8;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblComments.ForeColor = Color.White;
            lblComments.Location = new Point(437, 257);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(135, 25);
            lblComments.TabIndex = 9;
            lblComments.Text = "Комментарий:";
            // 
            // tbComments
            // 
            tbComments.Location = new Point(437, 285);
            tbComments.Multiline = true;
            tbComments.Name = "tbComments";
            tbComments.Size = new Size(270, 80);
            tbComments.TabIndex = 10;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(99, 58, 52);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(447, 380);
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
            btnBack.Location = new Point(587, 380);
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
            ClientSize = new Size(724, 430);
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
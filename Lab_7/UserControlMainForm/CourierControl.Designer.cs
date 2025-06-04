namespace Lab_7
{
    partial class CourierControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panelMap = new Panel();
            buttonWaiterProfile = new Button();
            pictureBoxIcon = new PictureBox();
            panel1 = new Panel();
            listBoxCourierActiveOrders = new ListBox();
            listBoxCourierTakenOrders = new ListBox();
            textBoxCourierTakenOrders = new TextBox();
            textBoxCourierActiveOrders = new TextBox();
            buttonCourierTakeOrder = new Button();
            buttonCourierStartRoute = new Button();
            buttonCourierPayOrder = new Button();
            labelCourierRouteTime = new Label();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panelMap
            // 
            panelMap.BackColor = Color.White;
            panelMap.Controls.Add(buttonCourierStartRoute);
            panelMap.Controls.Add(buttonWaiterProfile);
            panelMap.Controls.Add(pictureBoxIcon);
            panelMap.Dock = DockStyle.Left;
            panelMap.Location = new Point(0, 0);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(150, 700);
            panelMap.TabIndex = 0;
            // 
            // buttonWaiterProfile
            // 
            buttonWaiterProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterProfile.Cursor = Cursors.Hand;
            buttonWaiterProfile.Enabled = false;
            buttonWaiterProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterProfile.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterProfile.Location = new Point(3, 623);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(141, 75);
            buttonWaiterProfile.TabIndex = 11;
            buttonWaiterProfile.Text = "Профиль";
            buttonWaiterProfile.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(150, 150);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 10;
            pictureBoxIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(156, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 337);
            panel1.TabIndex = 1;
            // 
            // listBoxCourierActiveOrders
            // 
            listBoxCourierActiveOrders.FormattingEnabled = true;
            listBoxCourierActiveOrders.Location = new Point(156, 388);
            listBoxCourierActiveOrders.Name = "listBoxCourierActiveOrders";
            listBoxCourierActiveOrders.Size = new Size(350, 304);
            listBoxCourierActiveOrders.TabIndex = 2;
            // 
            // listBoxCourierTakenOrders
            // 
            listBoxCourierTakenOrders.FormattingEnabled = true;
            listBoxCourierTakenOrders.Location = new Point(747, 388);
            listBoxCourierTakenOrders.Name = "listBoxCourierTakenOrders";
            listBoxCourierTakenOrders.Size = new Size(350, 304);
            listBoxCourierTakenOrders.TabIndex = 3;
            // 
            // textBoxCourierTakenOrders
            // 
            textBoxCourierTakenOrders.Location = new Point(747, 355);
            textBoxCourierTakenOrders.Name = "textBoxCourierTakenOrders";
            textBoxCourierTakenOrders.Size = new Size(350, 27);
            textBoxCourierTakenOrders.TabIndex = 4;
            textBoxCourierTakenOrders.Text = "Список взятых заказов";
            // 
            // textBoxCourierActiveOrders
            // 
            textBoxCourierActiveOrders.Location = new Point(156, 355);
            textBoxCourierActiveOrders.Name = "textBoxCourierActiveOrders";
            textBoxCourierActiveOrders.Size = new Size(350, 27);
            textBoxCourierActiveOrders.TabIndex = 5;
            textBoxCourierActiveOrders.Text = "Список активных заказов";
            // 
            // buttonCourierTakeOrder
            // 
            buttonCourierTakeOrder.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierTakeOrder.Cursor = Cursors.Hand;
            buttonCourierTakeOrder.Enabled = false;
            buttonCourierTakeOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCourierTakeOrder.ForeColor = SystemColors.ControlLightLight;
            buttonCourierTakeOrder.Location = new Point(512, 355);
            buttonCourierTakeOrder.Name = "buttonCourierTakeOrder";
            buttonCourierTakeOrder.Size = new Size(229, 75);
            buttonCourierTakeOrder.TabIndex = 12;
            buttonCourierTakeOrder.Text = "Взять заказ";
            buttonCourierTakeOrder.UseVisualStyleBackColor = false;
            buttonCourierTakeOrder.Click += buttonCourierTakeOrder_Click;
            // 
            // buttonCourierStartRoute
            // 
            buttonCourierStartRoute.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierStartRoute.Cursor = Cursors.Hand;
            buttonCourierStartRoute.Enabled = false;
            buttonCourierStartRoute.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCourierStartRoute.ForeColor = SystemColors.ControlLightLight;
            buttonCourierStartRoute.Location = new Point(3, 156);
            buttonCourierStartRoute.Name = "buttonCourierStartRoute";
            buttonCourierStartRoute.Size = new Size(141, 75);
            buttonCourierStartRoute.TabIndex = 13;
            buttonCourierStartRoute.Text = "Начать маршрут";
            buttonCourierStartRoute.UseVisualStyleBackColor = false;
            // 
            // buttonCourierPayOrder
            // 
            buttonCourierPayOrder.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierPayOrder.Cursor = Cursors.Hand;
            buttonCourierPayOrder.Enabled = false;
            buttonCourierPayOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCourierPayOrder.ForeColor = SystemColors.ControlLightLight;
            buttonCourierPayOrder.Location = new Point(512, 617);
            buttonCourierPayOrder.Name = "buttonCourierPayOrder";
            buttonCourierPayOrder.Size = new Size(229, 75);
            buttonCourierPayOrder.TabIndex = 14;
            buttonCourierPayOrder.Text = "Оплатить заказ";
            buttonCourierPayOrder.UseVisualStyleBackColor = false;
            // 
            // labelCourierRouteTime
            // 
            labelCourierRouteTime.AutoSize = true;
            labelCourierRouteTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCourierRouteTime.ForeColor = SystemColors.ControlLightLight;
            labelCourierRouteTime.Location = new Point(512, 578);
            labelCourierRouteTime.Name = "labelCourierRouteTime";
            labelCourierRouteTime.Size = new Size(169, 25);
            labelCourierRouteTime.TabIndex = 14;
            labelCourierRouteTime.Text = "Время маршрута:";
            // 
            // CourierControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(labelCourierRouteTime);
            Controls.Add(buttonCourierPayOrder);
            Controls.Add(buttonCourierTakeOrder);
            Controls.Add(textBoxCourierActiveOrders);
            Controls.Add(textBoxCourierTakenOrders);
            Controls.Add(listBoxCourierTakenOrders);
            Controls.Add(listBoxCourierActiveOrders);
            Controls.Add(panel1);
            Controls.Add(panelMap);
            Name = "CourierControl";
            Size = new Size(1104, 700);
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMap;
        private Button buttonWaiterProfile;
        private PictureBox pictureBoxIcon;
        private Panel panel1;
        private ListBox listBoxCourierActiveOrders;
        private ListBox listBoxCourierTakenOrders;
        private TextBox textBoxCourierTakenOrders;
        private TextBox textBoxCourierActiveOrders;
        private Button buttonCourierTakeOrder;
        private Label labelCourierRouteTime;
        private Button buttonCourierStartRoute;
        private Button buttonCourierPayOrder;
    }
}

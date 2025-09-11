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
            buttonCourierLogout = new Button();
            buttonCourierStartRoute = new Button();
            buttonWaiterProfile = new Button();
            pictureBoxIcon = new PictureBox();
            Map = new Panel();
            textBoxCourierTakenOrders = new TextBox();
            textBoxCourierActiveOrders = new TextBox();
            buttonCourierTakeOrder = new Button();
            buttonCourierPayOrder = new Button();
            labelCourierRouteTime = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            IDT = new DataGridViewTextBoxColumn();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelMap
            // 
            panelMap.BackColor = Color.White;
            panelMap.Controls.Add(buttonCourierLogout);
            panelMap.Controls.Add(buttonCourierStartRoute);
            panelMap.Controls.Add(buttonWaiterProfile);
            panelMap.Controls.Add(pictureBoxIcon);
            panelMap.Dock = DockStyle.Left;
            panelMap.Location = new Point(0, 0);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(150, 700);
            panelMap.TabIndex = 0;
            // 
            // buttonCourierLogout
            // 
            buttonCourierLogout.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierLogout.Cursor = Cursors.Hand;
            buttonCourierLogout.Dock = DockStyle.Bottom;
            buttonCourierLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCourierLogout.ForeColor = SystemColors.ControlLightLight;
            buttonCourierLogout.Location = new Point(0, 631);
            buttonCourierLogout.Name = "buttonCourierLogout";
            buttonCourierLogout.Size = new Size(150, 69);
            buttonCourierLogout.TabIndex = 18;
            buttonCourierLogout.Text = "Выход";
            buttonCourierLogout.UseVisualStyleBackColor = false;
            buttonCourierLogout.Click += buttonCourierLogout_Click;
            // 
            // buttonCourierStartRoute
            // 
            buttonCourierStartRoute.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierStartRoute.Cursor = Cursors.Hand;
            buttonCourierStartRoute.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCourierStartRoute.ForeColor = SystemColors.ControlLightLight;
            buttonCourierStartRoute.Location = new Point(0, 267);
            buttonCourierStartRoute.Name = "buttonCourierStartRoute";
            buttonCourierStartRoute.Size = new Size(150, 75);
            buttonCourierStartRoute.TabIndex = 13;
            buttonCourierStartRoute.Text = "Начать маршрут";
            buttonCourierStartRoute.UseVisualStyleBackColor = false;
            buttonCourierStartRoute.Click += buttonCourierStartRoute_Click;
            // 
            // buttonWaiterProfile
            // 
            buttonWaiterProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterProfile.Cursor = Cursors.Hand;
            buttonWaiterProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterProfile.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterProfile.Location = new Point(0, 156);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(150, 75);
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
            pictureBoxIcon.Size = new Size(150, 149);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 10;
            pictureBoxIcon.TabStop = false;
            // 
            // Map
            // 
            Map.BackColor = Color.White;
            Map.Location = new Point(155, 5);
            Map.Name = "Map";
            Map.Size = new Size(941, 337);
            Map.TabIndex = 1;
            // 
            // textBoxCourierTakenOrders
            // 
            textBoxCourierTakenOrders.Location = new Point(747, 355);
            textBoxCourierTakenOrders.Name = "textBoxCourierTakenOrders";
            textBoxCourierTakenOrders.ReadOnly = true;
            textBoxCourierTakenOrders.Size = new Size(350, 27);
            textBoxCourierTakenOrders.TabIndex = 4;
            textBoxCourierTakenOrders.Text = "Список взятых заказов";
            // 
            // textBoxCourierActiveOrders
            // 
            textBoxCourierActiveOrders.Location = new Point(155, 355);
            textBoxCourierActiveOrders.Name = "textBoxCourierActiveOrders";
            textBoxCourierActiveOrders.ReadOnly = true;
            textBoxCourierActiveOrders.Size = new Size(350, 27);
            textBoxCourierActiveOrders.TabIndex = 5;
            textBoxCourierActiveOrders.Text = "Список активных заказов";
            // 
            // buttonCourierTakeOrder
            // 
            buttonCourierTakeOrder.BackColor = Color.FromArgb(99, 58, 52);
            buttonCourierTakeOrder.Cursor = Cursors.Hand;
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
            buttonCourierPayOrder.Click += buttonCourierPayOrder_Click;
            // 
            // labelCourierRouteTime
            // 
            labelCourierRouteTime.AutoSize = true;
            labelCourierRouteTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCourierRouteTime.ForeColor = SystemColors.ControlLightLight;
            labelCourierRouteTime.Location = new Point(512, 579);
            labelCourierRouteTime.Name = "labelCourierRouteTime";
            labelCourierRouteTime.Size = new Size(169, 25);
            labelCourierRouteTime.TabIndex = 14;
            labelCourierRouteTime.Text = "Время маршрута:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID });
            dataGridView1.Location = new Point(155, 392);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(350, 300);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
            // 
            // ID
            // 
            ID.HeaderText = "ID Заказа";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 265;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDT });
            dataGridView2.Location = new Point(747, 392);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(350, 300);
            dataGridView2.TabIndex = 16;
            // 
            // IDT
            // 
            IDT.HeaderText = "ID Заказа";
            IDT.MinimumWidth = 6;
            IDT.Name = "IDT";
            IDT.Width = 265;
            // 
            // CourierControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(labelCourierRouteTime);
            Controls.Add(buttonCourierPayOrder);
            Controls.Add(buttonCourierTakeOrder);
            Controls.Add(textBoxCourierActiveOrders);
            Controls.Add(textBoxCourierTakenOrders);
            Controls.Add(Map);
            Controls.Add(panelMap);
            Name = "CourierControl";
            Size = new Size(1104, 700);
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMap;
        private Button buttonWaiterProfile;
        private PictureBox pictureBoxIcon;
        private Panel Map;
        private TextBox textBoxCourierTakenOrders;
        private TextBox textBoxCourierActiveOrders;
        private Button buttonCourierTakeOrder;
        private Label labelCourierRouteTime;
        private Button buttonCourierStartRoute;
        private Button buttonCourierPayOrder;
        private Button buttonCourierLogout;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IDT;
    }
}

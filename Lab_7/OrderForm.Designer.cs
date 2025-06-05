namespace Lab_7
{
    partial class OrderForm
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Food });
            dataGridView1.Location = new Point(354, 62);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(374, 413);
            dataGridView1.TabIndex = 0;
            // 
            // Food
            // 
            Food.HeaderText = "Блюда";
            Food.MinimumWidth = 6;
            Food.Name = "Food";
            Food.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(354, 12);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 1;
            label1.Text = "Заказ";
            // 
            // OrderIDLabe
            // 
            OrderIDLabe.AutoSize = true;
            OrderIDLabe.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            OrderIDLabe.ForeColor = SystemColors.ControlLightLight;
            OrderIDLabe.Location = new Point(458, 12);
            OrderIDLabe.Name = "OrderIDLabe";
            OrderIDLabe.Size = new Size(65, 46);
            OrderIDLabe.TabIndex = 2;
            OrderIDLabe.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(16, 213);
            label2.Name = "label2";
            label2.Size = new Size(71, 35);
            label2.TabIndex = 3;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(16, 271);
            label3.Name = "label3";
            label3.Size = new Size(59, 35);
            label3.TabIndex = 4;
            label3.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(16, 323);
            label4.Name = "label4";
            label4.Size = new Size(144, 35);
            label4.TabIndex = 5;
            label4.Text = "Стоимость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(16, 440);
            label5.Name = "label5";
            label5.Size = new Size(187, 35);
            label5.TabIndex = 6;
            label5.Text = "Статус оплаты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(16, 380);
            label6.Name = "label6";
            label6.Size = new Size(91, 35);
            label6.TabIndex = 7;
            label6.Text = "Статус";
            // 
            // DateLabe
            // 
            DateLabe.AutoSize = true;
            DateLabe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            DateLabe.ForeColor = SystemColors.ControlLightLight;
            DateLabe.Location = new Point(239, 217);
            DateLabe.Name = "DateLabe";
            DateLabe.Size = new Size(79, 31);
            DateLabe.TabIndex = 8;
            DateLabe.Text = "label7";
            // 
            // TypeLabe
            // 
            TypeLabe.AutoSize = true;
            TypeLabe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            TypeLabe.ForeColor = SystemColors.ControlLightLight;
            TypeLabe.Location = new Point(239, 274);
            TypeLabe.Name = "TypeLabe";
            TypeLabe.Size = new Size(79, 31);
            TypeLabe.TabIndex = 9;
            TypeLabe.Text = "label7";
            // 
            // CostLabe
            // 
            CostLabe.AutoSize = true;
            CostLabe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            CostLabe.ForeColor = SystemColors.ControlLightLight;
            CostLabe.Location = new Point(239, 323);
            CostLabe.Name = "CostLabe";
            CostLabe.Size = new Size(79, 31);
            CostLabe.TabIndex = 10;
            CostLabe.Text = "label7";
            // 
            // BehaviourLabe
            // 
            BehaviourLabe.AutoSize = true;
            BehaviourLabe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            BehaviourLabe.ForeColor = SystemColors.ControlLightLight;
            BehaviourLabe.Location = new Point(239, 384);
            BehaviourLabe.Name = "BehaviourLabe";
            BehaviourLabe.Size = new Size(79, 31);
            BehaviourLabe.TabIndex = 11;
            BehaviourLabe.Text = "label7";
            // 
            // PayementLabe
            // 
            PayementLabe.AutoSize = true;
            PayementLabe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            PayementLabe.ForeColor = SystemColors.ControlLightLight;
            PayementLabe.Location = new Point(239, 443);
            PayementLabe.Name = "PayementLabe";
            PayementLabe.Size = new Size(79, 31);
            PayementLabe.TabIndex = 12;
            PayementLabe.Text = "label7";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(739, 488);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderForm";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
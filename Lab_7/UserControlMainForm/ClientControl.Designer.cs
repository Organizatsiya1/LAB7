namespace Lab_7
{
    partial class ClientControl
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageClientMenu = new TabPage();
            tabPageCurrentOrder = new TabPage();
            listViewClientMenu = new ListView();
            textBox1 = new TextBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            splitContainer1 = new SplitContainer();
            tabControl1.SuspendLayout();
            tabPageClientMenu.SuspendLayout();
            tabPageCurrentOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "КЛИЕНТ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageClientMenu);
            tabControl1.Controls.Add(tabPageCurrentOrder);
            tabControl1.Location = new Point(126, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 700);
            tabControl1.TabIndex = 1;
            // 
            // tabPageClientMenu
            // 
            tabPageClientMenu.BackColor = Color.FromArgb(99, 58, 52);
            tabPageClientMenu.Controls.Add(textBox1);
            tabPageClientMenu.Controls.Add(listViewClientMenu);
            tabPageClientMenu.Location = new Point(4, 29);
            tabPageClientMenu.Name = "tabPageClientMenu";
            tabPageClientMenu.Padding = new Padding(3);
            tabPageClientMenu.Size = new Size(992, 667);
            tabPageClientMenu.TabIndex = 0;
            tabPageClientMenu.Text = "Меню";
            // 
            // tabPageCurrentOrder
            // 
            tabPageCurrentOrder.BackColor = Color.FromArgb(99, 58, 52);
            tabPageCurrentOrder.Controls.Add(splitContainer1);
            tabPageCurrentOrder.ForeColor = SystemColors.ControlLightLight;
            tabPageCurrentOrder.Location = new Point(4, 29);
            tabPageCurrentOrder.Name = "tabPageCurrentOrder";
            tabPageCurrentOrder.Padding = new Padding(3);
            tabPageCurrentOrder.Size = new Size(992, 667);
            tabPageCurrentOrder.TabIndex = 1;
            tabPageCurrentOrder.Text = "Текущий заказ";
            // 
            // listViewClientMenu
            // 
            listViewClientMenu.BackColor = SystemColors.ScrollBar;
            listViewClientMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewClientMenu.Dock = DockStyle.Left;
            listViewClientMenu.Location = new Point(3, 3);
            listViewClientMenu.Name = "listViewClientMenu";
            listViewClientMenu.Size = new Size(605, 661);
            listViewClientMenu.TabIndex = 0;
            listViewClientMenu.UseCompatibleStateImageBehavior = false;
            listViewClientMenu.View = View.Tile;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(614, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 27);
            textBox1.TabIndex = 1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Цена";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Категория";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Изображение";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(986, 661);
            splitContainer1.SplitterDistance = 328;
            splitContainer1.TabIndex = 0;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "ClientControl";
            Size = new Size(1136, 715);
            tabControl1.ResumeLayout(false);
            tabPageClientMenu.ResumeLayout(false);
            tabPageClientMenu.PerformLayout();
            tabPageCurrentOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageClientMenu;
        private TabPage tabPageCurrentOrder;
        private TextBox textBox1;
        private ListView listViewClientMenu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private SplitContainer splitContainer1;
    }
}

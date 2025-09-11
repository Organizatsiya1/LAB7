using System.Windows.Forms;

namespace Lab_7
{
    partial class FoodForm
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
            pictureBoxFood = new PictureBox();
            labelName = new Label();
            labelDescription = new Label();
            labelWeight = new Label();
            labelCost = new Label();
            buttonAddToCart = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            labelFormula = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFood
            // 
            pictureBoxFood.Image = Properties.Resources.PlaceholderMenu;
            pictureBoxFood.Location = new Point(12, 104);
            pictureBoxFood.Name = "pictureBoxFood";
            pictureBoxFood.Size = new Size(200, 200);
            pictureBoxFood.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFood.TabIndex = 0;
            pictureBoxFood.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(227, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(367, 24);
            labelName.TabIndex = 1;
            labelName.Text = "labelName";
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(228, 45);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(366, 53);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "labelDescription";
            // 
            // labelWeight
            // 
            labelWeight.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWeight.ForeColor = Color.White;
            labelWeight.Location = new Point(303, 281);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(291, 23);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "labelWeight";
            // 
            // labelCost
            // 
            labelCost.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCost.ForeColor = Color.White;
            labelCost.Location = new Point(303, 314);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(291, 23);
            labelCost.TabIndex = 5;
            labelCost.Text = "labelCost";
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddToCart.ForeColor = Color.White;
            buttonAddToCart.Location = new Point(11, 313);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(200, 52);
            buttonAddToCart.TabIndex = 6;
            buttonAddToCart.Text = "Добавить в корзину";
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(99, 58, 52);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(227, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 9;
            textBox1.Text = "Цена:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(99, 58, 52);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(227, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "Вес:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(99, 58, 52);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(111, 12);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 27);
            textBox5.TabIndex = 15;
            textBox5.Text = "Название:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(99, 58, 52);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(227, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 16;
            textBox3.Text = "Состав:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(99, 58, 52);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(111, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 27);
            textBox4.TabIndex = 17;
            textBox4.Text = "Описание:";
            // 
            // labelFormula
            // 
            labelFormula.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFormula.ForeColor = Color.White;
            labelFormula.Location = new Point(303, 104);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(291, 164);
            labelFormula.TabIndex = 18;
            labelFormula.Text = "labelFormula";
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(606, 375);
            Controls.Add(labelFormula);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxFood);
            Controls.Add(labelName);
            Controls.Add(labelDescription);
            Controls.Add(labelWeight);
            Controls.Add(labelCost);
            Controls.Add(buttonAddToCart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о блюде";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFood;
        private Label labelName, labelDescription, labelWeight, labelCost;
        private PictureBox pictureBox1;
        private Button buttonAddToCart;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label labelFormula;
    }
}
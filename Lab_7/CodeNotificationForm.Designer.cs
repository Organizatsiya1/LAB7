namespace Lab_7
{
    partial class CodeNotification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCancelCode = new Button();
            textBoxCodNotification = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancelCode);
            panel1.Controls.Add(textBoxCodNotification);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 59);
            panel1.TabIndex = 0;
            // 
            // buttonCancelCode
            // 
            buttonCancelCode.Location = new Point(143, 13);
            buttonCancelCode.Name = "buttonCancelCode";
            buttonCancelCode.Size = new Size(94, 29);
            buttonCancelCode.TabIndex = 1;
            buttonCancelCode.Text = "Закрыть";
            buttonCancelCode.UseVisualStyleBackColor = true;
            buttonCancelCode.Click += buttonCancelCode_Click;
            // 
            // textBoxCodNotification
            // 
            textBoxCodNotification.Location = new Point(12, 15);
            textBoxCodNotification.Name = "textBoxCodNotification";
            textBoxCodNotification.Size = new Size(125, 27);
            textBoxCodNotification.TabIndex = 0;
            textBoxCodNotification.TextAlign = HorizontalAlignment.Center;
            // 
            // CodeNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(273, 84);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CodeNotification";
            Text = "Code Notification";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancelCode;
        private TextBox textBoxCodNotification;
    }
}

namespace OneforAllWinForms
{
    partial class Form1
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
            btnMinMaX = new Button();
            tlpLeft = new TableLayoutPanel();
            pnlRight = new Panel();
            button1 = new Button();
            tlpLeft.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinMaX
            // 
            btnMinMaX.Dock = DockStyle.Fill;
            btnMinMaX.Location = new Point(3, 103);
            btnMinMaX.Name = "btnMinMaX";
            btnMinMaX.Size = new Size(147, 44);
            btnMinMaX.TabIndex = 0;
            btnMinMaX.Text = "Array berechnen";
            btnMinMaX.UseVisualStyleBackColor = true;
            btnMinMaX.Click += btnMinMaX_Click;
            // 
            // tlpLeft
            // 
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(btnMinMaX, 0, 2);
            tlpLeft.Controls.Add(button1, 0, 1);
            tlpLeft.Dock = DockStyle.Left;
            tlpLeft.Location = new Point(0, 0);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 6;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpLeft.Size = new Size(153, 450);
            tlpLeft.TabIndex = 2;
            // 
            // pnlRight
            // 
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(153, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(647, 450);
            pnlRight.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 53);
            button1.Name = "button1";
            button1.Size = new Size(147, 44);
            button1.TabIndex = 1;
            button1.Text = "Fibonaci";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRight);
            Controls.Add(tlpLeft);
            Name = "Form1";
            Text = "One For ALL";
            tlpLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnMinMaX;
        private TableLayoutPanel tlpLeft;
        private Panel pnlRight;
        private Button button1;
    }



}

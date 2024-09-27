namespace OneforAllWinForms
{
    partial class FormArrayBerechnen
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
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            btnZuruecksetzen = new Button();
            btnBerechnen = new Button();
            btnZufaeligeWerteHinzufuegen = new Button();
            btnWertHinzufügen = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnZuruecksetzen);
            panel1.Controls.Add(btnBerechnen);
            panel1.Controls.Add(btnZufaeligeWerteHinzufuegen);
            panel1.Controls.Add(btnWertHinzufügen);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 200);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 177);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Wert";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(462, 138);
            button5.Name = "button5";
            button5.Size = new Size(181, 23);
            button5.TabIndex = 6;
            button5.Text = "Beenden";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnZuruecksetzen
            // 
            btnZuruecksetzen.Location = new Point(462, 109);
            btnZuruecksetzen.Name = "btnZuruecksetzen";
            btnZuruecksetzen.Size = new Size(181, 23);
            btnZuruecksetzen.TabIndex = 5;
            btnZuruecksetzen.Text = "Entfernen";
            btnZuruecksetzen.UseVisualStyleBackColor = true;
            btnZuruecksetzen.Click += btnZuruecksetzen_Click;
            // 
            // btnBerechnen
            // 
            btnBerechnen.Location = new Point(462, 80);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(181, 23);
            btnBerechnen.TabIndex = 4;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // btnZufaeligeWerteHinzufuegen
            // 
            btnZufaeligeWerteHinzufuegen.Location = new Point(462, 51);
            btnZufaeligeWerteHinzufuegen.Name = "btnZufaeligeWerteHinzufuegen";
            btnZufaeligeWerteHinzufuegen.Size = new Size(181, 23);
            btnZufaeligeWerteHinzufuegen.TabIndex = 3;
            btnZufaeligeWerteHinzufuegen.Text = "Zufällige Werte hinzufügen";
            btnZufaeligeWerteHinzufuegen.UseVisualStyleBackColor = true;
            btnZufaeligeWerteHinzufuegen.Click += btnZufaeligeWerteHinzufuegen_Click;
            // 
            // btnWertHinzufügen
            // 
            btnWertHinzufügen.Location = new Point(462, 22);
            btnWertHinzufügen.Name = "btnWertHinzufügen";
            btnWertHinzufügen.Size = new Size(181, 23);
            btnWertHinzufügen.TabIndex = 2;
            btnWertHinzufügen.Text = "Wert hinzufügen";
            btnWertHinzufügen.UseVisualStyleBackColor = true;
            btnWertHinzufügen.Click += btnWertHinzufügen_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(77, 250);
            listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(77, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 250);
            dataGridView1.TabIndex = 3;
            // 
            // FormArrayBerechnen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormArrayBerechnen";
            Text = "FormArrayBerechnen";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button btnZuruecksetzen;
        private Button btnBerechnen;
        private Button btnZufaeligeWerteHinzufuegen;
        private Button btnWertHinzufügen;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneforAllWinForms
{
    public partial class FormArrayBerechnen : Form
    {
        List<Berechnen> lst = new();
        public FormArrayBerechnen()
        {
            InitializeComponent();
            GridInitialisieren();
        }

        private void GridInitialisieren()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWertHinzufügen_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != null)
            {
                this.listBox1.Items.Add(this.textBox1.Text);
            }
        }

        private void btnZufaeligeWerteHinzufuegen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(100);
            this.textBox2.Text = a.ToString();
            this.listBox1.Items.Add(this.textBox2.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            Berechnen berechnen = new Berechnen();
            berechnen.arr = new int[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string? s = listBox1.Items[i] as string;
                berechnen.arr[i] = Convert.ToInt32(s);
            }
            berechnen.max(berechnen.arr);
            berechnen.min(berechnen.arr);
            berechnen.avg(berechnen.arr);
            berechnen.summ(berechnen.arr);

            lst.Add(berechnen);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;


            // lst.Add()
        }

        private void btnZuruecksetzen_Click(object sender, EventArgs e)
        {
            var selectedItems = dataGridView1.SelectedRows;

            
            List<Berechnen> itemsToRemove = new List<Berechnen>();    // liste zu entfernen erstellen

           
            foreach (DataGridViewRow row in selectedItems)               // einfüllen ie Li
            {
                var berechnen = row.DataBoundItem as Berechnen;
                if (berechnen != null)
                {
                    itemsToRemove.Add(berechnen);
                }
            }

            
            foreach (var item in itemsToRemove)
            {
                lst.Remove(item);
            }

            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;

        }
    }

}

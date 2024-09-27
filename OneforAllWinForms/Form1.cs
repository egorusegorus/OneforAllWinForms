namespace OneforAllWinForms
{
    public partial class Form1 : Form
    {

        FormArrayBerechnen formArrayBerechnen = new FormArrayBerechnen();
        FormFibonaci formFibonaci= new FormFibonaci();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinMaX_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();
            formArrayBerechnen.TopLevel = false;
            pnlRight.Controls.Add(formArrayBerechnen);
            formArrayBerechnen.Dock = DockStyle.Fill;
            formArrayBerechnen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Clear();
            formFibonaci.TopLevel = false;
            pnlRight.Controls.Add(formFibonaci);
            formFibonaci.Dock = DockStyle.Fill;
            formFibonaci.Show();
        }
    }
}

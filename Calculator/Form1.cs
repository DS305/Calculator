namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty)
            {
                double a, b, sum;
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                sum = a + b;
                txtKQ.Text = sum.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a, b, sub;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            sub = a - b;
            txtKQ.Text = sub.ToString();
        }
    }
}
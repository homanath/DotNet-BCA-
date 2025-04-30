namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal principle, time, rate, interest;
            principle = Convert.ToDecimal(txtPrinciple.Text);
            time = Convert.ToDecimal(textTime.Text);
            rate = Convert.ToDecimal(textRate.Text);
            interest = (principle * time * rate) / 100;
            MessageBox.Show("The interest is: " + interest.ToString());
        }
        private void btnReset_click(object sender, EventArgs e)
        {
            txtPrinciple.Text = textTime.Text = textRate.Text = String.Empty;
            txtPrinciple.Focus();
        }
    }
}

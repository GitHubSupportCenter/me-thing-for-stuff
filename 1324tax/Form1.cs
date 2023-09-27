namespace _1324tax
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
            {
                decimal income = decimal.Parse(textBox1.Text);
                decimal taxOwed = 0;

                if (income >= 0 && income <= 9225)
                {
                    taxOwed = income * 0.1m;
                }
                else if (income > 9225 && income <= 37450)
                {
                    taxOwed = 922.5m + (income - 9225) * 0.15m;
                }

                textBox2.Text = taxOwed.ToString("C");
            }
        }

    }
}


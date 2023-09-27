namespace change_calculator
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int changeAmount = int.Parse(txtChange.Text);
            int quarters = changeAmount / 25;
            changeAmount %= 25;

            int dimes = changeAmount / 10;
            changeAmount %= 10;

            int nickles = changeAmount / 5;
            changeAmount %= 5;

            int pennys = changeAmount;


            txtQuarters.Text = quarters.ToString();
            txtDimes.Text = dimes.ToString();
            txtNickles.Text = nickles.ToString();
            txtPennys.Text = pennys.ToString();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



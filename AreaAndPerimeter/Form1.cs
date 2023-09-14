namespace AreaAndPerimeter
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
            int pmtr = (int)((Convert.ToDecimal(txtLength.Text) + Convert.ToDecimal(txtWidth.Text)) * 2);
            int area = (int)(Convert.ToDecimal(txtLength.Text) * Convert.ToDecimal(txtWidth.Text));

            txtArea.Text = pmtr.ToString();
            txtPerimeter.Text = area.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
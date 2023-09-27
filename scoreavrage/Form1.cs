namespace scoreavrage
{
    public partial class Form1 : Form
    {

        private int scoreTotal = 0;
        private int scoreCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            scoreTotal += score;
            scoreCount++;
            double averageScore = (double)scoreTotal / scoreCount;

            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = averageScore.ToString("f2");

            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



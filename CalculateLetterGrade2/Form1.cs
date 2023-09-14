namespace CalculateLetterGrade2
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double numericGrade = Convert.ToDouble(txtNumberGrade.Text);

            string letterGradeValue;
            if (numericGrade >= 90.0)
            {
                letterGradeValue = "A";
            }
            else if (numericGrade >= 80.0)
            {
                letterGradeValue = "B";
            }
            else if (numericGrade >= 70.0)
            {
                letterGradeValue = "C";
            }
            else if (numericGrade >= 60.0)
            {
                letterGradeValue = "D";
            }
            else
            {
                letterGradeValue = "F";
            }

            txtLetterGrade.Text = letterGradeValue;
        }
    }
}

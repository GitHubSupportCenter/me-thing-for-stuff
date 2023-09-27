namespace scoreavrage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtScore = new TextBox();
            txtScoreTotal = new TextBox();
            txtScoreCount = new TextBox();
            txtAverage = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(319, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(234, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(109, 269);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 97);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Score Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Score Count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 187);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Average:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(209, 56);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 7;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(209, 89);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(100, 23);
            txtScoreTotal.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(209, 142);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(100, 23);
            txtScoreCount.TabIndex = 9;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(209, 179);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(100, 23);
            txtAverage.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 313);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
        

        #endregion

        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtScore;
        private TextBox txtScoreTotal;
        private TextBox txtScoreCount;
        private TextBox txtAverage;
    }
}
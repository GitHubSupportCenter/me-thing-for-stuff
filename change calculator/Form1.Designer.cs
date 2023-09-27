namespace change_calculator
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
            btnCalculate = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtChange = new TextBox();
            txtDimes = new TextBox();
            txtQuarters = new TextBox();
            txtNickles = new TextBox();
            txtPennys = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(193, 286);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(292, 286);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 59);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 2;
            label1.Text = "Change due (0-99):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Quarters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 131);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Dimes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 176);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "Nickles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 224);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Pennys";
            // 
            // txtChange
            // 
            txtChange.Location = new Point(292, 59);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(100, 23);
            txtChange.TabIndex = 7;
            txtChange.Click += btnCalculate_Click_1;
            // 
            // txtDimes
            // 
            txtDimes.Location = new Point(292, 131);
            txtDimes.Name = "txtDimes";
            txtDimes.ReadOnly = true;
            txtDimes.Size = new Size(100, 23);
            txtDimes.TabIndex = 9;
            // 
            // txtQuarters
            // 
            txtQuarters.Location = new Point(292, 92);
            txtQuarters.Name = "txtQuarters";
            txtQuarters.ReadOnly = true;
            txtQuarters.Size = new Size(100, 23);
            txtQuarters.TabIndex = 10;
            // 
            // txtNickles
            // 
            txtNickles.Location = new Point(292, 176);
            txtNickles.Name = "txtNickles";
            txtNickles.ReadOnly = true;
            txtNickles.Size = new Size(100, 23);
            txtNickles.TabIndex = 11;
            // 
            // txtPennys
            // 
            txtPennys.Location = new Point(292, 224);
            txtPennys.Name = "txtPennys";
            txtPennys.ReadOnly = true;
            txtPennys.Size = new Size(100, 23);
            txtPennys.TabIndex = 12;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPennys);
            Controls.Add(txtNickles);
            Controls.Add(txtQuarters);
            Controls.Add(txtDimes);
            Controls.Add(txtChange);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtChange;
        private TextBox txtDimes;
        private TextBox txtQuarters;
        private TextBox txtNickles;
        private TextBox txtPennys;
    }
}
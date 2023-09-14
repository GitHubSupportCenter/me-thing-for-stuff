namespace AreaAndPerimeter
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
            Length = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(79, 171);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(193, 171);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Length
            // 
            Length.AutoSize = true;
            Length.Location = new Point(79, 20);
            Length.Name = "Length";
            Length.Size = new Size(47, 15);
            Length.TabIndex = 2;
            Length.Text = "Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 51);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Width:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 89);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Perimeter:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(193, 20);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 6;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(193, 51);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 7;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(193, 89);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 8;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(193, 118);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(100, 23);
            txtPerimeter.TabIndex = 9;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(349, 266);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Length);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Area and perimeter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label Length;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtArea;
        private TextBox txtPerimeter;
    }
}
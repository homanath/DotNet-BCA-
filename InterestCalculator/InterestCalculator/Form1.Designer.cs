namespace InterestCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrinciple = new MaskedTextBox();
            textTime = new TextBox();
            textRate = new MaskedTextBox();
            calculaate = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Principle Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Time in Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 122);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 173);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // txtPrinciple
            // 
            txtPrinciple.Location = new Point(169, 24);
            txtPrinciple.Name = "txtPrinciple";
            txtPrinciple.Size = new Size(227, 27);
            txtPrinciple.TabIndex = 4;
            // 
            // textTime
            // 
            textTime.Location = new Point(169, 78);
            textTime.Name = "textTime";
            textTime.Size = new Size(227, 27);
            textTime.TabIndex = 5;
            // 
            // textRate
            // 
            textRate.Location = new Point(169, 122);
            textRate.Name = "textRate";
            textRate.Size = new Size(227, 27);
            textRate.TabIndex = 4;
            // 
            // calculaate
            // 
            calculaate.Location = new Point(173, 178);
            calculaate.Name = "calculaate";
            calculaate.Size = new Size(94, 29);
            calculaate.TabIndex = 6;
            calculaate.Text = "Calculate";
            calculaate.UseVisualStyleBackColor = true;
            calculaate.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(291, 178);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 239);
            Controls.Add(btnReset);
            Controls.Add(calculaate);
            Controls.Add(textTime);
            Controls.Add(textRate);
            Controls.Add(txtPrinciple);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtPrinciple;
        private TextBox textTime;
        private MaskedTextBox textRate;
        private Button calculaate;
        private Button btnReset;
    }
}

namespace Stands
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
            nudAge = new NumericUpDown();
            button1 = new Button();
            txtOut = new TextBox();
            label2 = new Label();
            nudStudy = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStudy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 85);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Age";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(248, 85);
            nudAge.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudAge.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(201, 27);
            nudAge.TabIndex = 1;
            nudAge.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(455, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 48);
            button1.TabIndex = 2;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(196, 151);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(353, 273);
            txtOut.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 118);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Study";
            // 
            // nudStudy
            // 
            nudStudy.Location = new Point(248, 118);
            nudStudy.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudStudy.Name = "nudStudy";
            nudStudy.Size = new Size(201, 27);
            nudStudy.TabIndex = 1;
            nudStudy.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOut);
            Controls.Add(button1);
            Controls.Add(nudStudy);
            Controls.Add(label2);
            Controls.Add(nudAge);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStudy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudAge;
        private Button button1;
        private TextBox txtOut;
        private Label label2;
        private NumericUpDown nudStudy;
    }
}

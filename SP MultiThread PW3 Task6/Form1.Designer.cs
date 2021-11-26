namespace SP_MultiThread_PW3_Task6
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.range1Start = new System.Windows.Forms.TextBox();
            this.range1End = new System.Windows.Forms.TextBox();
            this.range2Start = new System.Windows.Forms.TextBox();
            this.range2End = new System.Windows.Forms.TextBox();
            this.range3Start = new System.Windows.Forms.TextBox();
            this.range3End = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.compButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TB1.Location = new System.Drawing.Point(162, 12);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB1.Size = new System.Drawing.Size(161, 318);
            this.TB1.TabIndex = 0;
            // 
            // range1Start
            // 
            this.range1Start.Location = new System.Drawing.Point(12, 12);
            this.range1Start.Name = "range1Start";
            this.range1Start.Size = new System.Drawing.Size(52, 27);
            this.range1Start.TabIndex = 1;
            this.range1Start.Text = "1";
            // 
            // range1End
            // 
            this.range1End.Location = new System.Drawing.Point(70, 12);
            this.range1End.Name = "range1End";
            this.range1End.Size = new System.Drawing.Size(52, 27);
            this.range1End.TabIndex = 1;
            this.range1End.Text = "50";
            // 
            // range2Start
            // 
            this.range2Start.Location = new System.Drawing.Point(12, 45);
            this.range2Start.Name = "range2Start";
            this.range2Start.Size = new System.Drawing.Size(52, 27);
            this.range2Start.TabIndex = 1;
            this.range2Start.Text = "51";
            // 
            // range2End
            // 
            this.range2End.Location = new System.Drawing.Point(70, 45);
            this.range2End.Name = "range2End";
            this.range2End.Size = new System.Drawing.Size(52, 27);
            this.range2End.TabIndex = 1;
            this.range2End.Text = "200";
            // 
            // range3Start
            // 
            this.range3Start.Location = new System.Drawing.Point(12, 78);
            this.range3Start.Name = "range3Start";
            this.range3Start.Size = new System.Drawing.Size(52, 27);
            this.range3Start.TabIndex = 1;
            this.range3Start.Text = "201";
            // 
            // range3End
            // 
            this.range3End.Location = new System.Drawing.Point(70, 78);
            this.range3End.Name = "range3End";
            this.range3End.Size = new System.Drawing.Size(52, 27);
            this.range3End.TabIndex = 1;
            this.range3End.Text = "500";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(329, 12);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB2.Size = new System.Drawing.Size(161, 318);
            this.TB2.TabIndex = 0;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(496, 12);
            this.TB3.Multiline = true;
            this.TB3.Name = "TB3";
            this.TB3.ReadOnly = true;
            this.TB3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB3.Size = new System.Drawing.Size(161, 318);
            this.TB3.TabIndex = 0;
            // 
            // compButton
            // 
            this.compButton.Location = new System.Drawing.Point(13, 112);
            this.compButton.Name = "compButton";
            this.compButton.Size = new System.Drawing.Size(109, 29);
            this.compButton.TabIndex = 2;
            this.compButton.Text = "Compute";
            this.compButton.UseVisualStyleBackColor = true;
            this.compButton.Click += new System.EventHandler(this.compButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 341);
            this.Controls.Add(this.compButton);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.range3End);
            this.Controls.Add(this.range3Start);
            this.Controls.Add(this.range2End);
            this.Controls.Add(this.range2Start);
            this.Controls.Add(this.range1End);
            this.Controls.Add(this.range1Start);
            this.Controls.Add(this.TB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox range1Start;
        private System.Windows.Forms.TextBox range1End;
        private System.Windows.Forms.TextBox range2Start;
        private System.Windows.Forms.TextBox range2End;
        private System.Windows.Forms.TextBox range3Start;
        private System.Windows.Forms.TextBox range3End;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Button compButton;
    }
}


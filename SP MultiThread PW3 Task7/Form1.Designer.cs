namespace SP_MultiThread_PW3_Task7
{
    public partial class Form1
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
        /// 


        private void InitializeComponent()
        {
            this.getButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(13, 13);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(277, 33);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "Get Results";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Median:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max:";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(318, 13);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB1.Size = new System.Drawing.Size(212, 330);
            this.TB1.TabIndex = 2;
            /////
            valueMin = new System.Windows.Forms.Label();
            this.valueMin.AutoSize = true;
            this.valueMin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueMin.Location = new System.Drawing.Point(122, 61);
            this.valueMin.Name = "valueMin";
            this.valueMin.Size = new System.Drawing.Size(28, 35);
            this.valueMin.TabIndex = 1;
            this.valueMin.Text = "0";
            this.Controls.Add(this.valueMin);
            /////
            this.valueMedian = new System.Windows.Forms.Label();
            this.valueMedian.AutoSize = true;
            this.valueMedian.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueMedian.Location = new System.Drawing.Point(122, 96);
            this.valueMedian.Name = "valueMedian";
            this.valueMedian.Size = new System.Drawing.Size(28, 35);
            this.valueMedian.TabIndex = 1;
            this.valueMedian.Text = "0";
            this.Controls.Add(this.valueMedian);
            /////
            this.valueMax = new System.Windows.Forms.Label();
            this.valueMax.AutoSize = true;
            this.valueMax.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueMax.Location = new System.Drawing.Point(122, 131);
            this.valueMax.Name = "valueMax";
            this.valueMax.Size = new System.Drawing.Size(28, 35);
            this.valueMax.TabIndex = 1;
            this.valueMax.Text = "0";
            this.Controls.Add(this.valueMax);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 355);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueMin;
        private System.Windows.Forms.Label valueMedian;
        private System.Windows.Forms.Label valueMax;
        private System.Windows.Forms.TextBox TB1;
    }
}


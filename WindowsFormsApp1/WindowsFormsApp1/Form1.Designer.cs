namespace CustomCPU_Code
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCallBack = new System.Windows.Forms.Button();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.btnMultiThread = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(354, 352);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 25);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCallBack
            // 
            this.btnCallBack.Location = new System.Drawing.Point(656, 147);
            this.btnCallBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnCallBack.Name = "btnCallBack";
            this.btnCallBack.Size = new System.Drawing.Size(121, 33);
            this.btnCallBack.TabIndex = 14;
            this.btnCallBack.Text = "Callback";
            this.btnCallBack.UseVisualStyleBackColor = true;
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.Location = new System.Drawing.Point(656, 88);
            this.btnReturnValue.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(121, 33);
            this.btnReturnValue.TabIndex = 13;
            this.btnReturnValue.Text = "Return Value";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.Location = new System.Drawing.Point(24, 309);
            this.btnStopWatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(159, 31);
            this.btnStopWatch.TabIndex = 12;
            this.btnStopWatch.Text = "Stopwatch Example";
            this.btnStopWatch.UseVisualStyleBackColor = true;
            // 
            // btnMultiThread
            // 
            this.btnMultiThread.Location = new System.Drawing.Point(24, 239);
            this.btnMultiThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiThread.Name = "btnMultiThread";
            this.btnMultiThread.Size = new System.Drawing.Size(159, 31);
            this.btnMultiThread.TabIndex = 11;
            this.btnMultiThread.Text = "Run ( Multiple )";
            this.btnMultiThread.UseVisualStyleBackColor = true;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(24, 170);
            this.btnAsync.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(159, 31);
            this.btnAsync.TabIndex = 10;
            this.btnAsync.Text = "Run ( ASync )";
            this.btnAsync.UseVisualStyleBackColor = true;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(24, 101);
            this.btnExample1.Margin = new System.Windows.Forms.Padding(2);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(159, 31);
            this.btnExample1.TabIndex = 9;
            this.btnExample1.Text = "Run ( Sync )";
            this.btnExample1.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(288, 73);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(297, 269);
            this.rtbDisplay.TabIndex = 8;
            this.rtbDisplay.Text = "";
            this.rtbDisplay.TextChanged += new System.EventHandler(this.rtbDisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCallBack);
            this.Controls.Add(this.btnReturnValue);
            this.Controls.Add(this.btnStopWatch);
            this.Controls.Add(this.btnMultiThread);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnExample1);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCallBack;
        private System.Windows.Forms.Button btnReturnValue;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Button btnMultiThread;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}


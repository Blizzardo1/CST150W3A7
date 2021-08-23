using System.Drawing;
using System.Windows.Forms;

namespace CST150W3A7 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.calculateBtn = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.inputLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.currentIterationLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.calculateBtn.Location = new System.Drawing.Point(254, 69);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // inputTxt
            // 
            this.inputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTxt.Location = new System.Drawing.Point(94, 12);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(235, 23);
            this.inputTxt.TabIndex = 1;
            // 
            // outputTxt
            // 
            this.outputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTxt.Location = new System.Drawing.Point(94, 40);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(235, 23);
            this.outputTxt.TabIndex = 2;
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(47, 15);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(41, 15);
            this.inputLbl.TabIndex = 3;
            this.inputLbl.Text = "Terms:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(46, 43);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(42, 15);
            this.outputLbl.TabIndex = 4;
            this.outputLbl.Text = "Result:";
            // 
            // currentIterationLbl
            // 
            this.currentIterationLbl.AutoSize = true;
            this.currentIterationLbl.Location = new System.Drawing.Point(12, 77);
            this.currentIterationLbl.Name = "currentIterationLbl";
            this.currentIterationLbl.Size = new System.Drawing.Size(76, 15);
            this.currentIterationLbl.TabIndex = 5;
            this.currentIterationLbl.Text = "%Iterations%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(335, 18);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Value = 50;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.currentIterationLbl);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "π approximator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculateBtn;
        private TextBox inputTxt;
        private TextBox outputTxt;
        private Label inputLbl;
        private Label outputLbl;
        private Label currentIterationLbl;
        private ProgressBar progressBar;
    }
}
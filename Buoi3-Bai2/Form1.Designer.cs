namespace Buoi3_Bai2
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Paper = new System.Windows.Forms.Button();
            this.btn_Rock = new System.Windows.Forms.Button();
            this.btn_Scissors = new System.Windows.Forms.Button();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(102, 170);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(139, 20);
            this.txtResult.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Result:";
            // 
            // btn_Paper
            // 
            this.btn_Paper.Location = new System.Drawing.Point(267, 63);
            this.btn_Paper.Name = "btn_Paper";
            this.btn_Paper.Size = new System.Drawing.Size(89, 59);
            this.btn_Paper.TabIndex = 11;
            this.btn_Paper.Text = "Paper";
            this.btn_Paper.UseVisualStyleBackColor = true;
            this.btn_Paper.Click += new System.EventHandler(this.btn_Paper_Click);
            // 
            // btn_Rock
            // 
            this.btn_Rock.Location = new System.Drawing.Point(135, 63);
            this.btn_Rock.Name = "btn_Rock";
            this.btn_Rock.Size = new System.Drawing.Size(94, 59);
            this.btn_Rock.TabIndex = 10;
            this.btn_Rock.Text = "Rock";
            this.btn_Rock.UseVisualStyleBackColor = true;
            this.btn_Rock.Click += new System.EventHandler(this.btn_Rock_Click);
            // 
            // btn_Scissors
            // 
            this.btn_Scissors.Location = new System.Drawing.Point(15, 63);
            this.btn_Scissors.Name = "btn_Scissors";
            this.btn_Scissors.Size = new System.Drawing.Size(89, 59);
            this.btn_Scissors.TabIndex = 9;
            this.btn_Scissors.Text = "Scissors";
            this.btn_Scissors.UseVisualStyleBackColor = true;
            this.btn_Scissors.Click += new System.EventHandler(this.btn_Scissors_Click);
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(102, 13);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(139, 20);
            this.txtChoice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client choice:";
            // 
            // txtSC
            // 
            this.txtSC.Location = new System.Drawing.Point(102, 144);
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(139, 20);
            this.txtSC.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sever choice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 205);
            this.Controls.Add(this.txtSC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Paper);
            this.Controls.Add(this.btn_Rock);
            this.Controls.Add(this.btn_Scissors);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Paper;
        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Scissors;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.Label label3;
    }
}


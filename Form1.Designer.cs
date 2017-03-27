namespace LoveRunAway
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
            this.btn_No = new System.Windows.Forms.Button();
            this.moveAwayButton1 = new LoveRunAway.MoveAwayButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_No
            // 
            this.btn_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_No.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_No.Location = new System.Drawing.Point(423, 177);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(75, 23);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "Không";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.Btn_No_Click);
            // 
            // moveAwayButton1
            // 
            this.moveAwayButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveAwayButton1.BackColor = System.Drawing.Color.Transparent;
            this.moveAwayButton1.ButtonText = "Có";
            this.moveAwayButton1.ChangeColorOnMove = true;
            this.moveAwayButton1.ClickMessage = "OK mình cứ  bất chấp..";
            this.moveAwayButton1.Location = new System.Drawing.Point(230, 151);
            this.moveAwayButton1.Name = "moveAwayButton1";
            this.moveAwayButton1.Size = new System.Drawing.Size(120, 72);
            this.moveAwayButton1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yêu không?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 396);
            this.Controls.Add(this.moveAwayButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_No);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_No;
        private MoveAwayButton moveAwayButton1;
        private System.Windows.Forms.Label label1;
    }
}


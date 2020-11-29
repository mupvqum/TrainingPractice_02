namespace GameOfFttention
{
    partial class SummaryWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.outcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.outcome);
            this.panel1.Location = new System.Drawing.Point(54, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 100);
            this.panel1.TabIndex = 0;
            // 
            // outcome
            // 
            this.outcome.AutoSize = true;
            this.outcome.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.outcome.Location = new System.Drawing.Point(107, 37);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(86, 30);
            this.outcome.TabIndex = 0;
            this.outcome.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(133, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameOfFttention.Properties.Resources.Буквы_3_;
            this.ClientSize = new System.Drawing.Size(485, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SummaryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.Button button1;
    }
}
namespace Resume_Generator
{
    partial class mainPage
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.generateBTN = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(139)))), ((int)(((byte)(170)))));
            this.topPanel.Controls.Add(this.mainTitle);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(590, 100);
            this.topPanel.TabIndex = 0;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(168, 31);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(252, 33);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "RESUME GENERATOR";
            // 
            // generateBTN
            // 
            this.generateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.generateBTN.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBTN.ForeColor = System.Drawing.Color.White;
            this.generateBTN.Location = new System.Drawing.Point(156, 670);
            this.generateBTN.Name = "generateBTN";
            this.generateBTN.Size = new System.Drawing.Size(275, 60);
            this.generateBTN.TabIndex = 1;
            this.generateBTN.Text = "Generate Resume";
            this.generateBTN.UseVisualStyleBackColor = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Location = new System.Drawing.Point(0, 96);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(590, 533);
            this.infoPanel.TabIndex = 2;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.generateBTN);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Generator";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button generateBTN;
        private System.Windows.Forms.Panel infoPanel;
    }
}


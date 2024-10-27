namespace View.Forms
{
    partial class MainForm
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
            this.sqlView = new System.Windows.Forms.DataGridView();
            this.stmtBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlView
            // 
            this.sqlView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlView.Location = new System.Drawing.Point(16, 36);
            this.sqlView.Name = "sqlView";
            this.sqlView.RowHeadersWidth = 82;
            this.sqlView.RowTemplate.Height = 33;
            this.sqlView.Size = new System.Drawing.Size(1101, 406);
            this.sqlView.TabIndex = 2;
            // 
            // stmtBox
            // 
            this.stmtBox.Location = new System.Drawing.Point(16, 485);
            this.stmtBox.Multiline = true;
            this.stmtBox.Name = "stmtBox";
            this.stmtBox.Size = new System.Drawing.Size(1101, 200);
            this.stmtBox.TabIndex = 3;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(338, 735);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(426, 47);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "выполнить";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 857);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.stmtBox);
            this.Controls.Add(this.sqlView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sqlView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sqlView;
        private System.Windows.Forms.TextBox stmtBox;
        private System.Windows.Forms.Button goButton;
    }
}
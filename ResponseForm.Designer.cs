namespace herald
{
    partial class ResponseForm
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
            txtCode = new TextBox();
            txtBody = new TextBox();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.BackColor = Color.White;
            txtCode.Location = new Point(12, 5);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(531, 23);
            txtCode.TabIndex = 0;
            // 
            // txtBody
            // 
            txtBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBody.BackColor = Color.White;
            txtBody.Location = new Point(12, 34);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ReadOnly = true;
            txtBody.ScrollBars = ScrollBars.Vertical;
            txtBody.Size = new Size(531, 242);
            txtBody.TabIndex = 1;
            // 
            // ResponseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 286);
            Controls.Add(txtBody);
            Controls.Add(txtCode);
            Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ResponseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Response";
            Load += ResponseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtBody;
    }
}
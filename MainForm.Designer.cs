namespace herald;

partial class MainForm
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
        label1 = new Label();
        txtUrl = new TextBox();
        btnSend = new Button();
        cboType = new ComboBox();
        lstHeaders = new ListBox();
        label2 = new Label();
        btnAddHeader = new Button();
        txtHeaderLabel = new TextBox();
        txtHeaderValue = new TextBox();
        txtPost = new TextBox();
        btnValidateJson = new Button();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(34, 15);
        label1.TabIndex = 0;
        label1.Text = "URL:";
        // 
        // txtUrl
        // 
        txtUrl.Location = new Point(49, 6);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(417, 23);
        txtUrl.TabIndex = 0;
        txtUrl.Text = "http://www.example.com/";
        // 
        // btnSend
        // 
        btnSend.Location = new Point(656, 6);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(62, 23);
        btnSend.TabIndex = 3;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // cboType
        // 
        cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboType.FormattingEnabled = true;
        cboType.Items.AddRange(new object[] { "GET", "POST", "PUT" });
        cboType.Location = new Point(472, 5);
        cboType.Name = "cboType";
        cboType.Size = new Size(78, 23);
        cboType.TabIndex = 1;
        // 
        // lstHeaders
        // 
        lstHeaders.FormattingEnabled = true;
        lstHeaders.ItemHeight = 15;
        lstHeaders.Location = new Point(12, 100);
        lstHeaders.Name = "lstHeaders";
        lstHeaders.Size = new Size(347, 334);
        lstHeaders.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 54);
        label2.Name = "label2";
        label2.Size = new Size(53, 15);
        label2.TabIndex = 5;
        label2.Text = "Headers:";
        // 
        // btnAddHeader
        // 
        btnAddHeader.Location = new Point(297, 70);
        btnAddHeader.Name = "btnAddHeader";
        btnAddHeader.Size = new Size(62, 23);
        btnAddHeader.TabIndex = 6;
        btnAddHeader.Text = "Add";
        btnAddHeader.UseVisualStyleBackColor = true;
        btnAddHeader.Click += btnAddHeader_Click;
        // 
        // txtHeaderLabel
        // 
        txtHeaderLabel.Location = new Point(12, 71);
        txtHeaderLabel.Name = "txtHeaderLabel";
        txtHeaderLabel.Size = new Size(133, 23);
        txtHeaderLabel.TabIndex = 4;
        // 
        // txtHeaderValue
        // 
        txtHeaderValue.Location = new Point(151, 71);
        txtHeaderValue.Name = "txtHeaderValue";
        txtHeaderValue.Size = new Size(140, 23);
        txtHeaderValue.TabIndex = 5;
        // 
        // txtPost
        // 
        txtPost.Location = new Point(385, 71);
        txtPost.Multiline = true;
        txtPost.Name = "txtPost";
        txtPost.ScrollBars = ScrollBars.Vertical;
        txtPost.Size = new Size(333, 366);
        txtPost.TabIndex = 7;
        txtPost.Text = "{\r\n  \"name\": \"John Doe\",\r\n  \"job\": \"Developer\"\r\n}";
        // 
        // btnValidateJson
        // 
        btnValidateJson.Location = new Point(556, 5);
        btnValidateJson.Name = "btnValidateJson";
        btnValidateJson.Size = new Size(94, 23);
        btnValidateJson.TabIndex = 2;
        btnValidateJson.Text = "Validate Json";
        btnValidateJson.UseVisualStyleBackColor = true;
        btnValidateJson.Click += btnValidateJson_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(385, 53);
        label3.Name = "label3";
        label3.Size = new Size(41, 15);
        label3.TabIndex = 14;
        label3.Text = "JSON:";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(730, 449);
        Controls.Add(label3);
        Controls.Add(btnValidateJson);
        Controls.Add(txtPost);
        Controls.Add(txtHeaderValue);
        Controls.Add(btnAddHeader);
        Controls.Add(txtHeaderLabel);
        Controls.Add(label2);
        Controls.Add(lstHeaders);
        Controls.Add(cboType);
        Controls.Add(btnSend);
        Controls.Add(txtUrl);
        Controls.Add(label1);
        Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Herald";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtUrl;
    private Button btnSend;
    private ComboBox cboType;
    private ListBox lstHeaders;
    private Label label2;
    private Button btnAddHeader;
    private TextBox txtHeaderLabel;
    private TextBox txtHeaderValue;
    private TextBox txtPost;
    private Button btnValidateJson;
    private Label label3;
}

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
        label1.Location = new Point(12, 10);
        label1.Name = "label1";
        label1.Size = new Size(34, 17);
        label1.TabIndex = 0;
        label1.Text = "URL:";
        // 
        // txtUrl
        // 
        txtUrl.Location = new Point(49, 7);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(417, 25);
        txtUrl.TabIndex = 0;
        txtUrl.Text = "http://www.example.com/";
        // 
        // btnSend
        // 
        btnSend.Image = (Image)resources.GetObject("btnSend.Image");
        btnSend.Location = new Point(695, 7);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(78, 26);
        btnSend.TabIndex = 3;
        btnSend.Text = "Send";
        btnSend.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        // 
        // cboType
        // 
        cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboType.FormattingEnabled = true;
        cboType.Items.AddRange(new object[] { "GET", "POST", "PUT" });
        cboType.Location = new Point(472, 6);
        cboType.Name = "cboType";
        cboType.Size = new Size(78, 25);
        cboType.TabIndex = 1;
        // 
        // lstHeaders
        // 
        lstHeaders.FormattingEnabled = true;
        lstHeaders.ItemHeight = 17;
        lstHeaders.Location = new Point(4, 110);
        lstHeaders.Name = "lstHeaders";
        lstHeaders.Size = new Size(418, 429);
        lstHeaders.TabIndex = 8;
        lstHeaders.KeyDown += lstHeaders_KeyDown;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(4, 58);
        label2.Name = "label2";
        label2.Size = new Size(60, 17);
        label2.TabIndex = 5;
        label2.Text = "Headers:";
        // 
        // btnAddHeader
        // 
        btnAddHeader.Image = (Image)resources.GetObject("btnAddHeader.Image");
        btnAddHeader.Location = new Point(289, 76);
        btnAddHeader.Name = "btnAddHeader";
        btnAddHeader.Size = new Size(62, 27);
        btnAddHeader.TabIndex = 6;
        btnAddHeader.Text = "Add";
        btnAddHeader.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnAddHeader.UseVisualStyleBackColor = true;
        btnAddHeader.Click += btnAddHeader_Click;
        // 
        // txtHeaderLabel
        // 
        txtHeaderLabel.Location = new Point(4, 77);
        txtHeaderLabel.Name = "txtHeaderLabel";
        txtHeaderLabel.Size = new Size(133, 25);
        txtHeaderLabel.TabIndex = 4;
        // 
        // txtHeaderValue
        // 
        txtHeaderValue.Location = new Point(143, 77);
        txtHeaderValue.Name = "txtHeaderValue";
        txtHeaderValue.Size = new Size(140, 25);
        txtHeaderValue.TabIndex = 5;
        // 
        // txtPost
        // 
        txtPost.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtPost.Location = new Point(429, 77);
        txtPost.Multiline = true;
        txtPost.Name = "txtPost";
        txtPost.ScrollBars = ScrollBars.Vertical;
        txtPost.Size = new Size(419, 462);
        txtPost.TabIndex = 7;
        txtPost.Text = "{\r\n  \"name\": \"John Doe\",\r\n  \"job\": \"Developer\"\r\n}";
        // 
        // btnValidateJson
        // 
        btnValidateJson.Image = (Image)resources.GetObject("btnValidateJson.Image");
        btnValidateJson.Location = new Point(556, 6);
        btnValidateJson.Name = "btnValidateJson";
        btnValidateJson.Size = new Size(133, 26);
        btnValidateJson.TabIndex = 2;
        btnValidateJson.Text = "Validate Json";
        btnValidateJson.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnValidateJson.UseVisualStyleBackColor = true;
        btnValidateJson.Click += btnValidateJson_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(429, 58);
        label3.Name = "label3";
        label3.Size = new Size(43, 17);
        label3.TabIndex = 14;
        label3.Text = "JSON:";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(855, 558);
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
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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

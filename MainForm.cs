/**
 * MainForm.cs
 * 
 * @author Prahlad Yeri <prahladyeri@yahoo.com>
 * @license MIT
 */
using System.Security.Authentication;
using System.Text;
using System.Text.Json;

namespace herald;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        this.cboType.SelectedIndex = 0;
        lstHeaders.Items.Add("Accept:application/json");
        //lstHeaders.Items.Add("Accept-Encoding:gzip");
        this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        var url = txtUrl.Text;
        HttpMethod method = null;
        switch (cboType.Text)
        {
            case "GET":
                method = HttpMethod.Get;
                break;
            case "POST":
                method = HttpMethod.Post;
                break;
            case "PUT":
                method = HttpMethod.Put;
                break;
        }
        var request = new HttpRequestMessage(method, url);

        if (method != HttpMethod.Get)
        {
            request.Content = new StringContent(txtPost.Text, Encoding.UTF8, "application/json");
        }

        for (var i = 0; i < lstHeaders.Items.Count; i++)
        {
            string[] headers = lstHeaders.Items[i].ToString().Split(":");
            request.Headers.Add(headers[0], headers[1]);
        }
        request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36");

        var handler = new HttpClientHandler
        {
            UseProxy = true,
            UseDefaultCredentials = true,
            SslProtocols = SslProtocols.Tls12,
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
        };


        var client = new HttpClient(handler);
        try
        {
            HttpResponseMessage resp = await client.SendAsync(request);
            string responseBody = await resp.Content.ReadAsStringAsync();
            ResponseForm dialog = new ResponseForm();
            var statusCode = (int)resp.StatusCode;  // numeric code, e.g. 201
            var statusName = resp.StatusCode.ToString(); // name, e.g. "Created"
            dialog.Controls["txtCode"].Text = $"{statusCode} {statusName}";
            dialog.Controls["txtBody"].Text = responseBody;
            dialog.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnAddHeader_Click(object sender, EventArgs e)
    {
        lstHeaders.Items.Add(
            txtHeaderLabel.Text.Trim() +
            ":" +
            txtHeaderValue.Text.Trim()
            );
    }

    private void btnValidateJson_Click(object sender, EventArgs e)
    {
        var json = txtPost.Text;
        bool valid = false;
        try
        {
            if (string.IsNullOrWhiteSpace(json)) {
                valid = false;
            }
            else 
            {
                JsonDocument.Parse(json); 
                valid = true;
            }
        }
        catch (JsonException)
        {
            valid = false;
        }
        var msg = "The Json is " + (valid ? "Valid." : "not Valid.");
        var msgtype = (valid ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        MessageBox.Show(msg, "", MessageBoxButtons.OK, msgtype);
    }
}

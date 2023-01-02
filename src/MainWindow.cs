using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMeGoogleThatWinForms
{
    public partial class MainWindow : Form
    {
        private string baseURL = "https://letmegooglethat.com/?q=";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Glumboi.UI.UIChanger.ChangeTitlebarToDark(Handle);
        }

        private async Task GenerateAsync()
        {
            if (!string.IsNullOrWhiteSpace(GoogleContext_TextBox.Text))
            {
                var generated = baseURL + GoogleContext_TextBox.Text.Replace(' ', '+');
                Output_TextBox.Text = ConvertTextUrlToLink(generated);
                return;
            }
            string originText = "What do you want to google?";
            Color originColor = Color.FromArgb(193, 200, 207);

            GoogleContext_TextBox.PlaceholderForeColor = Color.Red;
            GoogleContext_TextBox.PlaceholderText = "The textbox cant be empty!";

            await Task.Delay(1300);

            GoogleContext_TextBox.PlaceholderForeColor = originColor;
            GoogleContext_TextBox.PlaceholderText = originText;
        }

        private async void Generate_Button_Click(object sender, EventArgs e)
        {
            await GenerateAsync();
        }

        private string ConvertTextUrlToLink(string url)
        {
            string regex = @"((www\.|(http|https|ftp|news|file)+\:\/\/)[_.a-z0-9-]+\.
            [a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)])";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);
            return r.Replace(url, "a href=\"$1\" title=\"Click here to open in a new window or tab\" + " +
                "target =\"_blank\">$1</a>").Replace("href=\"www", "href=\"http://www");
        }

        private async void CopyToClipboard_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Output_TextBox.Text))
            {
                Clipboard.SetText(Output_TextBox.Text);
            }

            Output_TextBox.ForeColor = Color.LimeGreen;
            await Task.Delay(1300);
            Output_TextBox.ForeColor = Color.White;
        }

        private async void GoogleContext_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GenerateAsync();
            }
        }
    }
}
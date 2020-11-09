using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class ImageScraper : Form
    {
        private List<string> ImageURLs = new List<string>();
        private Regex Pattern { get; set; }
        private Regex FileExtension { get; set; }
        private Dictionary<Task<byte[]>, string> Dictionary { get; set; } = new Dictionary<Task<byte[]>, string>();

        public ImageScraper()
        {
            InitializeComponent();
            Pattern = new Regex("<img.*src=\"(.*?(jpg|jpeg|png|gif|bmp).*?)\"");
            FileExtension = new Regex(@"\.(png|jpg|jpeg|gif|bmp)");
        }

        private async void buttonSaveImages_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    await DownloadImages(dialog.SelectedPath);
                }
            }
        }

        private async void buttonExtractImageURLS_Click(object sender, EventArgs e)
        {
            var input = textBoxURLInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            if (!input.Contains("https://"))
            {
                input = $"http://{input}";
            }

            var urlInputTask = ExtractImages(input);
            await urlInputTask;


            var matches = Pattern.Matches(urlInputTask.Result);
            

            for (int i = 0; i < matches.Count; i++)
            {
                var result = "";

                if (matches[i].Value.Contains("http"))
                {
                    result = matches[i].Groups[1].Value;
                }
                else if (!string.IsNullOrWhiteSpace(matches[i].Value))
                {
                    result = "gp.se" + matches[i].Groups[1];
                }

                if (!matches[i].Groups[1].ToString().Contains("https://"))
                {
                    ImageURLs.Add("http://" + result);
                }
                else
                {
                    ImageURLs.Add(result);
                }
                textBox1.Text += result + Environment.NewLine;

                labelNumberOfImages.Text = "Found " + ImageURLs.Count.ToString() + " images.";
            }
        }

        private async Task<string> ExtractImages(string url)
        {
            HttpClient client = new HttpClient();
            var urlInputResult = client.GetStringAsync(url);

            await urlInputResult;

            return urlInputResult.Result;
        }


        private async Task DownloadImages(string path)
        {
            using var client = new HttpClient();
            var imageArray = ImageURLs.ToArray();

            foreach (var image in imageArray)
            {
                var match = FileExtension.Matches(image);
                Dictionary.Add(client.GetByteArrayAsync(image), match[0].Groups[1].Value);
            }

            var i = 1;
            var tasks = Dictionary.Keys;
            while (Dictionary.Count > 0)
            {
                var finishedTasks = await Task.WhenAny(tasks);
                var extension = Dictionary[finishedTasks];
                var result = finishedTasks.Result;

                var fileSream = new FileStream($"{path}\\image{i}.{extension}", FileMode.Create);
                await fileSream.WriteAsync(result, 0, result.Length);
                i++;

                Dictionary.Remove(finishedTasks);
            }
                MessageBox.Show($"Downloaded {i-1} images out of {ImageURLs.Count}");
        }
    }
}

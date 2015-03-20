using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITVM3U8Monitor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public int powerState = 0;
        ClassChannelName channelname = new ClassChannelName();
        ChannelPort channelport = new ChannelPort();
        public MainWindow()
        {
            InitializeComponent();

            string ss=Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MainWindow1.Title += "   成都爱家TV   " + ss;

        }

        private async void ButtonPower_Click(object sender, RoutedEventArgs e)
        {

                
                resultsTextBox.Clear();
                await SumPageSizesAsync();
                resultsTextBox.Text += "\r\n下载完成.\r\n";


        }

        private async Task SumPageSizesAsync()
        {
            // Make a list of web addresses.
            List<string> urlList = SetUpURLList();

            // Create a query. 
            IEnumerable<Task<int>> downloadTasksQuery =
                from url in urlList select ProcessURLAsync(url);

            // Use ToArray to execute the query and start the download tasks.
            Task<int>[] downloadTasks = downloadTasksQuery.ToArray();

            // You can do other work here before awaiting.

            // Await the completion of all the running tasks.
            int[] lengths = await Task.WhenAll(downloadTasks);

            //// The previous line is equivalent to the following two statements.
            //Task<int[]> whenAllTask = Task.WhenAll(downloadTasks);
            //int[] lengths = await whenAllTask;

            int total = lengths.Sum();


            // Display the total count for all of the websites.
            resultsTextBox.Text +=
                string.Format("\r\n\r\nTotal bytes returned:  {0}\r\n", total);
        }

        private List<string> SetUpURLList()
        {
            List<string> urls = new List<string>();
            string key = "";
            if (textboxKey.Text != "")
            {
                key = "&key=" + textboxKey.Text;


                foreach (var val in channelname.chitem)
                {
                    urls.Add("http://218.200.229.165:10009/m3u8/m3u8?id=" + val.tvid + "&version=1&rate=400k" + key);
                    urls.Add("http://218.200.229.165:10009/m3u8/m3u8?id=" + val.tvid + "&version=1&rate=1000k" + key);
                }
            }
            else
            {
                Random rm = new Random();
                foreach(var val in channelport.chitem)
                {
                    
                    urls.Add(val.URL+"?v="+rm.Next(2000));
                }

            }
            return urls;
        }



        // The actions from the foreach loop are moved to this async method.
        private async Task<int> ProcessURLAsync(string url)
        {
            var byteArray = await GetURLContentsAsync(url);
            DisplayResults(url, byteArray);
            return byteArray.Length;
        }


        private async Task<byte[]> GetURLContentsAsync(string url)
        {
            // The downloaded resource ends up in the variable named content.
            var content = new MemoryStream();

            // Initialize an HttpWebRequest for the current URL.
            var webReq = (HttpWebRequest)WebRequest.Create(url);

            //webReq.UserAgent = "AppleCoreMedia/1.0.0.12B436 (iPhone; U; CPU OS 8_1_1 like Mac OS X; zh_cn)";
            // Send the request to the Internet resource and wait for
            // the response.
            using (WebResponse response = await webReq.GetResponseAsync())
            {
                // Get the data stream that is associated with the specified url.
                using (Stream responseStream = response.GetResponseStream())
                {
                    await responseStream.CopyToAsync(content);
                }
            }

            // Return the result as a byte array.
            return content.ToArray();

        }

        public static DateTime ConverToTime(int time)
        {
            DateTime time197011 = new DateTime(1970, 1, 1);
            time197011 = time197011.AddSeconds(time);
            TimeZone localZone = TimeZone.CurrentTimeZone;
            TimeSpan ts = localZone.GetUtcOffset(time197011);
            time197011 += ts;

            return time197011;
        }
        private void DisplayResults(string url, byte[] content)
        {
            // Display the length of each website. The string format 
            // is designed to be used with a monospaced font, such as
            // Lucida Console or Global Monospace.
            var bytes = content.Length;
            if (bytes == 0)
                return;
            string strcontent = System.Text.Encoding.UTF8.GetString(content);
            //string strcontent = BitConverter.ToString(content);
            var lines = strcontent.Split(new char[] { '\n' });


            if (textboxKey.Text != "")
            {
                int i = lines.Count();
                var lastline = lines[i - 2];
                var streamtime = lastline.Split(new char[] { '_' })[2].Split(new char[] { '.' })[0];
                DateTime dt = ConverToTime(int.Parse(streamtime));
                string status = "";
                if (DateTime.Now.Subtract(dt).TotalMinutes > 10)
                {
                    status = "   错误！";
                }
                // Strip off the "http://".
                var displayURL = url.Replace("http://", "");
                var para = displayURL.Split(new char[] { '?' })[1];
                var id = para.Split(new char[] { '&' })[0].Split(new char[] { '=' })[1];
                var rate = para.Split(new char[] { '&' })[2].Split(new char[] { '=' })[1];

                var name = "";
                foreach (var val in channelname.chitem)
                {
                    if (val.tvid == id)
                        name = val.name;
                }


                resultsTextBox.Text += string.Format("{0} {1,-8} {2,-8} {3,-8} {4,-16} \n ", name.PadRight(30, ' '), id, rate, bytes + "bytes", dt.ToString() + status);
            }
            else
            {
                int i = lines.Count();
                var lastline = lines[i - 1];
                var streamtime = lastline.Split(new char[] { '_' })[2].Split(new char[] { '.' })[0];
                DateTime dt = ConverToTime(int.Parse(streamtime));
                string status = "";
                if (DateTime.Now.Subtract(dt).TotalMinutes > 10)
                {
                    status = "   错误！";
                }
                var displayURL = url.Replace("http://", "");
                var para = displayURL.Split(new char[] { '/' })[2];
                var id = para.Split(new char[] { '.' })[0].Split(new char[] { '-' })[1];

                var name = "";
                foreach (var val in channelport.chitem)
                {
                    if (val.ChannelId == id)
                        name = val.ServiceId;
                }

                resultsTextBox.Text += string.Format("{0} {1,-8} {2,-8} {3,-16} \n ", name.PadRight(30, ' '), id, bytes + "bytes", dt.ToString() + status);
            }


        }


    }
}

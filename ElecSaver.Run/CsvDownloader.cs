
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElecSaver.Run
{
    public class CsvDownloader
    {
        public string Url { get; set; }
        public async Task<string> DownloadAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(Url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}

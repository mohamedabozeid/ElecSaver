using System;
using System.Threading.Tasks;

namespace ElecSaver.Run
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            CsvDownloader downloader = new CsvDownloader();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string url = $"https://www1.electricityinfo.co.nz/download/prices?search_form[run_types][]=A&search_form[run_types][]=I&search_form[market_types][]=E&search_form[nodes][]=BEN2201&search_form[nodes][]=HAY2201&search_form[nodes][]=OTA2201&search_form[date_from]={date}&search_form[date_to]={date}&search_form[tp_from]=1&search_form[tp_to]=48&search_form[tp_roll_back]=7&search_form[tp_roll_fwd]=7";
            downloader.Url = url;
            string content = await downloader.DownloadAsync();
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}

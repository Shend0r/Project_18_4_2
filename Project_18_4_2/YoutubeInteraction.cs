using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Project_18_4_2
{
    internal class YoutubeInteractions : IYoutubeInteraction
    {
        YoutubeClient youtubeClient { get; set; }
        protected string link { get; set; }

        public YoutubeInteractions(string link)
        {
            this.link = link;
            youtubeClient = new YoutubeClient();
        }

        async void IYoutubeInteraction.ShowDescription()
        {
            var video = await youtubeClient.Videos.GetAsync(link);

            Console.WriteLine("Описание видео :");
            Console.WriteLine(video.Author.Title);
            Console.WriteLine(video.Title);
            Console.WriteLine(video.Description);
        }

        async void IYoutubeInteraction.Download()
        {
            var video = await youtubeClient.Videos.GetAsync(link);
            var title = video.Title;
            Console.WriteLine("Началась загрузка видео...");
            await youtubeClient.Videos.DownloadAsync(link, string.Format("{0}.{1}", title, "mp4"));
            Console.WriteLine("Видео успешно загружено!");
        }

    }
}

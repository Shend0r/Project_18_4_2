using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_18_4_2
{
    internal class Handler
    {
        protected Sender sender { get; set; }
        protected string link { get; set; }

        public void Start()
        {
            Console.WriteLine("Введите ссылку на Youtube-видео :");

            link = Console.ReadLine();
            sender = new Sender(new YoutubeInteractions(link));

            Recursive(sender);
        }

        public void Recursive(Sender sender)
        {
            Console.WriteLine("Введите аргумент (/new_link; /description; /download или пустую строку для выхода) :");

            string argument = Console.ReadLine();

            switch (argument)
            {
                case "/new_link":
                    {
                        Start();
                    }
                    break;

                case "/description":
                    {
                        sender.ShowDescription();
                    }
                    break;

                case "/download":
                    {
                        sender.Download();
                    }
                    break;

                default:
                    {
                        Environment.Exit(0);
                    }
                    break;
            }

            Recursive(sender);
        }
    }
}

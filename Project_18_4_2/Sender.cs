using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_18_4_2
{
    internal class Sender
    {

        IYoutubeInteraction interaction { get; set; }

        public Sender(IYoutubeInteraction interaction)
        {
            this.interaction = interaction;
        }

        public void ShowDescription()
        {
            interaction.ShowDescription();
        }

        public void Download()
        {
            interaction.Download();
        }
    }
}

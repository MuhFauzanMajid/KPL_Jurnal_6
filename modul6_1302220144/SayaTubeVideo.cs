using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220144
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();

            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video id : " + id);
            Console.WriteLine("Video title : " + title);
            Console.WriteLine("Video play count : " + playCount);
        }

        public int getPlayCount()
        {
            return playCount;
        }
        public string getTitle()
        {
            return title;
        }
    }
}

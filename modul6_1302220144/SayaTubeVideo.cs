using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Debug.Assert(!string.IsNullOrEmpty(title), "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 200, "Panjang judul tidak boleh melebihi 200 karakter");
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "maksimum penambahan play count adalah 25.000.000 untuk setiap panggilan");
            Debug.Assert(playCount >=0, "input tidak boleh negatif");
            try
            {
                int tes = checked(this.playCount + playCount);
                this.playCount = tes;
            }
            catch (Exception overFlow)
            {
                Console.WriteLine(overFlow.Message);
            }
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

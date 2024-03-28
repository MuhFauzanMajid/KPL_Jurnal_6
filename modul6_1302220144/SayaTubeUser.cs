using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220144
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(String username){
            uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for(int i = 0; i < this.uploadedVideos.Count; i++)
            {
                total = total + uploadedVideos[i].getPlayCount();
            }
            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void printAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            for(int i = 1;i <= uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video "+ i +" judul " + uploadedVideos[i-1].getTitle());
            }

        }
    }
}

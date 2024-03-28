using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Random random = new Random();

            uploadedVideos = new List<SayaTubeVideo>();
            Debug.Assert(username.Length <= 100, "Maksimal panjang karakter username adalah 100 karakter");
            Debug.Assert(!string.IsNullOrEmpty(username), "Username tidak boleh kosong");
            this.username = username;
            this.id = random.Next(10000, 99999);
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
            Debug.Assert(video != null, "Video tidak boleh kosong");
            Debug.Assert(video.getPlayCount() < int.MaxValue, "Playcount pada video tidak boleh melebihi bilangan maksimum integer");
            uploadedVideos.Add(video);
        }

        public void printAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            for(int i = 1;i <= 8; i++)
            {
                Console.WriteLine("Video "+ i +" judul " + uploadedVideos[i-1].getTitle());
                Console.WriteLine("Play Count video : " + uploadedVideos[i].getPlayCount());
            }
        }
    }
}

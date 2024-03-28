using modul6_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Muhammad Fauzan Majid");
        SayaTubeVideo video;
        video = new SayaTubeVideo("Review of Cars oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of Fast oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of Furious oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of Idk oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of What oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of To oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of Input oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of Spiderman oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of dune oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        video = new SayaTubeVideo("Review of dune 2 oleh Muhammad Fauzan Majid");
        user.addVideo(video);
        user.printAllVideoPlaycount();
    }
}
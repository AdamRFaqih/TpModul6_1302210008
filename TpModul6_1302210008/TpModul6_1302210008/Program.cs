class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = 0;

    }

    public void increasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("Judul Video: " + "[" + id + "]" + title);
        Console.WriteLine("Views: " + playCount);
    }
}

class Utama
{
    public static void Main()
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract – [ADAM RAFIF FAQIH]");
        sayaTubeVideo.increasePlayCount(1000);
        sayaTubeVideo.printVideoDetails();
    }
}
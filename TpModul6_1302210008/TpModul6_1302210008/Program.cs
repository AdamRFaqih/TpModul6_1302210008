using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != "","JUDUL TIDAK BOLEH KOSONG");
        Debug.Assert(title.Length <= 100, "JUDUL TIDAK BOLEH LEBIH DARI 100 KARAKTER");
        this.isStringNull(title);
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
        this.isStringNull(this.title);
    }

    public void increasePlayCount(int playCount)
    {
        Debug.Assert(playCount <= 10000000, "INPUT TIDAK BOLEH LEBIH DARI 10 JUTA");
        //this.playCount += playCount;
        
        checked
        {
                this.playCount += playCount;
        }
        isIntegerOverflow(this.playCount);
    }

    public void printVideoDetails()
    {
        Console.WriteLine("Judul Video: " + "[" + this.id + "]" + this.title);
        Console.WriteLine("Views: " + this.playCount);
    }

    private void isStringNull(string title)
    {
        if (String.IsNullOrEmpty(title))
        {
            throw new ArgumentNullException("INPUT JANGAN NULL");
        }

        if (String.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentNullException("INPUT JANGAN WHITESPACE");
        }
    }

    private void isIntegerOverflow(int masuk)
    {
        if (masuk >= int.MaxValue || masuk <= int.MinValue)
        {
            throw new OverflowException("PENUH");
        }
    }
}

class Utama
{
    public static void Main()
    {
        try
        {
            SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract – [ADAM RAFIF FAQIH]");
            int a = int.MaxValue;
            sayaTubeVideo.increasePlayCount(a);

            sayaTubeVideo.printVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
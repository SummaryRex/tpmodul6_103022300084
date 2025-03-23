using tpmodul6_103022300084;
class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Design by Contract Fathian Alfiana");
        
        for (int i =0; i < 1000; i++)
        {
            video.IncreasePlayCount(6969);
        }
        video.PrintVideoDetails();
    }
}
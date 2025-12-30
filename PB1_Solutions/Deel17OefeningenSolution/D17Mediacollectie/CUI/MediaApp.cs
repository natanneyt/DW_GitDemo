using D17Mediacollectie.Domein;

namespace D17Mediacollectie.CUI
{
    internal class MediaApp
    {
        static void Main(string[] args)
        {
            MediaManager manager = new MediaManager();
            manager.LeesMedia(@".\D17Mediacollectie\Data\mediaitems.txt");

            List<MediaItem> media = manager.GeefMedia();
            if(media.Count() > 0)
            {
                foreach(MediaItem mediaItem in media)
                {
                    Console.WriteLine(mediaItem);
                }
            }

            string foutenlijstPad = @".\D17Mediacollectie\Data\foutenlijst.txt";
            if (Path.Exists(foutenlijstPad))
                Console.WriteLine($"\nEr zijn fouten opgetreden: zie {foutenlijstPad}");
        }
    }
}

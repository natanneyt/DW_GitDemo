using D17Mediacollectie.Persistentie;

namespace D17Mediacollectie.Domein
{
    internal class MediaManager
    {
        private List<MediaItem> _media = new List<MediaItem>();

        public void LeesMedia(string relatiefPad)
        {
            MediaBestandIO mediaIO = new MediaBestandIO();
            _media = mediaIO.LeesMedia(relatiefPad);
        }

        public List<MediaItem> GeefMedia()
        {
            return _media;
        }
    }
}

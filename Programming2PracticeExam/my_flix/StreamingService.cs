using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class StreamingService
    {
        private List<Video> Library = new List<Video>();
        private Dictionary<int, bool> WatchStatus = new Dictionary<int, bool>();

        public void AddVideo(Video mediaObject)
        {
            Library.Add(mediaObject);

            WatchStatus.Add(mediaObject.Id, false);
        }

        public Video FindByVideoBYId(int ID)
        {
            foreach (Video video in Library) 
                if (video.Id == ID) return video;

            throw new VideoNotFoundException($"video with id {ID} not found");
        }

        public void WatchVideo(int ID)
        {
            Video requestedVideo = FindByVideoBYId(ID);

            requestedVideo.StartStream();
            requestedVideo.EndStream();

            WatchStatus[requestedVideo.Id] = true;
        }

        List<Video> GetVideosByStatus(bool isWatched)
        {
            List<Video> filteredListOfVideos = new List<Video>();
            
            foreach (Video video in Library)
                if (WatchStatus[video.Id] == isWatched)
                    filteredListOfVideos.Add(video);

            return filteredListOfVideos;
        }

        int GetTotalDurationOfVideos(List<Video> list)
        {
            int sum = 0;

            foreach(Video video in list)
                sum += video.Duration;

            return sum;
        }

        void DisplayVideos(List<Video> list)
        {
            foreach (Video video in list)
                video.DisplayInfo();
        }

        public void DisplayReport()
        {
            Console.WriteLine("Streaming service report:");
            
            List<Video> watchedVideos = GetVideosByStatus(true);
            int totalMinutesWatched = GetTotalDurationOfVideos(watchedVideos);
            Console.WriteLine($"Total minutes watched: {totalMinutesWatched}");
            Console.WriteLine();
            Console.WriteLine("Watched videos:");
            DisplayVideos(watchedVideos);
            Console.WriteLine();

            List<Video> yetToDiscover = GetVideosByStatus(false);
            Console.WriteLine("Unwatched videos:");
            DisplayVideos(yetToDiscover);
        }
    }
}

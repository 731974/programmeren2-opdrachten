using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class StreamingService
    {
        private List<Video> library = new List<Video>();
        private Dictionary<int, bool> watchStatus = new Dictionary<int, bool>();

        public void AddVideo(Video mediaObject)
        {
            library.Add(mediaObject);

            watchStatus.Add(mediaObject.Id, false);
        }

        public Video FindByVideoById(int ID)
        {
            foreach (Video video in library) 
                if (video.Id == ID) return video;

            throw new VideoNotFoundException($"video with id {ID} not found");
        }

        public void WatchVideo(int ID)
        {
            Video requestedVideo = FindByVideoById(ID);

            requestedVideo.StartStream();
            requestedVideo.EndStream();

            watchStatus[requestedVideo.Id] = true;
        }

        List<Video> GetVideosByStatus(bool isWatched)
        {
            List<Video> filteredListOfVideos = new List<Video>();
            
            foreach (Video video in library)
                if (watchStatus[video.Id] == isWatched)
                    filteredListOfVideos.Add(video);

            return filteredListOfVideos;
        }

        int GetTotalDurationOfVideos(List<Video> list)
        {
            int totalDuration = 0;

            foreach (Video video in list)
                totalDuration += video.Duration;

            return totalDuration;
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

            Console.WriteLine("Unwatched videos:");
            DisplayVideos(GetVideosByStatus(false));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class VideoSaver
    {
        private string filePath;

        public VideoSaver(string filePath)
        {
            this.filePath = filePath;
        }

        public void Save(List<Video> videosToSave)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath)) {
                    foreach (Video video in videosToSave)
                        sw.WriteLine(video.ToString());
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public StreamingService Load()
        {
            List<Video> videosToLoad = new List<Video>();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] fields = streamReader.ReadLine().Split('|');

                        if (fields[0] == "Movie")
                            videosToLoad.Add(new Movie(int.Parse(fields[5]), fields[1], fields[2], int.Parse(fields[3]), fields[4]));
                        else if (fields[0] == "TVEpisode")
                            videosToLoad.Add(new TVEpisode(int.Parse(fields[6]), fields[1], fields[2], int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[5])));
                        else
                            throw new Exception("Not supported medium format");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            StreamingService streamingService = new StreamingService();
            return AddLoadedFilesToStreamingService(streamingService, videosToLoad);
        }

        StreamingService AddLoadedFilesToStreamingService(StreamingService service, List<Video> list)
        {
            foreach (Video medium in list)
                service.AddVideo(medium);

            return service;
        }
    }
}

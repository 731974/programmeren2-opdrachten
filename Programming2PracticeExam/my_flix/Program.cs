namespace my_flix
{
    internal class Program
    {
        const string FilePath = "../../../saves.txt";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            //OPDR1
            List<Video> streamableContent = new List<Video>();

            streamableContent.Add(new Movie(1, "Epic", "Animation", 96, "Walt Disney"));
            streamableContent.Add(new Movie(2, "Tar", "Drama", 158, "Todd Field"));

            streamableContent.Add(new TVEpisode(3, "The Office", "Comedy", 22, 4, 13));
            streamableContent.Add(new TVEpisode(4, "The Bear", "Action", 48, 2, 21));

            //DisplayMovieInfo(streamableContent);

            //OPDR2
            //StreamingService streamingService = new StreamingService();
            //streamingService.AddVideo(new Movie(1, "Epic", "Animation", 96, "Walt Disney"));
            //streamingService.AddVideo(new Movie(2, "Tar", "Drama", 158, "Todd Field"));

            //streamingService.AddVideo(new TVEpisode(3, "The Office", "Comedy", 22, 4, 13));
            //streamingService.AddVideo(new TVEpisode(4, "The Bear", "Action", 48, 2, 21));

            //streamingService.WatchVideo(2);
            //streamingService.WatchVideo(4);
            //Console.WriteLine();

            //streamingService.DisplayReport();

            //OPDR3
            VideoSaver saver = new VideoSaver(FilePath);
            saver.Save(streamableContent);

            StreamingService streamingService = saver.Load();
            streamingService.WatchVideo(2);
            streamingService.DisplayReport();

            try
            {
                Video video = streamingService.FindByVideoById(5);
            }
            catch (VideoNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void DisplayMovieInfo(List<Video> list)
        {
            foreach (Video streamable in list)
                streamable.DisplayInfo();
        }
    }
}

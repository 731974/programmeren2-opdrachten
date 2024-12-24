using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal class Movie : Video
    {

        public string Director { get; }

        public Movie(int id, string title, string genre, int duration, string director) : base(id, title, genre, duration)
        {
            Director = director;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Movie] Title: {Title}, Genre: {Genre}, Duration: {Duration} mins, Director: {Director}, ID: {Id}");
        }

        public override string ToString() {
            return $"{base.GetType().Name}|{Title}|{Genre}|{Duration}|{Director}|{Id}";
        }

    }
}

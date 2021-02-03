using System;

namespace HomeworkLesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt croptop = new Shirt("croptop", "blue", 40, "round", "reglan");
        }
    }
    public abstract class Clothes
    {
        private string _id;
        public string Title;
        public string Color;
        public int Size;

        public Clothes (string Title, string Color, int Size)
        {
            this.Title = Title;
            this.Color = Color;
            this.Size = Size;
        }
    }
    public class Shirt : Clothes
    {
        public string Neckline;
        public string Sleeve;

        public Shirt(string Title, string Color, int Size, string Neckline, string Sleeve) : base(Title, Color, Size)

        {
            this.Neckline = Neckline;
            this.Sleeve = Sleeve;
        }
    }
}

namespace Задание_8._2
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Random random = new Random();


            Area area1 = new Area();
            area1.numberPeople = random.Next(1, 5);
            area1.length = random.Next(1,30);
            area1.width = random.Next(1,30);

            Area area2 = new Area();
            area2.numberPeople = random.Next(1, 5);
            area2.length = random.Next(1, 30);
            area2.width = random.Next(1, 30);

            Area area3 = new Area();
            area3.numberPeople = random.Next(1, 5);
            area3.length = random.Next(1, 30);
            area3.width = random.Next(1, 30);

            Area area4 = new Area();
            area4.numberPeople = random.Next(1, 5);
            area4.length = random.Next(1, 30);
            area4.width = random.Next(1, 30);

            Area area5 = new Area();
            area5.numberPeople = random.Next(1, 5);
            area5.length = random.Next(1, 30);
            area5.width = random.Next(1, 30);

            SquareCheck();
            AreaEstimate();
        }

        //public int SetRandom(random)
        //{
        //    
        //    return numberPeople;
        //}

        public class Area
        {
            public int numberPeople;
            public int length;
            public int width;
        }

        public bool SquareCheck ()
        {

            return true;
        }

        public int AreaEstimate (int numberPeople, int length, int width)
        {

            return 0;
        }

        public void Display()
        {
            Console.WriteLine();

        }

    }
}
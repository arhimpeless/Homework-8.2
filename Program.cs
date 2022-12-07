namespace Задание_8._2
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Random random = new Random();

            Area area1 = new Area();
            area1.numberPeople = random.Next(1, 5);
            area1.length = random.Next(1, 30);
            area1.width = random.Next(1, 30);

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

            area1.squere = Squere(area1.length, area1.width);
            area2.squere = Squere(area2.length, area2.width);
            area3.squere = Squere(area3.length, area3.width);
            area4.squere = Squere(area4.length, area4.width);
            area5.squere = Squere(area5.length, area5.width);

            area1.areaEstimate = AreaEstimate(area1.numberPeople, area1.squere);
            area2.areaEstimate = AreaEstimate(area2.numberPeople, area2.squere);
            area3.areaEstimate = AreaEstimate(area3.numberPeople, area3.squere);
            area4.areaEstimate = AreaEstimate(area4.numberPeople, area4.squere);
            area5.areaEstimate = AreaEstimate(area5.numberPeople, area5.squere);
            SquareCheck();

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
            public double areaEstimate;
            public int squere;
        }

        public int Squere(int length, int width)
        {
            int squere = length * width;
            return squere;
        }

        public bool SquareCheck(int length, int width)
        {
            bool squareCheck = false;
            double coefficient = length / width;

            int delta = 1;
            int result;
            foreach (var val in coefficient)
            {
                if (Math.Abs(1 - val) < delta)
                {
                    delta = Math.Abs(1 - val);
                    result = val;
                }
            }

            return true;
        }

        public double AreaEstimate(int numberPeople, int squere)
        {
            double areaEstimate = squere / numberPeople;
            return areaEstimate;
        }

        public void Display(double areaEstimate)
        {
            Console.WriteLine("На первом участке на одного жителя выходит: " + area1.areaEstimate + " м^2.");
            Console.WriteLine("На втором участке на одного жителя выходит: " + area2.areaEstimate + " м^2.");
            Console.WriteLine("На третьем участке на одного жителя выходит: " + area3.areaEstimate + " м^2.");
            Console.WriteLine("На четвёртом участке на одного жителя выходит: " + area4.areaEstimate + " м^2.");
            Console.WriteLine("На пятом участке на одного жителя выходит: " + area5.areaEstimate + " м^2.");


        }

    }
}
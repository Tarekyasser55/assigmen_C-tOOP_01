namespace assigmen_C_tOOP_01
{
    internal class Program
    {
        //q5
        public static double distans(Point p1,Point p2)
        {
            double dx = p2.x - p1.x;
            double dy = p2.y - p1.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static void Main(string[] args)
        {
            #region q1
            //for (int i=0;i<7;i++)
            //{


            //   WeeekDays weekday = (WeeekDays)i;
            //    Console.WriteLine(weekday+"\n");

            //}
            //Console.ReadLine();

            #endregion
            #region q2
            //Person[] array = new Person[3];
            //array[0] = new Person();
            //array[1] = new Person();
            //array[2] = new Person();
            //Console.Write("enter the name person1:");
            //array[0].Name = Console.ReadLine()!;
            //Console.Write("enter the age person1:");
            //array[0].Age = int.Parse(Console.ReadLine()!);

            //Console.Write("enter the name person2:");
            //array[1].Name = Console.ReadLine()!;
            //Console.Write("enter the age person2:");
            //array[1].Age = int.Parse(Console.ReadLine()!);

            //Console.Write("enter the name person3:");
            //array[2].Name = Console.ReadLine()!;
            //Console.Write("enter the age person3:");
            //array[2].Age = int.Parse(Console.ReadLine()!);
            //for (int i = 0; i < array.Length; i++)
            //{

            //    Console.WriteLine($" the name of person{i + 1} is {array[i].Name} and the age for this is {array[i].Age}\n");

            //}
            #endregion

            #region q3
            //Console.Write("ener the season name:");

            //string input = (Console.ReadLine()!);
            //bool result = Enum.TryParse(input, true, out Seas_On selectedSeas);
            //if (result)
            //{
            //    switch (selectedSeas)
            //{

            //    case Seas_On.Spring:
            //            Console.WriteLine("spring months: march to may");
            //            break;
            //        case Seas_On.Summer:
            //            Console.WriteLine("summer months: june to August");
            //            break;
            //        case Seas_On.Autumn:
            //            Console.WriteLine("Autumn months: september to Novenber");
            //            break;
            //        case Seas_On.Winter:
            //            Console.WriteLine("Winter months: December to Februaryr");
            //            break;

            //    }

            //}
            //    else
            //        Console.WriteLine("invalid name season");
            #endregion

            #region q4
            //Console.Write("enter the Color:");
            //string input = Console.ReadLine()!;
            //bool result = Enum.TryParse(input, true, out Colors color);
            //if (result)
            //{
            //    switch (color)
            //    {



            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine("Color is primary");
            //            break;


            //    }
            //}
            //else
            //    Console.WriteLine("this color not primary");
            #endregion

            #region q5
            //Console.WriteLine("enter the first point");
            //Console.Write("enter the x1:");
            //double x1 = double.Parse(Console.ReadLine()!);
            //Console.Write("enter the y1:");
            //double y1 = double.Parse(Console.ReadLine()!);

            //Console.WriteLine("enter the seconde point");
            //Console.Write("enter the x2:");
            //double x2 = double.Parse(Console.ReadLine()!);
            //Console.Write("enter the y2:");
            //double y2 = double.Parse(Console.ReadLine()!);


            //Point point1 = new Point();
            //Point point2 = new Point();
            //point1.x = x1;  point1.y = y1;
            //point2.y = y2; point2.x = x2;

            //Console.WriteLine($"the distans between two point is: {distans(point1,point2)}");
            #endregion

            #region q6
            //Person[] array = new Person[3];
            //array[0] = new Person();
            //array[1] = new Person();
            //array[2] = new Person();
            //Console.Write("enter the name person1:");
            //array[0].Name = Console.ReadLine()!;
            //Console.Write("enter the age person1:");
            //array[0].Age = int.Parse(Console.ReadLine()!);

            //Console.Write("enter the name person2:");
            //array[1].Name = Console.ReadLine()!;
            //Console.Write("enter the age person2:");
            //array[1].Age = int.Parse(Console.ReadLine()!);

            //Console.Write("enter the name person3:");
            //array[2].Name = Console.ReadLine()!;
            //Console.Write("enter the age person3:");
            //array[2].Age = int.Parse(Console.ReadLine()!);
            //if (array[0].Age > array[1].Age && array[0].Age > array[2].Age)
            //    Console.WriteLine($"the oldest person number 1  name is : {array[0].Name} and the age is: {array[0].Age}");
            //else if (array[1].Age > array[0].Age && array[1].Age > array[2].Age)
            //    Console.WriteLine($"the oldest person number2  name is : {array[1].Name} and the age is: {array[1].Age}");
            //else 
            //    Console.WriteLine($"the oldest person number3  name is : {array[2].Name} and the age is: {array[2].Age}");
            #endregion


        }
    }
}

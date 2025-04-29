namespace datetimelesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime1 = DateTime.Now;
            DateTime datetime2 = DateTime.Today;

            DateTime dateofthebirth = new DateTime(2010, 01, 20);
            Console.WriteLine(dateofthebirth);




            Console.WriteLine(datetime1.Year);
            Console.WriteLine(datetime1.Day);
            Console.WriteLine(datetime1.DayOfWeek);
            Console.WriteLine(datetime1.DayOfYear);
            Console.WriteLine(datetime1.Nanosecond);

            Console.WriteLine(datetime1);


            Console.WriteLine(datetime1.ToString("M:dd:yyyy"));
            Console.WriteLine(datetime1.ToString("f"));
            Console.WriteLine(datetime1.ToLongDateString());
            Console.WriteLine(datetime1.ToLongTimeString());


            Console.WriteLine(datetime1.AddDays(10));
            Console.WriteLine(datetime1.AddDays(-10));

            Console.WriteLine(datetime1.AddHours(2));
            Console.WriteLine(datetime1.AddYears(10));


            TimeSpan ts = new TimeSpan(10, 3, 20, 1);


            Console.WriteLine(datetime1.Add(TimeSpan.Parse("10:3:20:1")));


            Console.WriteLine("yyyy-MM-dd");
            string date=Console.ReadLine();

            DateTime dateTime = (DateTime.Parse(date));

            Console.WriteLine(dateTime);










        }
    }
}

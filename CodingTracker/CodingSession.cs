namespace CodingTracker
{
    internal class CodingSession
    {
        public string Id = "";
        public DateTime startTime;
        public DateTime endTime;
        public DateTime duration;

        public CodingSession()
        {
            StartTimer();
        }

        public static void StartTimer()
        {
            Console.WriteLine("\n\nCoding Session Has Begun.\n\n");

            //string startTime = ParseTime();

            DateTime startTime = DateTime.Now;
            DateTime endTime;
            if (DateTime.TryParse(startTime.ToString(), out startTime))
            {
                Console.WriteLine(startTime.ToString("MM-dd-yy HH:mm:ss"));
            }
            else
            {
                Console.Error.WriteLine("DateTime UnParsable.");
            }

            Console.WriteLine("Press 0 to End Coding Session.");
            string answer = Console.ReadLine();

            //Check to End
            while (answer != "0") answer = Console.ReadLine();


            //endTime = ParseTime();

            endTime = DateTime.Now;
            if (DateTime.TryParse(startTime.ToString(), out startTime))
            {
                Console.WriteLine(startTime.ToString("MM-dd-yy HH:mm:ss"));
            }
            else
            {
                Console.Error.WriteLine("DateTime UnParsable.");
            }

            TimeSpan duration = endTime.Subtract(startTime);
            Console.WriteLine(ConvertTimeSpanToString(duration));

            EndSession();
        }

        static string ParseTime()
        {
            DateTime dateTime = DateTime.Now;

            if (DateTime.TryParse(dateTime.ToString(), out dateTime))
            {
                return dateTime.ToString("MM-dd-yy HH:mm:ss");
            }
            else
            {
                Console.Error.WriteLine("DateTime UnParsable.");
                return "";
            }


        }
        public static string ConvertTimeSpanToString(TimeSpan ts)
        {

            var days = $"{ts.Days} day{Plural(ts.Days)}";

            var hours = $"{ts.Hours} hour{Plural(ts.Hours)}";

            var minutes = $"{ts.Minutes} minute{Plural(ts.Minutes)}";

            var seconds = $"{ts.Seconds} second{Plural(ts.Seconds)}";

            var milliSeconds = $"{ts.Milliseconds} milliseconde{Plural(ts.Milliseconds)}";

            return $"{days} {hours}:{minutes}:{seconds}:{milliSeconds}";
        }

        private static string Plural(int number)
        {   //Places an S if the quantity is > than 1 to the string.
            return number > 1 ? "s" : string.Empty;
        }
        public static void EndSession()
        {

        }

    }
}

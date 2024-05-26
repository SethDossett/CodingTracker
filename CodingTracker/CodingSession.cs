namespace CodingTracker
{
    internal class CodingSession
    {
        public string Id = "";
        public DateTime startTime;
        public DateTime endTime;
        public DateTime duration;

        public CodingSession(string id, DateTime startTime, DateTime endTime, DateTime duration)
        {
            id = this.Id;
            startTime = this.startTime;
            endTime = this.endTime;
            duration = this.duration;
        }

        public static void StartTimer()
        {
            Console.WriteLine("\n\nCoding Session Has Begun.\n\n");



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


            endTime = DateTime.Now;

            if (DateTime.TryParse(endTime.ToString(), out endTime))
            {
                Console.WriteLine(endTime.ToString("MM-dd-yy HH:mm:ss"));
            }
            else
            {
                Console.Error.WriteLine("DateTime UnParsable.");
            }


        }
        public static void EndTimer()
        {

        }

    }
}

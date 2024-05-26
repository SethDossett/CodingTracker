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
            DateTime now = DateTime.Now;
            if (DateTime.TryParse(now.ToString(), out now))
            {
                Console.WriteLine(now.ToString("MM-dd-yy HH:mm:ss"));
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

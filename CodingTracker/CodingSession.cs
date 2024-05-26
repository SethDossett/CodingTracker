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

    }
}

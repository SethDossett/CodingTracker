using Microsoft.Data.Sqlite;

namespace CodingTracker;

public class CodingController
{
    static string connectionString = @"Data Source=coding-Tracker.db";

    static void Main(string[] args)
    {   //Initialize Table
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS coding_session (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                StartTime TEXT,
                EndTime TEXT,
                Duration TEXT
                )";

            tableCmd.ExecuteNonQuery();
            connection.Close();
        }

        MainMenu();

    }

    static void MainMenu()
    {
        Console.Clear();
        bool closeApp = false;

        while (!closeApp)
        {

            Console.WriteLine("\n\nMAIN MENU");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("\nType 0 to Close Application.");
            Console.WriteLine("Type 1 to View Previous Sessions.");
            Console.WriteLine("Type 2 to Start New Live Session.");
            Console.WriteLine("Type 3 to Log Session.");
            Console.WriteLine("Type 4 to Delete Session.");
            Console.WriteLine("Type 5 to Update Session.");
            Console.WriteLine("------------------------------------------\n");

            //Read players input
            string input = Console.ReadLine();

            //Check if input is valid.
            switch (input)
            {
                case "0":
                    Console.WriteLine("\nGoodbye!\n");
                    closeApp = true;
                    Environment.Exit(0);
                    break;
                case "1":
                    ViewRecords();
                    break;
                case "2":
                    LogLiveSession();
                    break;
                case "3":
                    LogSession();
                    break;
                case "4":
                    DeleteRecord();
                    break;
                case "5":
                    UpdateRecord();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 5.\n");
                    break;


            }
        }



    }

    private static void LogSession()
    {
        Console.Clear();

        string startTime = Console.ReadLine();
        string endTime = Console.ReadLine();

        CodingSession session = new CodingSession(startTime, endTime);

        CreateRecord(session);

    }

    private static void UpdateRecord()
    {
        throw new NotImplementedException();
    }

    private static void DeleteRecord()
    {
        throw new NotImplementedException();
    }

    private static void LogLiveSession()
    {
        Console.Clear();
        //CodingSession.StartTimer();

        CodingSession session = new CodingSession();

        CreateRecord(session);

    }


    private static void CreateRecord(CodingSession session)
    {


        //Create New Table Entry
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = $"INSERT INTO coding_session(startTime, endTime, duration) VALUES('{session.StartTime}', '{session.EndTime}', '{session.Duration}')";
            connection.Close();
        }





        //CodingSession record = new CodingSession(id, startTime, endTime, duration);
        //List<CodingSession> sessions = new List<CodingSession>();

    }

    private static void ViewRecords()
    {
        throw new NotImplementedException();
    }

    static string GetNumberInput(string message)
    {
        Console.Write(message);

        string input = Console.ReadLine();

        return input;
    }

    void Update()
    {

    }
    void Delete() { }
    void Create() { }
    void ListAllEntries() { }



}
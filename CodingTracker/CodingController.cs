namespace CodingTracker;

public class CodingController
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pickles");

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
            Console.WriteLine("Type 1 to View All Records.");
            Console.WriteLine("Type 2 to Insert Record.");
            Console.WriteLine("Type 3 to Delete Record.");
            Console.WriteLine("Type 4 to Update Record.");
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
                    CreateRecord();
                    break;
                case "3":
                    DeleteRecord();
                    break;
                case "4":
                    UpdateRecord();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;


            }
        }



    }

    private static void UpdateRecord()
    {
        throw new NotImplementedException();
    }

    private static void DeleteRecord()
    {
        throw new NotImplementedException();
    }

    private static void CreateRecord()
    {
        Console.Clear();

        //Create connection table

        string id = "";
        string startTime = GetNumberInput("\n\nPlease insert your start time: (Format: dd - mm - yy).type 0 to return to main menu.\n\n");
        string endTime;
        DateTime duration;




        CodingSession record = new CodingSession(id, startTime, endTime, duration);
        List<CodingSession> sessions = new List<CodingSession>();
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
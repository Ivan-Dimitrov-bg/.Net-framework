namespace Events
{
    using System;

    public class Program
    {
        private static readonly EventHolder EventHolder = new EventHolder();

        public static void Main(string[] args)
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.OutputString);
        }

        // Possible commands begin with "AddEvent", "DeleteEvents", "ListEvents", "Exit/End"
        // Format "CommandType Date Time | Title[ | Location]" 
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command.Length > 0)
            {
                char firstLetter = command[0];

                if (firstLetter == 'A')
                {
                    AddEvent(command);
                    return true;
                }

                if (firstLetter == 'D')
                {
                    DeleteEvents(command);
                    return true;
                }

                if (firstLetter == 'L')
                {
                    ListEvents(command);
                    return true;
                }

                if (firstLetter == 'E')
                {
                    return false;
                }
            }
            
            return false;
        }

        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            EventHolder.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            EventHolder.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);
            EventHolder.AddEvent(date, title, location);
        }

        // Breaks down (parses) a command in its type, date and time, command title and location (if available)
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 19));
            return date;
        }
    }
}
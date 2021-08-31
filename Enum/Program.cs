using System;

namespace EnumDemo
{
    class Program
    {
        enum MeetingImportance
        {
            Trivial,
            Regular,
            Critical,
        }
        static void Main(string[] args)
        {
            MeetingImportance meet = MeetingImportance.Critical;
            int value = (int)MeetingImportance.Critical;

            if (meet == MeetingImportance.Critical)
            {
                Console.WriteLine("Critical " + value);
            }
            else if (meet == MeetingImportance.Trivial)
            {
                Console.WriteLine("Trivial " + value);
            }

            else if (meet == MeetingImportance.Regular)
            {
                Console.WriteLine("Regular " + value);
            }
        }
    }
}
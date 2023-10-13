namespace ConsoleApp1
{
    public class Manager
    {
        public delegate void DateSelectionDelegate();


        

        public void MondayJob()
        {
            Console.WriteLine("This is Monday job");
        }

        public void TuesdayJob()
        {
            Console.WriteLine("This is Tuesday job");
        }
        public void ThursdayJob()
        {
            Console.WriteLine("This is Thursday job");
        }

        public void WednesdayJob()
        {
            Console.WriteLine("This is Wednesday job");
        }

        public void FridayJob()
        {
            Console.WriteLine("This is Friday job");
        }

        public void SaturdayJob()
        {
            Console.WriteLine("This is Saturday job");
        }
        public void SundayJob()
        {
            Console.WriteLine("This is Sunday job");
        }

        public  DateSelectionDelegate RunJob(string day)
        {
            DateSelectionDelegate monday = MondayJob;
            DateSelectionDelegate tuesday = TuesdayJob;
            DateSelectionDelegate wednesday = WednesdayJob;
            DateSelectionDelegate thursday = ThursdayJob;
            DateSelectionDelegate friday = FridayJob;
            DateSelectionDelegate saturday = SaturdayJob;
            DateSelectionDelegate sunday = SundayJob;

            var daySelector = new Dictionary<string, DateSelectionDelegate>
            {
                {"Monday", monday },
                {"Tuesday", tuesday},
                {"Wednesday", wednesday},
                {"Thursday", thursday},
                {"Friday", friday},
                {"Saturday", saturday},
                {"Sunday", sunday}
            };

            daySelector.TryGetValue(day, out var selectedDay);
            return selectedDay;
        }
    }
}

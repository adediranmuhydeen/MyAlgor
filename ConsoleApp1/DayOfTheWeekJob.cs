namespace ConsoleApp1
{
    public class DayOfTheWeekJob
    {
        private Dictionary<DayOfWeek, Action> dayOfWeekActions;

        public DayOfTheWeekJob()
        {
            dayOfWeekActions = new Dictionary<DayOfWeek, Action>
        {
            { DayOfWeek.Monday, MondayJob },
            { DayOfWeek.Tuesday, TuesdayJob },
            { DayOfWeek.Wednesday, WednesdayJob },
            { DayOfWeek.Thursday, ThursdayJob },
            { DayOfWeek.Friday, FridayJob },
            { DayOfWeek.Saturday, SaturdayJob },
            { DayOfWeek.Sunday, SundayJob }
        };
        }

        public void RunJob(DateTime date)
        {
            
            if (dayOfWeekActions.TryGetValue(date.DayOfWeek, out Action action))
            {
                action.Invoke();
            }
            
        }

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
    }
}

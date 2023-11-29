namespace ConsoleApp1
{
    public class Algorithms
    {
        public static string Convert12HourTo24Hour(string time12Hour)
        {
            if (string.IsNullOrEmpty(time12Hour))
            {
                throw new ArgumentException("Input time is empty or null.");
            }

            // Define a format for parsing the 12-hour time string.
            if (DateTime.TryParseExact(time12Hour, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                // Convert the parsed time to a 24-hour format string.
                return result.ToString("HH:mm:ss");
            }
            else
            {
                throw new ArgumentException("Invalid 12-hour time format.");
            }
        }
    }
}

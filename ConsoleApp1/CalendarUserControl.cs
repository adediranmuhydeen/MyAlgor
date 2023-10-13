namespace ConsoleApp1
{
    public partial class CalendarUserControl
    {
        public event CalendarVisibilityChangeEventHandler CalendarVisibilityChange;
        public event DateSelectedEventHandler DateSelected;

        protected virtual void OnDateSelection(DateSelectedEventArgs e)
        {
            DateSelected(this, e);
        }
    }

    public class CalendarVisibilityChangeEventArgs : EventArgs
    {
        private bool _isCalendarVisible;

        public bool IsCalendarVisible
        {
            get
            {
                return _isCalendarVisible;
            }
        }

        public CalendarVisibilityChangeEventArgs(bool isCalendarVisible)
        {
            _isCalendarVisible = isCalendarVisible;
        }
    }

    public class DateSelectedEventArgs : EventArgs
    {
        private DateOnly _selectedDay;
        public DateOnly SelectedDay
        {
            get
            {
                return _selectedDay;
            }
        }

        public DateSelectedEventArgs(DateOnly selectedDay)
        {
            _selectedDay = selectedDay;
        }
    }

    public delegate void CalendarVisibilityChangeEventHandler(object sender, CalendarVisibilityChangeEventArgs e);

    public delegate void DateSelectedEventHandler(object sender, DateSelectedEventArgs e);

    public class Program

    {

        // Define delegate types that match the signature of the methods you want to call

        delegate void OperationDelegate(int a, int b);



        static void Main()

        {

            // Create instances of the delegate type and assign methods to them

            OperationDelegate addDelegate = Add;

            OperationDelegate subtractDelegate = Subtract;

            OperationDelegate multiplyDelegate = Multiply;

            OperationDelegate divideDelegate = Divide;



            // Decide which method to call based on some condition

            string operation = "add"; // You can change this condition dynamically



            // Use a dictionary to map operation names to delegate instances

            var operationMap = new Dictionary<string, OperationDelegate>

        {

            { "add", addDelegate },

            { "subtract", subtractDelegate },

            { "multiply", multiplyDelegate },

            { "divide", divideDelegate }

        };



            if (operationMap.TryGetValue(operation, out var selectedDelegate))

            {

                // Call the selected method using the delegate

                selectedDelegate(10, 5); // Calls the "Add" method

            }

            else

            {

                Console.WriteLine("Invalid operation");

            }

        }



        // Define methods that match the delegate signature

        static void Add(int a, int b)

        {

            Console.WriteLine($"Addition result: {a + b}");

        }



        static void Subtract(int a, int b)

        {

            Console.WriteLine($"Subtraction result: {a - b}");

        }



        static void Multiply(int a, int b)

        {

            Console.WriteLine($"Multiplication result: {a * b}");

        }



        static void Divide(int a, int b)

        {

            if (b != 0)

            {

                Console.WriteLine($"Division result: {a / b}");

            }

            else

            {

                Console.WriteLine("Division by zero is not allowed.");

            }

        }

    }
}

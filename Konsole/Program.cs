namespace Konsole
{
    internal class Program
    {
        private static Timer? _timer;

        static void Main(string[] args)
        {
            // Create a Timer object that knows to call our TimerCallback
            // method once every 2000 milliseconds.
            _timer = new Timer(TimerCallback, null, 0, 10000);
            // Wait for the user to hit <Enter>
            Console.ReadLine();

            
        }
        private static void TimerCallback(Object o)
        {
            for (int n = 32; n <= 536_870_912; n *= 2)
            {
                int[] array = createArrayOfSize(n);

                long sum = 0;

                var startZeitunkt = DateTime.Now;

                for (int j = 0; j < n; j++)
                {
                    sum += array[j];
                }

                var endeZeitunkt = DateTime.Now;

                TimeSpan ts = endeZeitunkt - startZeitunkt;

                Console.WriteLine($"n = {n} -> time = {ts.Milliseconds} ms, {ts.Nanoseconds} ns");

            }
            Console.WriteLine("#############################################");

        }
        static int[] createArrayOfSize(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = i;

            return array;
        }
    }
}

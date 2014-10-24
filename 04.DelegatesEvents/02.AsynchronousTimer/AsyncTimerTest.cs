namespace _02.AsynchronousTimer
{
    public class AsyncTimerTest
    {
        public static void Main()
        {
            AsynchronousTimer timer = new AsynchronousTimer(10, 1000, TicksCounting);
            timer.Start();
        }

        public static string TicksCounting()
        {
            return "tick";
        }
    }
}

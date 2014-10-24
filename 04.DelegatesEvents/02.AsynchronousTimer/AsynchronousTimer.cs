namespace _02.AsynchronousTimer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsynchronousTimer
    {
        private int ticks;
        private int timeInterval;
        private string result;

        public AsynchronousTimer(int ticks, int timeInterval, CalledMethod deleg)
        {
            this.Ticks = ticks;
            this.TimeInterval = timeInterval;

            if (deleg != null)
            {
                this.result = deleg();
            }
            else
            {
                throw new ArgumentException("The time interval must be positive!");
            }
        }

        public delegate string CalledMethod();

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value > 0)
                {
                    this.ticks = value;
                }
                else
                {
                    throw new ArgumentException("Tiks must be positive!");
                }
            }
        }

        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }

            set
            {
                if (value > 0)
                {
                    this.timeInterval = value;
                }
                else
                {
                    throw new ArgumentException("The time interval must be positive!");
                }
            }
        }

        public void Start()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(this.Ticks * (this.TimeInterval / 1000)));
            RepeatActionEvery(
                () => Console.WriteLine(this.result), 
                TimeSpan.FromMilliseconds(this.TimeInterval),
                cancellation.Token).Wait();
        }

        private static async Task RepeatActionEvery(Action action, TimeSpan interval, CancellationToken cancellationToken)
        {
            while (true)
            {
                action();
                Task task = Task.Delay(interval, cancellationToken);

                try
                {
                    await task;
                }
                catch (TaskCanceledException)
                {
                    return;
                }
            }
        }
    }
}

namespace Runner
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            var console = Config.Default.Console;
            var tests = Config.Default.Tests;

            var runner = new Runner();
            runner.Run(console, tests, args);
        }
    }
}

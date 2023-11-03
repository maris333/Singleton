namespace Singleton
{
    internal class Program
    {
        public static void Main()
        {
            var singleton = Logger.Instance;
            singleton.Log("Helllo World!");
        }
    }
}

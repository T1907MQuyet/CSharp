using System.Threading;

namespace Chuabai.Session8
{
    public class Session8_2
    {
        public static void Main(string[] args)
        {
            
        }

        public static void RunCounter(object o)
        {
            NumberCounter nc = (NumberCounter) 0;
            for (int i = 0; i < 100; i++)
            {
                lock (nc)
                {
                    nc.Change();
                    nc.Show();
                }
                Thread.Sleep(100);
            }
        }
    }
}
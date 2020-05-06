using System;

namespace Chuabai.Session7
{
    public delegate void ButtonHander(string msg);
    public class EventDemo
    {
        public event ButtonHander Onclick;

        public void CliclButton()
        {
            Console.WriteLine("Button click!");
            DateTime now = DateTime.Now;
            if (Onclick == null)
            {
                Onclick += ShowLert;
            }

            Onclick("User click at:" + now);
        }

        public static void ShowLert(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
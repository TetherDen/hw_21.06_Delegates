using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_21._06_Delegates
{
    internal   class TextOut
    {
        private const string GREEN = "\u001b[32m";
        private const string RED = "\u001b[31m";
        private const string YELLOW = "\u001b[33m";
        private const string RESET = "\u001b[0m";
        public void ConsoleDisplay(string text, ShowMsg method)
        {
            method(text);
        }
        public  void ConsoleMove(string text, ShowMsg method)
        {
            if (int.TryParse(text, out int distance))
            {
                for (int i = 0; i < distance; i++)
                {
                    Thread.Sleep(50);
                    method($"Mooving...{distance - i}km left.");
                }
                method("Arrived...");
            }
        }

        public void ConsoleDisplayGreen(string text, ShowMsg method)
        {
            method($"{GREEN}{text}{RESET}");
        }

        public void ConsoleDisplayRed(string text, ShowMsg method)
        {
            method($"{RED}{text}{RESET}");
        }

        public void ConsoleDisplayYellow(string text, ShowMsg method)
        {
            method($"{YELLOW}{text}{RESET}");
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public static class ClsColorText
    {
        public static void ColorText(string mes, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mes);
            Console.ResetColor();
        }
    }
}

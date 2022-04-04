using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace proba
{
    internal class DebugAndTrace
    {
        public static void testing(string Login, string Surname, string Name, string Patronomic, string Login1)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Debug.txt"));
            Debug.Indent();
            Trace.Indent();
            Trace.WriteLine("\n");
            Debug.WriteLine("Дата: {0}", DateTime.Today);
            Debug.WriteLine("Debug");
            Trace.WriteLine("Trace");
            if(Login != null)
            {
                Debug.WriteLine("Вход в программу: " + Login);
            }
            if (Login1 != null)
            {
                Debug.WriteLine("Пользователь добавлен: " + Surname + " " + Name + " " + Patronomic + "\nЛогин: " + Login1);
            }
            Trace.Flush();
        }
    }
}

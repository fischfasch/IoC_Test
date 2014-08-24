using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.WithoutIoC
{
    /// <summary>
    /// Klasse die Methoden zum Finden von Büchern bereit stellt
    /// </summary>
    public class MyBookFinder
    {
        /// <summary>
        /// Büchersuche
        /// </summary>
        /// <returns>Gibt eine Liste von Büchern zurück</returns>
        public List<string> FindBooks()
        {
            return new List<string>() { "Hans im Schuh", "Die Mücke von Berlin", "Der kleine Tisch" };
        }
    }
}

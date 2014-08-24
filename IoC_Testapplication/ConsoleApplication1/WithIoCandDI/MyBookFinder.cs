using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.WithIoCandDI.Interfaces;

namespace ConsoleApplication1.WithIoCandDI
{
    /// <summary>
    /// Klasse die Methoden zum Finden von Büchern bereit stellt
    /// </summary>
    public class MyBookFinder : IBookFinder
    {
        /// <summary>
        /// Konkrete Implementierung der Büchersuche
        /// </summary>
        /// <returns>Gibt eine Liste von Büchern zurück</returns>
        public List<string> FindBooks()
        {
            return new List<string>() { "Hans im Schuh", "Die Mücke von Berlin", "Der kleine Tisch" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.WithIoC.Interfaces;

namespace ConsoleApplication1.WithIoC
{
    /// <summary>
    /// Helper Klasse Inventar
    /// </summary>
    public class InventoryHelper
    {
        /// <summary>
        /// Liefert alle Inventar Items zurück
        /// </summary>
        /// <returns>Liste mit Inventar Items</returns>
        public List<string> GetAllItems()
        {
            //Verwendung des Interfaces um die Komponenten weiter zu entkoppeln
            IBookFinder myBookFinder = new MyBookFinder();
            
            //Liste für alle Items
            List<string> itemList = new List<string>();

            //Zugriff auf Methoden in MyBookFinder
            itemList = myBookFinder.FindBooks();

            return itemList;
        }
    }
}

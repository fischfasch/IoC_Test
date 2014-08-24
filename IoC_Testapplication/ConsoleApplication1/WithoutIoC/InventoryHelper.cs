using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.WithoutIoC
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
            //Liste für alle Items
            List<string> itemList = new List<string>();

            //Um die Liste von Büchern zu bekommen, muss eine konkrete Instanz erstellt werden
            MyBookFinder bookFinder = new MyBookFinder();

            //Zugriff auf Methoden in MyBookFinder
            itemList = bookFinder.FindBooks();

            return itemList;
        }
    }
}

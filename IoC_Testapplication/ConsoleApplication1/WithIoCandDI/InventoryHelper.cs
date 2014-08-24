using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.WithIoCandDI.Interfaces;

namespace ConsoleApplication1.WithIoCandDI
{
    /// <summary>
    /// Helper Klasse Inventar
    /// </summary>
    public class InventoryHelper
    {
        private IBookFinder bookFinder;

        //Entfernen aller Abhängigkeiten auf konkreten Klassen mit Hilfe eines Konstruktors
        //der implementierungen des Interfaces IBookFinder zulässt

        //Die Klasse InventoryHelper weiß jetzt nichts mehr von der Klasse MyBookFinder
        //InventoryHelper ist nur noch abhängig vom Interface IBookFinder

        //Hier handelt es sich um Constructor Injekction
        public InventoryHelper(IBookFinder bookFinderParam)
        {
            bookFinder = bookFinderParam;
        }
        
        /// <summary>
        /// Liefert alle Inventar Items zurück
        /// </summary>
        /// <returns>Liste mit Inventar Items</returns>
        public List<string> GetAllItems()
        {
            //Liste für alle Items
            List<string> itemList = new List<string>();

            //Zugriff auf Methoden in MyBookFinder
            itemList = bookFinder.FindBooks();

            return itemList;
        }
    }
}

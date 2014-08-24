using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Ausgabe der Bücherliste ohne IoC
            WithoutIoC.InventoryHelper inventoryHelper = new WithoutIoC.InventoryHelper();
            List<string> inventoryList = inventoryHelper.GetAllItems();

            foreach (string item in inventoryList)
            {
                Console.WriteLine(item);
            }

            //Leerezeile
            Console.WriteLine();

            //Ausgabe der Bücherliste mit IoC
            WithIoC.InventoryHelper inventoryHelperIoC = new WithIoC.InventoryHelper();
            List<string> inventoryListIoC = inventoryHelperIoC.GetAllItems();

            foreach (string item in inventoryListIoC)
            {
                Console.WriteLine(item);
            }

            //Leerezeile
            Console.WriteLine();

            //Ausgabe der Bücherliste mit IoC und DI
            //Hier wird auch entschieden, welche Klasse die das Interface IBookFinder implementiert, an den Konstruktor der
            //Klasse InventoryHelper weitergegeben wird
            WithIoCandDI.Interfaces.IBookFinder bookFinder = new WithIoCandDI.MyBookFinder();
            WithIoCandDI.InventoryHelper inventoryHelperIoCDI = new WithIoCandDI.InventoryHelper(bookFinder);

            List<string> inventoryListIoCDI = inventoryHelperIoCDI.GetAllItems();

            foreach (string item in inventoryListIoCDI)
            {
                Console.WriteLine(item);
            }

            //Leerezeile
            Console.WriteLine();

            //Ausgabe der Bücherliste mit IoC und DI (mit anderer Datenanbindung)
            WithIoCandDI.Interfaces.IBookFinder bookFinderDB = new WithIoCandDI.MyBookFinderDB();
            WithIoCandDI.InventoryHelper inventoryHelperIoCDIDB = new WithIoCandDI.InventoryHelper(bookFinderDB);

            List<string> inventoryListIoCDIDB = inventoryHelperIoCDIDB.GetAllItems();

            foreach (string item in inventoryListIoCDIDB)
            {
                Console.WriteLine(item);
            }

            //Leerezeile
            Console.WriteLine();

            //Verwendung von Unity
            WithIoCandDI.Interfaces.IBookFinder obj = Unity.Factory.CreateInstanceDB();

            List<string> inventoryListUnity = obj.FindBooks();

            foreach (string item in inventoryListUnity)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using ConsoleApplication1.WithIoCandDI.Interfaces;
using ConsoleApplication1.WithIoCandDI;

namespace ConsoleApplication1.Unity
{
    public class Factory
    {
        public static IBookFinder CreateInstance()
        {
            //Container einrichten
            IUnityContainer container = new UnityContainer();

            //Registriert ein TypeMapping im Container
            //Erster Parameter ist das Interface welches als Typ im Container registriert werden soll
            //Zweiter Parameter ist eine Klasse deren Instanz erstellt werden soll und die das entsprechende Interface implementiert
            container.RegisterType(typeof(IBookFinder), typeof(MyBookFinder));

            //Um nun ein konkretes Objekt zu bekommen, wird die Resolve Methode aufgerufen
            IBookFinder obj = container.Resolve<IBookFinder>();

            return obj;
        }

        public static IBookFinder CreateInstanceDB()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType(typeof(IBookFinder), typeof(MyBookFinderDB));

            IBookFinder obj = container.Resolve<IBookFinder>();

            return obj;
        }
    }
}

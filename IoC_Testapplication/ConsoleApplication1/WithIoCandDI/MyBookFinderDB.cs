using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.WithIoCandDI.Interfaces;
using ConsoleApplication1.DataAccess;

namespace ConsoleApplication1.WithIoCandDI
{
    public class MyBookFinderDB : IBookFinder
    {
        public List<string> FindBooks()
        {
            using (TestDBObjectContext ctx = new TestDBObjectContext())
            {
                List<string> bookList = new List<string>();

                foreach (Book item in ctx.Books.ToList())
                {
                    bookList.Add(item.Name);
                }

                return bookList;   
            }
        }
    }
}

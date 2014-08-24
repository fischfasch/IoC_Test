using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.WithIoCandDI.Interfaces
{
    /// <summary>
    /// Interface für die Suche von Büchern
    /// </summary>
    public interface IBookFinder
    {
        List<string> FindBooks();
    }
}

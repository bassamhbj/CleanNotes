using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("***** CLEAN NOTES *****");

            var view = new View.NoteListView();
            view.CreateView();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel
{
    abstract class Fordon
    {
        public string namn;

        public Fordon(string namn)
        {
            this.namn = namn;
        }

        public abstract void Run(); // Marked as abstract to enforce implementation in derived classes
    }

    class Bil : Fordon
    {
        public Bil(string namn) : base(namn) { }

        public override void Run()
        {
            Console.WriteLine($"{namn} bilen kör iväg.");
        }
    }

    class Cykel : Fordon
    {
        public Cykel(string namn) : base(namn) { }

        public override void Run()
        {
            Console.WriteLine($"{namn} cykeln trampas iväg.");
        }
    }
}

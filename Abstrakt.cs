using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel
{
    class Fordon
    {
        protected string namn;

        public Fordon(string namn)
        {
            this.namn = namn;
        }

        public virtual void Run()
        {
            Console.WriteLine($"{namn} fordonet kör iväg.");
        }
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

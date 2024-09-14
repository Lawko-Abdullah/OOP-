using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System; // Behövs för Console.WriteLine

namespace Exempel
{
    class Animals
    {
        // Virtuell metod som kan överskrivas i underklasser
        public virtual void MakeSound()
        {
            Console.WriteLine("Djuret gör ett ljud");
        }
    }

    // Hundklass som ärver från Animal och överskriver MakeSound
    class Dogs : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        // Extra metod för att illustrera specifikt beteende för hundar
        public void Bark()
        {
            Console.WriteLine("Hundens skall!");
        }
    }

    // Kattklass som ärver från Animal och överskriver MakeSound
    class Cats : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Alternativ Hundklass som kan användas separat om du vill
    class Hund
    {
        public void Ljud()
        {
            Console.WriteLine("Hundens ljud!");
        }

        public void Skall()
        {
            Console.WriteLine("Hundens skall!");
        }
    }

}

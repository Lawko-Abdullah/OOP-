using System;

namespace Exempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exempel på polymorfism
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();  // Output: "Woof!"
            myCat.MakeSound();  // Output: "Meow!"

            // Använd Person-klassen
            Person person = new Person();
            person.SetName("Lawko");
            Console.WriteLine("Personens namn är: " + person.GetName());

            // Använd Fordon-klasser
            Fordon bil = new Bil("Ferrari");
            Fordon cykel = new Cykel("Mountain Bike");

            bil.Run();   // Output: "Ferrari bilen kör iväg."
            cykel.Run(); // Output: "Mountain Bike cykeln trampas iväg."

            // Använd Hund-klassen
            Hund minHund = new Hund();
            minHund.Ljud();  // Output: "Hundens ljud!"
            minHund.Skall(); // Output: "Hundens skall!"
        }
    }
}

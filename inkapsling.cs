using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Exempel

    {
        class Person
        {
            // Privat string för namn (kan bara nås inom klassen)
            private string name;

            // Publik metod för att sätta värdet  'name'
            public void SetName(string value)
            {
                name = value;
            }

            // Publik metod för att hämta värdet  'name'
            public string GetName()
            {
                return name;
            }

            
        }

    }

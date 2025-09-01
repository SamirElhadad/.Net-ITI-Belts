using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        private string fullName;
        private int id;
        private int age;


        // Property for Id with validation
        public int Id {
            get { return id; }
                set {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Id must be greater than 0");
                    }
                    else
                    {
                        id = value;
                    }
            }
        }


        // Auto-implemented property for FullName
        public string FullName { get; set; }


        // Full property for Age with validation
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be between 0 and 120");
                }
                else
                {
                    age = value;
                }
            }
        }

        public abstract void DisplayInfo();

    }
   }


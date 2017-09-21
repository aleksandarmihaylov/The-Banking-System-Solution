using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    //creating a person class for creating an inheritance between difference kind of persons into the bank fx. customer, employees, etc.
    public abstract class Person
    {
        // initialising the Person's properties
        private int id;
        private string name;

        //creating the constructor for this class
        public Person(string newName)
        {
            name = newName;
        }
        //Encapsulation
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}

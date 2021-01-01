using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class PersonModel
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Below does NOT work
        //public  void Update(int newId)
        //{
        //    Id = newId;
        //}
        public PersonModel()
        {

        }
        public PersonModel(int id, string firstName, string lastName)
        {
            id = Id;
            firstName = FirstName;
            lastName = LastName;
        }
    }
}

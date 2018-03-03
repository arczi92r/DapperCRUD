using System;

namespace Entity
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonType { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public  Adres Adres { get; set; }
    }

}

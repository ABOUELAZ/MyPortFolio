using System;


namespace Core.Entities
{
   public class Address : EntityBase
    {
        public String Street { get; set; }
        public String City { get; set; }
        public int Number { get; set; }
    }
}



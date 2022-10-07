using System;

namespace Core.Entities
{
  public  class Owner :EntityBase
    {
        public String FullName { get; set; }
        public String Profil { get; set; }
        public String Avatar { get; set; }
        public Address Address { get; set; }
    }
}



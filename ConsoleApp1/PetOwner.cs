using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PetOwner
    {
        public PetOwner(int id, string name, IEnumerable<Pet> pets)
        {
            Id = id;
            Name = name;
            Pets = pets.Count() > 10 ? Enumerable.Empty<Pet>() : pets;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }
}

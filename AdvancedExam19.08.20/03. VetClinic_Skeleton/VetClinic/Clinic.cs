using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private IList<Pet> data;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Pet pet)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            var petToRemove = this.data.FirstOrDefault(c => c.Name == name);

            return this.data.Remove(petToRemove);
        }

        public Pet GetPet(string name, string owner)
        {
            var pet = this.data.FirstOrDefault(x => x.Name == name && x.Owner == owner);

            return pet;
        }

        public Pet GetOldestPet()
        {
            if (this.data.Count == 0)
            {
                return null;
            }
            var pet = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return pet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}

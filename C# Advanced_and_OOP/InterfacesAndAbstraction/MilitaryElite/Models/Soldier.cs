namespace MilitaryElite.Contracts
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(int id, string firstname, string lastname)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        

        public int Id { get; private set; }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}

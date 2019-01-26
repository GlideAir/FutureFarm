namespace FutureFarm
{
    public class Goat : BaseAnimal
    {
        public string Name { get; }

        public Goat(string name)
        : base(name)
        {
            Name = name;
        }
    }
}
namespace FutureFarm
{
    public class Dog : BaseAnimal
    {
        public string Name { get; private set; }

        public Dog(string name)
        :base(name)
        {
            Name = name;
        }
    }
}

namespace FutureFarm
{
    public class Turkey : BaseAnimal
    {
        public string Name { get; }

        public Turkey(string name)
        : base(name)
        {
            Name = name;
        }
    }
}
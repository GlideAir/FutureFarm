namespace FutureFarm
{
    public class Clone : BaseHuman, IWorkTask
    {
        public string Name { get; }

        public Clone(string name)
            : base(name)
        {
            Name = name;
        }
    }
}
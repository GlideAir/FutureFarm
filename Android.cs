
namespace FutureFarm
{
    public class Android : BaseHuman, IWorkTask
    {
        public string Name { get; }

        public Android(string name)
            :base(name)
        {
            Name = name;
        }
    }
}
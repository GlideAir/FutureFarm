namespace FutureFarm
{
    struct Knife : ITool
    {
        public string Name { get;}
        public Knife(string name)
        {
            Name = name;
        }
    }
}
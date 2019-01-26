namespace FutureFarm
{
    public struct Bucket : ITool
    {
        public string Name { get; set; }
        public Bucket(string name)
        {
            Name = name;
        }
    }
}
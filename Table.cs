namespace FutureFarm
{
    public struct Table
    {
        public string Name { get; private set; }
        private int _numberOfFeet { get; set; }
        private string _shape { get; set; }

        public Table(int numberOfFeet, string shape)
        {
            _numberOfFeet = numberOfFeet;
            _shape = shape;
            Name = "table " + shape;
        }

    }
}
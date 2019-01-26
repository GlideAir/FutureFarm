namespace FutureFarm
{
    public class Woman : BaseHuman
    {
        private string _firstname { get;}

        public Woman(string firstname)
        :base(firstname)
        {
            _firstname = firstname;
        }
    }
}
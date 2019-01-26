namespace FutureFarm
{
    public class Man : BaseHuman, IWorkTask
    {
        private string _firstname { get; set; }
        private string _firstnameWife { get; set; }

        public Man(string firstname)
        :base(firstname)
        {
            _firstname = firstname;
        }

        /// <summary>
        /// Creates the wife of this instance
        /// </summary>
        /// <returns>The wife.</returns>
        /// <param name="firstnameWife">Firstname wife.</param>
        public Woman CreateWife(string firstnameWife)
        {
            _firstnameWife = firstnameWife;
            Woman wife = new Woman(_firstnameWife);
            return wife;
        }
    }
}
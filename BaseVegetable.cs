using System;

namespace FutureFarm
{
    public abstract class BaseVegetable
    {
        private string _name { get; set; }

        public BaseVegetable(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Grow this instance.
        /// </summary>
        public void Grow()
        {
            Console.WriteLine("Le " + _name + " pousse");
        }

        /// <summary>
        /// Flowers this instance.
        /// </summary>
        public void Flowers()
        {
            Console.WriteLine("Le " + _name + " est en fleurs");
        }

        /// <summary>
        /// Dead this instance.
        /// </summary>
        public void Dead()
        {
            Console.WriteLine("Le " + _name + " est mort");
        }
    }
}

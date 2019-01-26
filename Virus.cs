using System;

namespace FutureFarm
{
    public struct Virus
    {
        private string _target { get; set; }

        public Virus(string target)
        {
            _target = target;
        }

        /// <summary>
        /// Attack the target of this instance.
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Le Virus se propage et attaque les " + _target);
        }
    }
}
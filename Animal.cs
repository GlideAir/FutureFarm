using System;
namespace FutureFarm
{
    public abstract class BaseAnimal
    {
        private string _name { get; set; }

        public BaseAnimal(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Wathing you and moves the queue.
        /// </summary>
        public void MoveQueue()
        {
            Console.WriteLine(_name + " vous regarde et remue la queue \n");
        }
    }
}

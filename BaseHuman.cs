using System;

namespace FutureFarm
{
    abstract public class BaseHuman : IHuman, IWorkTask
    {
        public string Firstname { get; }

        public BaseHuman(string firstname)
        {
            Firstname = firstname;
        }

        /// <summary>
        /// Eat at the specified place.
        /// </summary>
        /// <param name="place">Place.</param>
        public void Eat(string place)
        {
            Console.WriteLine(Firstname + " s'installe auprès de le/la " + place +" et mange");
        }

        /// <summary>
        /// Sleep, for this instance
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine(Firstname + " s'endort");
        }

        /// <summary>
        /// Cut the specified vegetable with the specified tool.
        /// </summary>
        /// <param name="vegetable">Vegetable.</param>
        /// <param name="tool">Tool.</param>
        public void Cut(string vegetable, string tool)
        {
            Console.WriteLine(Firstname + " taille les " + vegetable + " avec un " + tool);
        }

        /// <summary>
        /// Harvest the specified vegetable with the specified tool.
        /// </summary>
        /// <param name="vegetable">Vegetable.</param>
        /// <param name="tool">Tool.</param>
        public void Harvest(string vegetable, string tool)
        {
            Console.WriteLine(Firstname + " récolte les " + vegetable + " et met les fruits dans un " + tool);
        }

        /// <summary>
        /// Kill the specified animal.
        /// </summary>
        /// <param name="animal">Animal.</param>
        public void Kill(string animal)
        {
            Console.WriteLine(Firstname + " tue le/la " + animal);
        }

        /// <summary>
        /// Gives the water at the specified target
        /// </summary>
        /// <param name="target">Target.</param>
        public void GiveWater(string target)
        {
            Console.WriteLine(Firstname + " donne de l'eau aux " + target);
        }
    }
}
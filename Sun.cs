using System;

namespace FutureFarm
{
    public static class Sun
    {
        // Classe statique car il n'existe qu'un seul Soleil dans notre contexte terrien

        /// <summary>
        /// Rise the sun.
        /// </summary>
        public static void Rise()
        {
            Console.WriteLine("Le soleil se lève");
        }

        /// <summary>
        /// SunShine
        /// </summary>
        public static void Shine()
        {
            Console.WriteLine("Le soleil brille");
        }
    }
}
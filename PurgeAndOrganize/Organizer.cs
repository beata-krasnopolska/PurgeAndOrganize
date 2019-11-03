using System;
using System.Linq;

namespace PurgeAndOrganize
{
    class Organizer
    {
        public void Organize(int[] array)
        {
            var newArray = array.Distinct().OrderBy(p => p).ToArray();

            foreach (var p in newArray)
            {
                Console.Write(p);
            }
        }
    }
}

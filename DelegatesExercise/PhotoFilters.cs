using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercise
{
    public class PhotoFilters
    {
        public void ResizePhoto(Photo photo)
        {
            Console.WriteLine("resizing photo");
        }
        public void AdjustColour(Photo photo)
        {
            Console.WriteLine("changing colour");
        }
    }
}

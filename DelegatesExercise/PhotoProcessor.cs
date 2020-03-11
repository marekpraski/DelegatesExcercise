using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercise
{
    public class PhotoProcessor
    {
        public delegate void PhotoProcessorHandler(Photo photo);

        public delegate void ConsoleDelegate(string txt);
        public void Process(string path, PhotoProcessorHandler photoProcessor)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            photoProcessor(photo);

        }

        public void ProcessWithAction(string path, Action<Photo> photoProcessor)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            photoProcessor(photo);

        }
    }
}

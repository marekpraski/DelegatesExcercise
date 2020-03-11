using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercise
{
    class Program
    {
        public delegate void PhotoProcessorDelMain(Photo photo);
        static void Main(string[] args)
        {
            //doWork();
            //doWorkWithAction();
            // Instantiate the delegate.
            Del handler = new Del( DelegateMethod);
            Del handler1 = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
            handler1("wow, it works");
            doMoreWork();
            Console.ReadLine();
        }

        private static void doWork()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoProcessorHandler photoProcessor = filters.ResizePhoto;

            //PhotoProcessorDelMain pd = new PhotoProcessorDelMain(filters.AdjustColour);

            processor.Process("photo.jpg", photoProcessor);
            Console.ReadLine();

        }

        public delegate void Del(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        private static void doWorkWithAction()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> photoProcessor = filters.ResizePhoto;

            PhotoProcessorDelMain pd = new PhotoProcessorDelMain(filters.AdjustColour);

            processor.ProcessWithAction("photo.jpg", photoProcessor);
            Console.ReadLine();

        }

        public static void doMoreWork()
        {
            PhotoProcessor pp = new PhotoProcessor();
            PhotoProcessor.ConsoleDelegate conDel = DelegateMethod;
            var conDel2 = new PhotoProcessor.ConsoleDelegate(DelegateMethod);
            conDel("writing to console from a delegate");
            conDel2("writing some more");
        }

    }
}

using System;

namespace IDisposableDemo
{
    class IDisposableDemo : IDisposable
    {
        private string name;
        private bool disposename = false;
        /// <summary>
        /// This is the constructor 
        /// </summary>
        /// <param name="name"></param>
        public IDisposableDemo(string name)
        {
            this.name = name;
            this.disposename = true;
        }/// <summary>
        /// This method is to display the name
        /// </summary>
        public void display()
        {
            Console.WriteLine("string is:" + this.name);
        }/// <summary>
        /// This method is to Dispose by checking the disposename value
        /// </summary>
        public void Dispose()
        {
            if (disposename)
            {
                name = string.Empty;
                Console.WriteLine("disposed");
                
           }
            disposename = false;
        }
    }
    class DisposableDemo
    {/// <summary>
     /// In this methods of IDisposableDemo class are called like dispose and display
     /// </summary>
     /// <param name="args"></param>
        public static void Main(string[] args)
        {
            IDisposableDemo student = new IDisposableDemo("varun");
            student.display();
            student.Dispose();
            student.display();
        }
    }
}

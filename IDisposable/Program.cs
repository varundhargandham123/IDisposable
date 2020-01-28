using System;

namespace IDisposableDemo
{
    class IDisposableDemo : IDisposable
    {
        private string name;
        private bool disposename = false;

        public IDisposableDemo(string name)
        {
            this.name = name;
            this.disposename = true;
        }
        public void display()
        {
            Console.WriteLine(this.name);
        }
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
    {
      public static void Main(string[] args)
        {
            IDisposableDemo student = new IDisposableDemo("varun");
            student.display();
            student.Dispose();
            try
            {
                student.display();
            }
            catch (Exception)
            {
                Console.Write("it is disposed");
            }
        }
    }
}

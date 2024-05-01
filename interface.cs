using System;
namespace ChapterOne
{
    interface IMyInterface
    {
        void Method();
    }

    class Class : IMyInterface
    {
        public void Method()
        {
            Console.WriteLine("Method() called");
        }
    }

}


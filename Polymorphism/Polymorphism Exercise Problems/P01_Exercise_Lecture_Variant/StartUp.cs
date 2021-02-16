using System;

using P01_Exercise_Lecture_Variant.Core;
using P01_Exercise_Lecture_Variant.Core.Contracts;

namespace P01_Exercise_Lecture_Variant
{
    public class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}

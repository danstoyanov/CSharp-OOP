using System;
using System.Reflection;

namespace Reflection_Lecture_Demo
{
    public class DemoStartUp
    {
        static void Main()
        {
            var testType = Type.GetType("Reflection_Lecture_Demo.TestClass");

            // how to get the Type of current Class
            TestClass test = (TestClass)Activator.CreateInstance(testType, new object[] { "Pesho", 23 });


            // how to get fields from current Class
            FieldInfo field = testType.GetField("secret",
                BindingFlags.NonPublic |
                BindingFlags.Instance);

            var printInfo = field.Name;

            // how to get all Constructors from current Class
            ConstructorInfo[] cinInfo = testType.GetConstructors();


            // how to get all Methods from current Class

            TestClass newInstance = (TestClass)cinInfo[1].Invoke(new object[] { "Mario" });

            MethodInfo[] methods = testType.GetMethods();

            // how to get only one Method from the current Class
            MethodInfo who = testType.GetMethod("WhoAmI");

            // Invoke 
            who.Invoke(newInstance, null);

            field.SetValue(test, "");
        }
    }
}

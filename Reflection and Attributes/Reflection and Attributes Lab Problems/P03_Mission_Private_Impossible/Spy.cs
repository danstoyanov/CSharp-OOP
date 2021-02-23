using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Stealer
{
    public class Spy : ISpy
    {
        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type currentSpyType = Type.GetType(className);

            // Hacker Class Fields check !!
            FieldInfo[] classFields = currentSpyType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public);

            // Hacker Class All public methods !!
            MethodInfo[] publicClassMethods = currentSpyType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public);


            // Hacker Class All non public methods!!
            MethodInfo[] nonPublicClassMethods = currentSpyType.GetMethods(
                BindingFlags.Instance |
                BindingFlags.NonPublic);

            // Print all nonprivate fields !!!
            foreach (FieldInfo field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            // Print all nonPunblic "getters !"
            foreach (MethodInfo method in publicClassMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            // Print all public "setters" !
            foreach (MethodInfo method in nonPublicClassMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();


            return sb.ToString().Trim();
        }

        public string StealFieldInfo(string investigatedClass, params string[] infos)
        {
            StringBuilder sb = new StringBuilder();

            Type currentType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = currentType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            Object classInstance = Activator.CreateInstance(currentType, new object[] { });

            sb.AppendLine($"Class under investigation: {currentType.FullName}");

            foreach (var field in classFields.Where(f => infos.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }
    }
}

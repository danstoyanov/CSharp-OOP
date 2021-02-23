using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Stealer
{
    public class Spy : ISpy
    {
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

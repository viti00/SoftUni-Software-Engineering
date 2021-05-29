using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, params string[] fields)
        {
            Type type = Type.GetType(nameOfClass);
            FieldInfo[] classFields = type.GetFields((BindingFlags)60);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {nameOfClass}");

            object classInstance = Activator.CreateInstance(type, new object[] { });

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }
    }
}

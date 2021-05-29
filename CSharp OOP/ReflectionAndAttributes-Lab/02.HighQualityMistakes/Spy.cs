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
        public string AnalyzeAccessModifiers(string nameOfClass)
        {
            Type type = Type.GetType(nameOfClass);
            FieldInfo[] classFields = type.GetFields((BindingFlags)28);
            MethodInfo[] classPublicMethods = type.GetMethods((BindingFlags)20);
            MethodInfo[] classNonPublicMethods = type.GetMethods((BindingFlags)36);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name}  must be private!");
            }
            foreach (var method in classNonPublicMethods.Where(m=> m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name}  have to be public!");
            }
            foreach (var method in classPublicMethods.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string nameOfClass)
        {
            Type type = Type.GetType(nameOfClass);
            MethodInfo[] nonPublicMethods = type.GetMethods((BindingFlags)36);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {nameOfClass}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");

            foreach (var method in nonPublicMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string nameOfClass)
        {
            Type type = Type.GetType(nameOfClass);

            MethodInfo[] methods = type.GetMethods((BindingFlags)52);

            StringBuilder sb = new StringBuilder();

            foreach (var method in methods.Where(m=> m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methods.Where(m=> m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}

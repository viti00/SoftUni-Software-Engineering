using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public  static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                MyValidationAttribute[] atributes = property.GetCustomAttributes()
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                object? value = property.GetValue(obj);
                foreach (var attribute in atributes)
                {
                    bool IsValid = attribute.IsValid(value);

                    if (!IsValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

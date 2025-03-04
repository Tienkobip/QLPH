using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;


namespace DataAccess.Utility
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)field
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault();

            if (attribute == null) 
                return value.ToString();
                
            return attribute.Description;
        }
    }
}

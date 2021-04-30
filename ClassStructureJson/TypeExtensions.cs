using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ClassStructureJson
{
    public static class TypeExtensions
    {
        public static bool IsNullable(this Type type)
        {
            return (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        public static Type GetOriginalType(this Type type)
        {
            return type.IsNullable()
                ? Nullable.GetUnderlyingType(type)
                : type;
        }

        public static bool IsSimpleType(this Type type)
        {
            return
                type.IsPrimitive ||
                new Type[] {
                    typeof(string),
                    typeof(decimal),
                    typeof(DateTime),
                    typeof(DateTimeOffset),
                    typeof(TimeSpan),
                    typeof(Guid)
                }.Contains(type) ||
                type.IsEnum;
        }
    }
}

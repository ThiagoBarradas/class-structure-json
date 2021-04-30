using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace ClassStructureJson
{
    public static class ClassStructureSerializeExtensions
    {
        public static string GetClassStructure<T>(NamingStrategy namingStrategy = null, Formatting formatting = Formatting.Indented)
        {
            return typeof(T).GetClassStructure(namingStrategy, formatting);
        }

        public static string GetClassStructure(this Type type, NamingStrategy namingStrategy = null, Formatting formatting = Formatting.Indented)
        {
            var instance = Activator.CreateInstance(type);

            var resolver = new AvoidNullContractResolver
            {
                NamingStrategy = namingStrategy ?? new CamelCaseNamingStrategy()
            };

            var settings = new JsonSerializerSettings
            {
                ContractResolver = resolver
            };
            
            settings.Converters.Add(new ClassStructureSerialize());

            return JsonConvert.SerializeObject(instance, formatting, settings);
        }
    }
}

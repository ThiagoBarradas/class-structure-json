using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace ClassStructureJson
{
    public class AvoidNullContractResolver : DefaultContractResolver
    {
        public AvoidNullContractResolver()
        {
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            object value = "";

            var type = property.PropertyType.GetOriginalType();

            if (type != typeof(string))
            {
                value = Activator.CreateInstance(type);
            }

            var valueProvider =
                Activator.CreateInstance(typeof(DefaultValueProvider<>).MakeGenericType(property.PropertyType), value);
            
            property.ValueProvider = (IValueProvider) valueProvider;
            property.ObjectCreationHandling = ObjectCreationHandling.Reuse;
        
            return property;
        }
    }

    public class DefaultValueProvider<T> : IValueProvider
    {
        private T Object { get; set; }

        public DefaultValueProvider(T obj)
        {
            this.Object = obj;
        }

        public void SetValue(object target, object value)
        {
            this.Object = (T) value;
        }

        public object GetValue(object target)
        {
            return this.Object;
        }
    }
}

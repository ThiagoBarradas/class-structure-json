using Newtonsoft.Json;
using System;

namespace ClassStructureJson
{
    public class ClassStructureSerialize : JsonConverter
    {
        private bool IsNullable { get; set; }

        public override bool CanConvert(Type type)
        {
            this.IsNullable = type.IsNullable();

            return type.GetOriginalType().IsSimpleType();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new InvalidOperationException("ClassStructureSerialize cannot be parsed from a string json");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = this.GetTypeAsString(value.GetType());

            writer.WriteValue(type);
        }
        
        private string GetTypeAsString(Type type)
        {
            var originalType = type.GetOriginalType();
            var typeAsString = originalType.Name;

            if (originalType.IsPrimitive)
            {
                typeAsString = type.Name.ToLowerInvariant();
            }

            typeAsString = this.ForceTypeName(typeAsString);

            if (this.IsNullable)
            {
                typeAsString = $"{typeAsString}?";
            }

            return typeAsString;
        }

        private string ForceTypeName(string type)
        {
            switch (type)
            {
                case "int16":
                    return "short";
                case "int32":
                    return "int";
                case "int64":
                    return "long";
                case "uint16":
                    return "ushort";
                case "uint32":
                    return "uint";
                case "uint64":
                    return "ulong";
                case "String":
                    return "string";
                default:
                    return type;
            }
        }
    }
}
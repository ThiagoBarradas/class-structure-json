using ClassStructureJson.Tests.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using Xunit;

namespace ClassStructureJson.Tests
{
    public class ClassStructureSerializeExtensionsTests
    {
        [Fact]
        public void GetClassStructure_Should_Return_Json()
        {
            // arrange
            var expectedJson = "{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\",\"name_initial\":\"char\",\"name_initial2\":\"char?\",\"id\":\"Guid\",\"age\":\"int\",\"age2\":\"int?\",\"weight\":\"double\",\"weight2\":\"double?\",\"boole\":\"boolean\",\"boole2\":\"boolean?\",\"longg\":\"long\",\"longg2\":\"long?\",\"decimall\":\"Decimal\",\"decimall2\":\"Decimal?\",\"floatt\":\"single\",\"floatt2\":\"single?\",\"bytee\":\"byte\",\"bytee2\":\"byte?\",\"s_bytee\":\"sbyte\",\"s_bytee2\":\"sbyte?\",\"short\":\"short\",\"short2\":\"short?\",\"u_short\":\"ushort\",\"u_short2\":\"ushort?\",\"u_intt\":\"uint\",\"u_intt2\":\"uint?\",\"u_longg\":\"ulong\",\"u_longg2\":\"ulong?\",\"created_at\":\"DateTime\",\"created_at_nullable\":\"DateTime?\",\"date_time_offsettt\":\"DateTimeOffset\",\"date_time_offsetttt\":\"DateTimeOffset?\",\"time_spantt\":\"TimeSpan\",\"time_spanrrr\":\"TimeSpan?\",\"test_structs\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"test_structss\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"car2\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"queisso_getne\":{\"prop1\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"prop2\":\"DateTime?\",\"prop3\":\"CarType\"}}";
            var strategy = new SnakeCaseNamingStrategy();

            // act
            var json = typeof(Car).GetClassStructure(strategy, Formatting.None);

            // assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void GetClassStructure_Should_Return_Json_Default_CamelCase()
        {
            // arrange
            var expectedJson = "{\"carType1\":\"CarType\",\"carType2\":\"CarType?\",\"name\":\"string\",\"nameInitial\":\"char\",\"nameInitial2\":\"char?\",\"id\":\"Guid\",\"age\":\"int\",\"age2\":\"int?\",\"weight\":\"double\",\"weight2\":\"double?\",\"boole\":\"boolean\",\"boole2\":\"boolean?\",\"longg\":\"long\",\"longg2\":\"long?\",\"decimall\":\"Decimal\",\"decimall2\":\"Decimal?\",\"floatt\":\"single\",\"floatt2\":\"single?\",\"bytee\":\"byte\",\"bytee2\":\"byte?\",\"sBytee\":\"sbyte\",\"sBytee2\":\"sbyte?\",\"short\":\"short\",\"short2\":\"short?\",\"uShort\":\"ushort\",\"uShort2\":\"ushort?\",\"uIntt\":\"uint\",\"uIntt2\":\"uint?\",\"uLongg\":\"ulong\",\"uLongg2\":\"ulong?\",\"createdAt\":\"DateTime\",\"createdAtNullable\":\"DateTime?\",\"dateTimeOffsettt\":\"DateTimeOffset\",\"dateTimeOffsetttt\":\"DateTimeOffset?\",\"timeSpantt\":\"TimeSpan\",\"timeSpanrrr\":\"TimeSpan?\",\"testStructs\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"testStructss\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"car2\":{\"carType1\":\"CarType\",\"carType2\":\"CarType?\",\"name\":\"string\"},\"queissoGetne\":{\"prop1\":{\"carType1\":\"CarType\",\"carType2\":\"CarType?\",\"name\":\"string\"},\"prop2\":\"DateTime?\",\"prop3\":\"CarType\"}}";

            // act
            var json = typeof(Car).GetClassStructure(null, Formatting.None);

            // assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void GetClassStructure_With_Generic_Should_Return_Json()
        {
            // arrange
            var expectedJson = "{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\",\"name_initial\":\"char\",\"name_initial2\":\"char?\",\"id\":\"Guid\",\"age\":\"int\",\"age2\":\"int?\",\"weight\":\"double\",\"weight2\":\"double?\",\"boole\":\"boolean\",\"boole2\":\"boolean?\",\"longg\":\"long\",\"longg2\":\"long?\",\"decimall\":\"Decimal\",\"decimall2\":\"Decimal?\",\"floatt\":\"single\",\"floatt2\":\"single?\",\"bytee\":\"byte\",\"bytee2\":\"byte?\",\"s_bytee\":\"sbyte\",\"s_bytee2\":\"sbyte?\",\"short\":\"short\",\"short2\":\"short?\",\"u_short\":\"ushort\",\"u_short2\":\"ushort?\",\"u_intt\":\"uint\",\"u_intt2\":\"uint?\",\"u_longg\":\"ulong\",\"u_longg2\":\"ulong?\",\"created_at\":\"DateTime\",\"created_at_nullable\":\"DateTime?\",\"date_time_offsettt\":\"DateTimeOffset\",\"date_time_offsetttt\":\"DateTimeOffset?\",\"time_spantt\":\"TimeSpan\",\"time_spanrrr\":\"TimeSpan?\",\"test_structs\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"test_structss\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"car2\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"queisso_getne\":{\"prop1\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"prop2\":\"DateTime?\",\"prop3\":\"CarType\"}}";
            var strategy = new SnakeCaseNamingStrategy();

            // act
            var json = ClassStructureSerializeExtensions.GetClassStructure<Car>(strategy, Formatting.None);

            // assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void GetClassStructureConverter_Should_Throws_Exception_When_Try_ReadJson()
        {
            // arrange
            var json = "{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\",\"name_initial\":\"char\",\"name_initial2\":\"char?\",\"id\":\"Guid\",\"age\":\"int\",\"age2\":\"int?\",\"weight\":\"double\",\"weight2\":\"double?\",\"boole\":\"boolean\",\"boole2\":\"boolean?\",\"longg\":\"long\",\"longg2\":\"long?\",\"decimall\":\"Decimal\",\"decimall2\":\"Decimal?\",\"floatt\":\"single\",\"floatt2\":\"single?\",\"bytee\":\"byte\",\"bytee2\":\"byte?\",\"s_bytee\":\"sbyte\",\"s_bytee2\":\"sbyte?\",\"short\":\"short\",\"short2\":\"short?\",\"u_short\":\"ushort\",\"u_short2\":\"ushort?\",\"u_intt\":\"uint\",\"u_intt2\":\"uint?\",\"u_longg\":\"ulong\",\"u_longg2\":\"ulong?\",\"created_at\":\"DateTime\",\"created_at_nullable\":\"DateTime?\",\"date_time_offsettt\":\"DateTimeOffset\",\"date_time_offsetttt\":\"DateTimeOffset?\",\"time_spantt\":\"TimeSpan\",\"time_spanrrr\":\"TimeSpan?\",\"test_structs\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"test_structss\":{\"prop1\":\"string\",\"prop2\":\"int\"},\"car2\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"queisso_getne\":{\"prop1\":{\"car_type1\":\"CarType\",\"car_type2\":\"CarType?\",\"name\":\"string\"},\"prop2\":\"DateTime?\",\"prop3\":\"CarType\"}}";
            var resolver = new AvoidNullContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var settings = new JsonSerializerSettings
            {
                ContractResolver = resolver
            };

            settings.Converters.Add(new ClassStructureSerialize());

            // act & assert
            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                var obj = JsonConvert.DeserializeObject<Car>(json, settings);
            });

            Assert.Equal("ClassStructureSerialize cannot be parsed from a string json", exception.Message);
        }

        [Fact]
        public void DefaultValueProvide_Should_Set_And_Get_Value()
        {
            // arrange & act
            var car = new Car { Name = "test" };
            var initialValueProvider = new DefaultValueProvider<Car>(car);

            var car2 = new Car { Name = "test2" };
            var valueProvider = new DefaultValueProvider<Car>(car2);
            valueProvider.SetValue(null, new Car { Name = "test3" });

            // assert
            Assert.Equal("test", ((Car)initialValueProvider.GetValue(null)).Name);
            Assert.Equal("test3", ((Car)valueProvider.GetValue(null)).Name);
        }
    }
}

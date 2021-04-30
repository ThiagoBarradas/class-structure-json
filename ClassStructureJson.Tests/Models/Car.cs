using System;

namespace ClassStructureJson.Tests.Models
{
    public enum CarType
    {
        Test,
        Test2
    }

    public class Car
    {
        public CarType CarType1 { get; set; }
        public CarType? CarType2 { get; set; } 
        public string Name { get; set; }
        public char NameInitial { get; set; }
        public char? NameInitial2 { get; set; }
        public Guid Id { get; set; }
        public int Age { get; set; }
        public int? Age2 { get; set; }
        public double Weight { get; set; }
        public double? Weight2 { get; set; }
        public bool Boole { get; set; }
        public Nullable<bool> Boole2 { get; set; }
        public long Longg { get; set; }
        public long? Longg2 { get; set; }
        public decimal Decimall { get; set; }
        public decimal? Decimall2 { get; set; }
        public float Floatt { get; set; }
        public float? Floatt2 { get; set; }
        public byte Bytee { get; set; }
        public byte? Bytee2 { get; set; }
        public sbyte SBytee { get; set; }
        public sbyte? SBytee2 { get; set; }
        public short Short { get; set; }
        public short? Short2 { get; set; }
        public ushort UShort { get; set; }
        public ushort? UShort2 { get; set; }
        public uint UIntt { get; set; }
        public uint? UIntt2 { get; set; }
        public ulong ULongg { get; set; }
        public ulong? ULongg2 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CreatedAtNullable { get; set; }
        public DateTimeOffset DateTimeOffsettt { get; set; }
        public DateTimeOffset? DateTimeOffsetttt { get; set; }
        public TimeSpan TimeSpantt { get; set; }
        public TimeSpan? TimeSpanrrr { get; set; }
        public TestStruct TestStructs { get; set; }
        public TestStruct? TestStructss { get; set; }
        public Car2 Car2 { get; set; }

        public CarG<Car2, DateTime?, CarType> QueissoGetne { get; set; }
    }

    public struct TestStruct
    {
        public string Prop1;
        public int Prop2;
    }

    public class CarG<T1, T2, T3>
    {
        public T1 Prop1 { get; set; }
        public T2 Prop2 { get; set; }
        public T3 Prop3 { get; set; }
    }

    public class Car2
    {
        public CarType CarType1 { get; set; }
        public CarType? CarType2 { get; set; }
        public string Name { get; set; }
    }
}
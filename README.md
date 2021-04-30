[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ThiagoBarradas_class-structure-json&metric=alert_status)](https://sonarcloud.io/dashboard?id=ThiagoBarradas_class-structure-json)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=ThiagoBarradas_class-structure-json&metric=coverage)](https://sonarcloud.io/dashboard?id=ThiagoBarradas_class-structure-json)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ClassStructureJson.svg)](https://www.nuget.org/packages/ClassStructureJson/)
[![NuGet Version](https://img.shields.io/nuget/v/ClassStructureJson.svg)](https://www.nuget.org/packages/ClassStructureJson/)

# Class Structure Json

Describe your class structure as Json

## Install via NuGet

```
PM> Install-Package ClassStructureJson
```

## How to use

Class sample
```
public class Person
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Age { get; set; }
    public SubClassTest SomeProperty { get; set; }
}

public class SubClassTest
{
    public bool TestBoolean { get; set; }
    public uint? TestUintNullable { get; set; }
}
```

Describing class structure
```
using ClassStructureJson;

// ...

var strategy = new SnakeCaseNamingStrategy();

var json = typeof(Person).GetClassStructure();

Console.WriteLine(json);
```

Output
```
{
  "name": "string",
  "created_at": "DateTime",
  "age": "int",
  "some_property": {
    "test_boolean": "boolean",
    "test_uint_nullable": "uint?"
  }
}
```

## How can I contribute?

Please, refer to [CONTRIBUTING](.github/CONTRIBUTING.md)

## Found something strange or need a new feature?

Open a new Issue following our issue template [ISSUE TEMPLATE](.github/ISSUE_TEMPLATE.md)

## Changelog

See in [nuget version history](https://www.nuget.org/packages/ClassStructureJson)

## Did you like it? Please, make a donate :)

if you liked this project, please make a contribution and help to keep this and other initiatives, send me some Satochis.

BTC Wallet: `1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX`

![1G535x1rYdMo9CNdTGK3eG6XJddBHdaqfX](https://i.imgur.com/mN7ueoE.png)

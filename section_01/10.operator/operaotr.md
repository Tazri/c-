Operator
========
Here c# supports all operator names : 

1. Arithmetic Operators.
2. Relational Operators.
3. Logical Operators.
4. Assignment Operators.
5. Bitwise Operator.
6. Conditional Operator.
7. Special Operator.

## Arithmetic Operator
| Operaotr | Examle  |Example | Name                                                                                 |
|----------|---------|--------|--------------------------------------------------------------------------------------|
| +        | a + b   | +a     | Addition or unary plus                                                               |
| -        | a - b   | -a     | Subtraction or unary minus                                                           |
| *        | a * b   | a * b  | Multiplication                     |
| /        | a / b   | a / b  | Division |
| %        | a % b   | a % b  | Modulos  |
| ++       | ++a     | a++    | pre-increment and post-increment |
| --       | --a     | a--    | post-dcrement and post-dcrement  |

> 🟢 Real and Integeral mixed operation always return real number.


## Relational Operator
| Operator | Name                                                 |
|----------|------------------------------------------------------|
| <        | is less than                                         |
| <=       | is less than or equal to                             |
| >        | is greater than                                      |
| >=       | is greater than or equal                             |
| ==       | is equal to                                          |
| !=       | is not equal to                                      |

> 🟢 Relational operator always return true or false.

## Logical Operator
| Operator  | Name                                                          |
|-----------|---------------------------------------------------------------|
| &&        | logical AND                                                   |
| \|\|      | logical OR                                                    |
| \!        | logical NOT                                                   |
| &         | bitwise logical AND                                           |
| \|        | bitwise logical OR                                            |
| \^        | bitwise logical exclusive OR                                  |


> 🟢 In C# logical operator only work with bool type data and return bool.

## Assignment Operator 
| Operator  | Example    | Meaning     | Name                                                          |
|-----------|------------|-------------|---------------------------------------------------------------|
| =         | a = value  | a = value   | equal                                                         |
| +=        | a += b     | a = a + b   | plus equal |
| -=        | a -= b     | a = a - b   | minus equal|
| *=        | a *= b     | a = a * b   | multiplication equal |
| /=        | a /= b     | a = a / b   | divition equal      |
| %=        | a %= b     | a = a % b   | modulus equal  |

## Conditional Operator 
Syntax : 
```cs
<dataType> variable_name = bool_expression ? true_expression : false_expression;
```

## Bitwise Operator
| Operator | Name                     |
|----------|--------------------------|
| &        | bitwise AND              |
| \|       | bitwise OR               |
| \^       | bitwise XOR              |
| ~        | bitwise inverse          |
| <<       | sheft left               |
| >>       | sheft right              |

## Special Operator
C# supports the following special operator : 
| operator | operator name              |
|----------|----------------------------|
| is       | relational operator        |
| as       | relational operator        |
| typeof   | type operator              |
| sizeof   | size operator              |
| new      | object creator             |
| .(dot)   | member access operator     |
| checked  | overflow checking          |
| uncheked | prevention of overflow checking |

<hr />
<br />

[< Boxing Unboxing](./../09.boxing_unboxing/boxing_unboxing.md) | [Procedural](./../section_01.md) | [Type Convertion >](./../11.type_conversion/type_conversion.md)
---------
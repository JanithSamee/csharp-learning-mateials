# Type Casting

### Types of casting
* Implicit Casting (automatically) - converting a smaller type to a larger type size
> char -> int -> long -> float -> double

* Explicit Casting (manually) - converting a larger type to a smaller size type
> double -> float -> long -> int -> char
 
### using `Convert`
```csharp
string frac = "456";
int intFrac = Convert.ToInt32(frac);
Console.WriteLine(intFrac.GetType());
```

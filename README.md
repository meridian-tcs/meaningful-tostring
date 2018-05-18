# Meaningful `ToString()`
[![Build Status Badge](https://ci.appveyor.com/api/projects/status/v01tvsrcdqo9w63w?svg=true)](https://ci.appveyor.com/project/mmiddleton3301/meaningful-tostring) [![Downloads Badge](https://img.shields.io/nuget/dt/Meridian.MeaningfulToString.svg)](https://www.nuget.org/packages/Meridian.MeaningfulToString) [![Version Badge](https://img.shields.io/nuget/v/Meridian.MeaningfulToString.svg)](https://www.nuget.org/packages/Meridian.MeaningfulToString)

Meaningful `ToString()` is an extremely lightweight .NET class library that
helps describe your instances in a more meaningful way.

The default `object.ToString()` isn't very useful when debugging or logging.
Meaningful `ToString()` creates a string that looks something like:

`"Employee (Id = 13298279, Title = Head of Sales, FirstName = Fred, LastName = Smith, Emails = System.String[], Manager = Employee (Id = 13298278, Title = Managing Director, FirstName = Joe, LastName = Bloggs, Emails = System.String[], Manager = null))"`

And this is all that Meaningful `ToString()` does!

## Requirements
Meaningful `ToString()` can be used in the following environments:

- dotnet Core (CoreCLR) 2 projects;
- full-fat .NET framework, v4.6.1 and beyond

## Quick Start Guide
1. **Include the NuGet package:**
   
   `Install-Package Meridian.MeaningfulToString`
   
   
2. **Alter your class to inherit from `Meridian.MeaningfulToString.MeaningfulBase`**
  
   For example:
  
   ```
   public class Employee : Meridian.MeaningfulToString.MeaningfulBase
   {
     public int Id
     {
       get;
       set;
     }
     
     // TODO: ... the rest of your class implementation here ...
   }
   ```
   
   - **Note 1:** You can have multiple base classes - just as long as ultimately, the class you want meaningful values for `ToString()` inherits from `MeaningfulBase`.
   - **Note 2:** This is actually not 100% required; this is just the quick start. If you'd rather *not* inherit all your classes from this base class, see below section "Without Inheriting from `MeaningfulBase`".
   
  3. **That's it! Start debugging/logging!**
  
## Without Inheriting from `MeaningfulBase`
You don't have to inherit from `MeaningfulBase` if you don't want to. Simply `override` your class' implementation of `ToString()`, and call the object extension method `MeaningfulToString()`:

```
public override string ToString()
{
    return this.MeaningfulToString();
}
```

As with all extension methods, just remember to make sure to include the `Meridian.MeaningfulToString` namespace in your `usings`:

`using Meridian.MeaningfulToString;`

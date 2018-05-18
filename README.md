# Meaningful `ToString()`
Meaningful `ToString()` is an extremely lightweight .NET class library that
helps describe your instances in a more meaningful way.

The default `object.ToString()` isn't very useful when debugging or logging.
Meaningful `ToString()` creates a string that looks something like:

`"Employee (Id = 13298279, Title = Head of Sales, FirstName = Fred, LastName = Smith, Emails = System.String[], Manager = Employee (Id = 13298278, Title = Managing Director, FirstName = Joe, LastName = Bloggs, Emails = System.String[], Manager = null))"`

And this is all that Meaningful `ToString()` does!

# Requirements
Meaningful `ToString()` can be used in the following environments:

- dotnet Core (CoreCLR) 2 projects;
- full-fat .NET framework, v4.6.1 and beyond
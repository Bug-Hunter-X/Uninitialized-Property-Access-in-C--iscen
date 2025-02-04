# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing an uninitialized property.  Uninitialized properties can lead to unexpected behavior, especially when dealing with value types.  The example shows how to avoid this issue.

## Bug
The `Bug.cs` file shows a C# class with a property that is accessed before it's assigned a value.  This will not throw an exception but result in default values being used, which could lead to incorrect program logic.

## Solution
The `BugSolution.cs` file demonstrates the correct approach: initializing the property either in the constructor or before accessing it.
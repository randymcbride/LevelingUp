The ShoppingCart calculates prices for items and sells them to customers if they have enough money. Run the unit tests for the code in the 
'Before' folder of this module and you will see one is failing. The test fails because the ShoppingCart has an
'Aliasing Bug'. The bug is introduced the Reserve method changes the value of the Amount property
of the Cost object without the Buy Method realizing it. In order to prevent this, we can make the MoneyAmount class immutable. Making the class
imutable doesn't fix the bug. It makes it obvious what the problem is though. We just need to check if they have enough money after
reserving the item, because the Reserve method returns a new MoneyAmount. It is now impossible to use money amount to create a side affect
that could lead to aliasing bugs.

In the After folder we make the class immutable by (1) removing all the public setters, (2) creating a factory method (in this case the constructor), and
(3) add operations that return new instance of the immutable class (in this case, the Increment and Multiply methods). Now that it is immutable, the ShoppingCart is not able to
use the buggy code, it must be refactored to use the immutable class properly which eliminates the 'Aliasing Bug'.

Making a class immutable is a good first step, and in most cases is enough. However, if we need to evaluate equality, or add instances 
of the class to a hashed colleciton (like a HashSet) then we must convert the class into a value object. This module did not go that far, but
it is easy to do so in c#. Simply create a struct (instead of class) that extends the System.IEquatable<T> interface. Here is documentation on how to do that:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type
SoldArticles have warranties.  What should the consuming code do for products that don't have a warranty. It is 
not illogicial to just leave it null, after all the product does not have a warranty. However, as demonstrated by the
unit tests pointing at the Before version of the module, this leads to null reference errors when checking if a product
can be returned!

The better solution is to create a Null Object version of the class (VoidWarranty). Notice that VoidWarranty and TimeWarranty
are interchangeable because they implement the same interface--the consuming code does not care what type of warranty a product has
as long as it is of type IWarranty. 

The other difference between the Before and After versions is that the After SoldArticle will not accept nulls in its constructor,
thus saving the programmer from themselves. They might be confused for a moment but hopefully they will realize that they could use
VoidWarranty or even TimeWaranty and just set the time in the past. The point is they will be forced to come up with an acceptabel solution.
Now, no matter the circumstance, the consuming code can have confidence when asking if the product can be returned.

-----------
Extra mile
-----------
The design in after is not true OO programming. It is still procedural because IWarranty only offers information about itself, it does not offer
any features. The client is still going to need to check if it can be voided, and then figure out how to claim it. The extra mile takes the SoldArticle and IWarranty
classes a step further to make this a true OO design (using ideas in module 1). Notice there will never be a reason to write if statements or check for null!
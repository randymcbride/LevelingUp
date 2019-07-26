We pick up where we left off in the previous module. Now our SoldArticles can have components
and these components can have their own warranties. The problem with the new feature is that
SoldArticle.ClaimCircuitWarranty and SoldArticle.CircuitryNotOperational will throw null reference
errors if the article does not have circuitry. Null objects don't solve the problem becuase 
the Circuitry object is used as a parameter in the CircuitryWarranty.Claim method. We need an Optional Object.

In the After folder we find a class called Maybe. Maybe allows us to wrap any object and make it Optional. The cost is
very low for the consuming code. It simply needs to provide a delegate to the optional objects Do method and now you 
will never have a null refrence for that optional object. We wrap circuit in the Maybe class and wallah, no null references
(as you can see in AfterTests.cs)
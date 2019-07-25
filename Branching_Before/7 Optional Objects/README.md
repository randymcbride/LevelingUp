We pick up where we left off in the previous modele. Now are SoldArticles can have components
and these components can have their own warranties. The problem with the new feature is that
SoldArticle.ClaimCircuitWarranty and SoldArticle.CircuitryNotOperational will throw null reference
errors if the article does not have circuitry. Null objects don't solve the problem becuase 
the Circuitry object is used as a parameter in the CircuitryWarranty.Claim method. We need an Optional Object.
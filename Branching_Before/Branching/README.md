The problem with the AccountBad class is that there are too many different paths the code could take.
The branching if statements make the code harder to read, test, and maintain. If we could delegate the management
of the state of the account to a different class, that would leave the account class to focus on what it was intended to do--
manage the balance.

The AccountGood class delegates its state management to the IAccountState interface. All it does is manage the balance. A good
indicator that this solution is more object oriented is the fact that we have more than one class, and each class is simple.
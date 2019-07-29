We continue working with sold articles and warranties. We added a feature that allows you to
call claim warranty on a sold article. The article will analyze its own state and then process the
warranty accordingly. SoldArticle in the before folder employs an enum and switch statement to record its
state. The problem with that approach is that we will need to modify the class if requirements change. It would be
better if we simply extended the class every time requirements change.

The after folder accomplishes this by encapsulating the state of a device's operation in a seperate class than mapping functionality
to that status. Initially this looks like the same solution as a switch statement, but it has the advantage of using objects,
which can be moved to a different class and there for hidden from the client code. They can also be abstracted so that one set of warranty rules
can be replaced with another.
This module continues where we left off in "2 Avoid Looping with IEnumerableExtensions". We have added some new features to
our PaintJobEstimator class. Our code is starting to repeat. We are writing the same linq queries over and over again. There 
are two solutions to this problem--each is better suited to specific situation. We will implement both of them in the "After"
folder.

One solution is to wrap the sequence in a class, and then provide methods to do something with that class. The Painters class
does this. The other solution is to use the composite pattern. The composite pattern describes a sequence of objects using a
single instance of that object. The PainterGroup class demonstrates this pattern.
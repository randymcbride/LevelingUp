The PaintJobEstimator will help you find the cheapest available painter for your next paint job.
the problem is that its code (in the before folder) is hard to read because it is a little long and nested.
The better version (in the after folder) does not use looping or branching at all. It replaces it with Linq queries
and extension methods on the IEnumerable class. The result is a method that is so simple you will know exactly what it is
doing in less than 30 seconds. All the complexity is still there, but it is abstracted away in the a generic `WithMinimum`
extension method. We used encapsulation to make our code more readable, easier to extend, and simpler to test.

We should be using linq queries as much as possible to avoid loops
We continue building on the features added in the third module. Our Painters class simplified the calculaiton
of time and cost for a paint job. However, its WorkTogether class is too rigid. It only works if the painters in the
sequence all generate their time estimates the same way--linearly. If we wanted to support working together with painters
who calcualte their time differently, then we will need to introduce an entire new class.

The Painters.WorkTogehther method in this module uses a strategy object called IPainterScheduler. Now the method doesn't
need to concern itself whith determining how each painter gets its time estimates. It only needs to worry about how to combine
all the estimates and return an IPainter.

If you look at the new version of the WorkTogether method it expects you to tell it WHAT you want it to work on and HOW (i.e. the strategy)
you want it done this is a perfect example of a TEMPLATE method that utilizes a STRATEGY object.
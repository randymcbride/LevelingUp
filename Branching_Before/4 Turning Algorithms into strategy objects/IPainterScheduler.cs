using OO_Patterns.Looping;
using System;
using System.Collections.Generic;

namespace OO_Patterns.Strategies
{
	public interface IPainterScheduler<TPainter> where TPainter : IPainter
	{
		IEnumerable<PaintingTask<TPainter>> Schedule(double sqareFeet, IEnumerable<TPainter> painters);
	}
}
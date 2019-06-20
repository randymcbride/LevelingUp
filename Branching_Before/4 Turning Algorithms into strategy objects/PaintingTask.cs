using OO_Patterns.Looping;

namespace OO_Patterns.Strategies
{
	public class PaintingTask<TPainter> where TPainter : IPainter
	{
		public TPainter Painter { get; set; }
		public double SquareFeet { get; set; }
	}
}
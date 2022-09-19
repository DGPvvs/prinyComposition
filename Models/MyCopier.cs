namespace CopierComposition.Models
{
	using CopierComposition.Models.AbstractClasses;

	public class MyCopier : Copier
	{
		public MyCopier(Printer printer, Scanner scanner, Picture image) : base(printer, scanner, image)
		{
		}
	}
}

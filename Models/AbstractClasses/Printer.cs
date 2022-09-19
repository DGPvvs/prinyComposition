using CopierComposition.Models.Contracts;

namespace CopierComposition.Models.AbstractClasses
{
	public class Printer : Device, IPrinter
	{
		public Printer(Picture image) : base(image)
		{
		}

		public void CanPrint(Picture image)
		{
			//TODO: Print image
		}
	}
}

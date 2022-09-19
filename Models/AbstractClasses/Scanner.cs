using CopierComposition.Models.Contracts;

namespace CopierComposition.Models.AbstractClasses
{
	public class Scanner : Device, IScanner
	{
		public Scanner(Picture image) : base(image)
		{
		}

		public Picture CanScan()
		{
			//TODO: Scann this.Image
			return this.Image;
		}
	}
}

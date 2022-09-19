namespace CopierComposition.Models
{
	using CopierComposition.Models.Contracts;

	public abstract class Device : IDevice
	{
		private Picture image;

		protected Device(Picture image)
		{
			Image = image;
		}

		public Picture Image { get => image; set => image = value; }
	}
}

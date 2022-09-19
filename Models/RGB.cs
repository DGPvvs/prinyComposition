namespace CopierComposition.Models
{
	public class RGB
	{
		private byte red;
		private byte green;
		private byte blue;

		public RGB(byte red, byte green, byte blue)
		{
			this.Red = red;
			this.Green = green;
			this.Blue = blue;
		}

		public byte Red { get => red; set => red = value; }
		public byte Green { get => green; set => green = value; }
		public byte Blue { get => blue; set => blue = value; }
	}
}
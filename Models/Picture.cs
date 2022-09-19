using System;

namespace CopierComposition.Models
{
	public class Picture
	{
		private int width;
		private int height;
		private int resolution;
		private RGB[,] image;

		public Picture(int width, int height, int resolution)
		{
			this.SetSize(width, height);			
		}
		
		public int Width { get => width; set => width = value; }
		public int Height { get => height; set => height = value; }
		public int Resolution { get => resolution; set => resolution = value; }

		public void SetSize(int width, int height)
		{
			this.Width = width;
			this.Height = height;
			this.SetPictureSize();
		}

		private void SetPictureSize()
		{
			this.image = new RGB[this.Resolution * this.Width, this.Resolution * this.Height];
		}
	}
}

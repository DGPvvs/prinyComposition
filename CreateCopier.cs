namespace CopierComposition
{
	using CopierComposition.Models;

	class CreateCopier
	{
		static void Main(string[] args)
		{
			Picture picture = new Picture(300, 300, 72);

			MyPrinter myPrinter = new MyPrinter(picture);
			MyScanner myScanner = new MyScanner(picture);
			MyCopier myCopier = new MyCopier(myPrinter, myScanner, picture);

			myCopier.CanCopy();
		}
	}
}

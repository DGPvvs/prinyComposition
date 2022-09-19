using CopierComposition.Models.Contracts;

namespace CopierComposition.Models.AbstractClasses
{
	public class Copier : Device, ICopier
	{
		private IPrinter printer;
		private IScanner scanner;

		public Copier(Picture image) : base(image)
		{
		}

		public Copier(IPrinter printer, IScanner scanner, Picture image) : this(image)
		{
			this.Printer = printer;
			this.Scanner = scanner;
		}

		public IPrinter Printer { get => printer; set => printer = value; }
		public IScanner Scanner { get => scanner; set => scanner = value; }

		public void CanCopy()
		{
			this.Printer.CanPrint(this.Scanner.CanScan());
		}
	}
}

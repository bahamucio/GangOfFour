using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Adapter' class
	/// </summary>
	public class RichCompound : Compound
	{
		private ChemicalDataBank _bank;

		public RichCompound(string name) : base(name)
		{
		}

		public override void Display()
		{
			// The Adaptee
			_bank = new ChemicalDataBank();

			_boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
			_meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
			_molecularWeight = _bank.GetMolecularWeight(_chemical);
			_molecularFormula = _bank.GetMolecularStructure(_chemical);
			
			base.Display();
			Console.WriteLine("    Formula: {0}", _molecularFormula);
			Console.WriteLine("    Weight: {0}", _molecularWeight);
			Console.WriteLine("    Melting pt: {0}", _meltingPoint);
			Console.WriteLine("    Boiling pt: {0}", _boilingPoint); 
		}
	}
}

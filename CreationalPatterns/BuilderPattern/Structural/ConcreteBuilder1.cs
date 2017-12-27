using System;

namespace Structural
{
	/// <summary>
	/// The 'ConcreteBuilder1' class
	/// </summary>
	public class ConcreteBuilder1 : Builder
	{
		private Product _product = new Product();

		public override void CreatePartA()
		{
			_product.Add("PartA");
		}

		public override void CreatePartB()
		{
			_product.Add("PartB");
		}

		public override Product GetResult()
		{
			return _product;
		}
	}
}

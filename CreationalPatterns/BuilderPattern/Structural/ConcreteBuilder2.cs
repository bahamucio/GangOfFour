using System;

namespace Structural
{
	/// <summary>
	/// The 'ConcreteBuilder2' class
	/// </summary>
	public class ConcreteBuilder2 : Builder
	{
		private Product _product = new Product();

		public override void CreatePartA()
		{
			_product.Add("PartX");
		}

		public override void CreatePartB()
		{
			_product.Add("PartY");
		}

		public override Product GetResult()
		{
			return _product;
		}
	}
}

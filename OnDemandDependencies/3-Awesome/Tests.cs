using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnDemandDependencies.Dependencies;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._3_Awesome
{	
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void Will_Test_SomeOtherMethod()
		{
			var stubDependencyA = MockRepository.GenerateStub<IDependencyA>();
			// stub DependencyA here
			var stubDependencyD = MockRepository.GenerateStub<IDependencyD>();
			// stub DependencyD here

			var stubDependencyResolver = MockRepository.GenerateStub<IDependencyResolver>();
			stubDependencyResolver
				.Stub(x => x.GetInstance<IDependencyA>())
				.Return(stubDependencyA);
			stubDependencyResolver
				.Stub(x => x.GetInstance<IDependencyD>())
				.Return(stubDependencyD);

			var businessEngine = new MyBusinessEngine(stubDependencyResolver);
			businessEngine.SomeOtherMethod();

			// add asserts here
		}
	}
}

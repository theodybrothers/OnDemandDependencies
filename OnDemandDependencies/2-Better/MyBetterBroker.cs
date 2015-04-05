using OnDemandDependencies.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._2_Better
{
	public class MyBetterBroker
	{
		private readonly IDependencyResolver DependencyResolver;

		//Constructor injection of MyDependencyResolver from IoC
		public MyBetterBroker(IDependencyResolver dependencyResolver)
		{
			DependencyResolver = dependencyResolver;
		}

		public void SomeMethod()
		{
			var dependencyA = DependencyResolver.GetInstance<IDependencyA>();
			var dependencyD = DependencyResolver.GetInstance<IDependencyD>();

			//...
		}
	}
}

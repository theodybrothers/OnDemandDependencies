using OnDemandDependencies.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._3_Awesome
{
	public class MyBusinessEngine
	{
		private readonly IDependencyResolver DependencyResolver;

		//Constructor injection of MyDependencyResolver from IoC
		public MyBusinessEngine(IDependencyResolver dependencyResolver)
		{
			DependencyResolver = dependencyResolver;
		}

		public void SomeMethod()
		{
			var dependencyA = DependencyResolver.GetInstance<IDependencyA>();
			var dependencyD = DependencyResolver.GetInstance<IDependencyD>();

			//...
		}

		public void SomeOtherMethod()
		{
			var dependencyA = DependencyResolver.GetInstance<IDependencyA>();
			
			//...

			SomeMethod(); //Now, we will need an instance of IDependencyA again.

			//...
		}
	}
}

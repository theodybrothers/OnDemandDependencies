using OnDemandDependencies.Dependencies;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._1_Improved
{
	public class MyImprovedBroker
	{
		public class MyBroker
		{
			public MyBroker()
			{
			}

			public void SomeMethod()
			{
				var dependencyA = MyContainer.Container.GetInstance<IDependencyA>();
				var dependencyD = MyContainer.Container.GetInstance<IDependencyD>();

				//...
			}
		}
	}
}

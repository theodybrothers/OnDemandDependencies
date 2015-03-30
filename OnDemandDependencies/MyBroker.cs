using OnDemandDependencies.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies
{
    public class MyBroker
    {
		private readonly IDependencyA DependencyA;
		private readonly IDependencyB DependencyB;
		private readonly IDependencyC DependencyC;
		private readonly IDependencyD DependencyD;
		private readonly IDependencyE DependencyE;

		public MyBroker(IDependencyA dependencyA, IDependencyB dependencyB, IDependencyC dependencyC,
			IDependencyD dependencyD, IDependencyE dependencyE)
		{
			DependencyA = dependencyA;
			DependencyB = dependencyB;
			DependencyC = dependencyC;
			DependencyD = dependencyD;
			DependencyE = dependencyE;
		}

		//Multiple functions that use the above dependencies. 
		//Note that everyone of the methods does not use all five of the dependencies; some might use
 		//all five when others might only use a few.
    }
}

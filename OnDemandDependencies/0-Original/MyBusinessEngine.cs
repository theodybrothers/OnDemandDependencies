using OnDemandDependencies.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._0_Original
{
    public class MyBusinessEngine
    {
		private readonly IDependencyA DependencyA;
		private readonly IDependencyB DependencyB;
		private readonly IDependencyC DependencyC;
		private readonly IDependencyD DependencyD;
		private readonly IDependencyE DependencyE;
		private readonly IDependencyF DependencyF;

		//Constructor injection from IoC
		public MyBusinessEngine(IDependencyA dependencyA, IDependencyB dependencyB, IDependencyC dependencyC,
			IDependencyD dependencyD, IDependencyE dependencyE, IDependencyF dependencyF)
		{
			DependencyA = dependencyA;
			DependencyB = dependencyB;
			DependencyC = dependencyC;
			DependencyD = dependencyD;
			DependencyE = dependencyE;
			DependencyF = dependencyF;
		}

		//Multiple functions that use the above dependencies. 
		//Note that everyone of the methods does not use all of the dependencies; some might use
 		//all of them when others might only use a few.
    }
}

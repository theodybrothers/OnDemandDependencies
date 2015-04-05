using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._1_Improved
{
	public static class MyContainer
	{
		public static Container Container = new Container(x =>
		{
			x.For<IDependencyResolver>().Use<MyDependencyResolver>();
			//...
		});
	}
}

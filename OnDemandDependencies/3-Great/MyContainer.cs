using Microsoft.Practices.ServiceLocation;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies.OnDemandDependencies._3_Great
{
	public static class MyContainer
	{
		public static void Initialize()
		{
			var container = new Container(x =>
			{
				x.For<IDependencyResolver>().Use<MyDependencyResolver>();
				//...
			});

			ServiceLocator.SetLocatorProvider(() =>
				new CommonServiceLocator.StructureMapAdapter.Unofficial.StructureMapServiceLocator(
					container));
		}
	}
}

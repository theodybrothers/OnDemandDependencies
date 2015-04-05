using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._2_Better
{
	public class MyDependencyResolver : IDependencyResolver
	{
		public T GetInstance<T>()
		{
			return MyContainer.Container.GetInstance<T>();
		}
	}
}

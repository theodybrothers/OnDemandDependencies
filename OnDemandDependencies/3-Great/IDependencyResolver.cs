using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies.OnDemandDependencies._3_Great
{
	public interface IDependencyResolver
	{
		T GetInstance<T>();
	}
}

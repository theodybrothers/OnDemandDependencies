using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies._3_Awesome
{
	public interface IDependencyResolver
	{
		T GetInstance<T>() where T : class;
	}
}

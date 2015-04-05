using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDemandDependencies.OnDemandDependencies._3_Great
{
	public class MyDependencyResolver : IDependencyResolver
	{
		private Dictionary<Type, object> SessionInstances = new Dictionary<Type, object>();

		public T GetInstance<T>() 
			where T : class
		{
			object instance = null;
			
			if (!SessionInstances.TryGetValue(typeof(T), out instance))
			{
				instance = ServiceLocator.Current.GetInstance<T>(); 

				SessionInstances.Add(typeof(T), instance);
			}

			return instance as T;
		}
	}
}

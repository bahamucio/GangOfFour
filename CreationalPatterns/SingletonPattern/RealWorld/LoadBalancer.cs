using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Singleton' class
	/// </summary>
	public class LoadBalancer
	{
		private static LoadBalancer _instance;
		private List<string> _servers = new List<string>();
		private Random _random = new Random();

		// Lock synchronization object
		private static object syncLock = new Object();

		protected LoadBalancer()
		{
			_servers.Add("Server I");
			_servers.Add("Server II");
			_servers.Add("Server III");
			_servers.Add("Server IV");
			_servers.Add("Server V");
		}

		public static LoadBalancer GetLoadBalancer()
		{
			// Support multithreaded application through
			// 'Double checked locking' patter which (once
			// the instance exists) avoid locking each
			// time the method is invoked
			if(_instance == null)
			{
				lock(syncLock)
				{
					if(_instance == null)
					{
						_instance = new LoadBalancer();
					}
				}
			}
			return _instance;
		}

		// Simple, but effective random load balancer
		public string Server
		{
			get
			{
				int r = _random.Next(_servers.Count);
				return _servers[r].ToString();
			}
		}
	}
}

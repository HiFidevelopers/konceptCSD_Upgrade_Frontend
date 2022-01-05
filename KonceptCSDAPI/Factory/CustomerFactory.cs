﻿using KonceptCSDAPI.Managers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace KonceptCSDAPI.Factory
{
	public class CustomerFactory
	{
		public IUserManager CustomerManager(IConfiguration configuration, IHostingEnvironment HostingEnvironment)
		{
			ICustomerManager returnvalue = new CustomerManager(configuration, HostingEnvironment);

			return returnvalue;
		}
	}
}
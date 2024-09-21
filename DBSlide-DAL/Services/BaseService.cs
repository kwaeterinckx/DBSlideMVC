using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSlide_DAL.Services
{
    public abstract class BaseService
    {
        protected string _ConnectionString;

        protected BaseService(IConfiguration configuration, string connectionStringName)
        {
            _ConnectionString = configuration.GetConnectionString(connectionStringName);
        }
    }
}

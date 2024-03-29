﻿using Dapper;

namespace WebApplicationDapper.Repositories
{
    public abstract class RepositoryBase<T>
    {
        protected string ConnectionString { get; set; }

        protected RepositoryBase(IConfiguration config)
        {
            //DefaultTypeMap.MatchNamesWithUnderscores = true;
            DefaultTypeMap.MatchNamesWithUnderscores = false;
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
    }
}

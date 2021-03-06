﻿using SocialNW.BLL.Interfaces;
using SocialNW.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNW.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new UnitOfWork(connection));
        }
    }
}

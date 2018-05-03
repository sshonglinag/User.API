﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using User.API.Dtos;

namespace User.API.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// todo: 从token中获取当前请求用户的userid
        /// </summary>
        protected UserIdentity UserIdentity => new UserIdentity()
        {
            UserId = 1,
            Name = "djlnet"
        };
    }
}
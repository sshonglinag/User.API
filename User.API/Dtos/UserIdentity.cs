﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.Dtos
{
    public class UserIdentity
    {
        public int UserId { get; set; }

        // 以下属性包含在token-claim中
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
    }
}

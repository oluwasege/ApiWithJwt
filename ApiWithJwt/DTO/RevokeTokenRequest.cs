﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWithJwt.DTO
{
    public class RevokeTokenRequest
    {
        public string Token { get; set; }
    }
}

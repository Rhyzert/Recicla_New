﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Authentication.Interfaces
{
    public interface IJwtTokenGenerator

    {
        public string GenerateToken(Guid userId, string nome, string sobrenome);
    }
}

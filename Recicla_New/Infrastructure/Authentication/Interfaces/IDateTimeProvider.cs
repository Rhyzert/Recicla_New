﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Authentication.Interfaces
{
    public class IDateTimeProvider
    {
       public DateTime UtcNow {  get; }
    }
}
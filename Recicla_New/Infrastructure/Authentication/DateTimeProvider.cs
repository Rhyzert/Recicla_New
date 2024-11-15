using Infrastructure.Authentication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Authentication
{
    public class DateTimeProvider: IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;

    }
}

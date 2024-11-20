using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Authentication
{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        public string Secret { get; set; } = null!;
        public int ExpireMinutes {  get; set; }
        public string Issuer { get; set; } = null!;
        public string Audience { get; init; } = null!;
    }
}

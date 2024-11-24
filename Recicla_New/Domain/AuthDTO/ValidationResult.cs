using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AuthDTO
{
    public class ValidationResult
    {
        public List<string> Errors { get; set; } = new List<string>();

        public bool IsValid => !Errors.Any();
    }
}

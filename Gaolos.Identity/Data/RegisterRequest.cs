using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Identity.Data
{
    public class RegisterRequest
    {
        public RegisterRequest()
        {
        }
        public required string Email { get; init; }
        public required string Password { get; init; }
        public required string Name { get; init; }
        public required string Surname { get; init; }
    }
}

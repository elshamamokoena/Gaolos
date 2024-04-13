using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Identity.Data
{
    public class InfoResponse
    {
        public InfoResponse()
        {
        }
        public required string UserId { get; init; }
        public required string Email { get; init; } 
        public required string Name { get; init; }
        public required string Surname { get; init; }
        public required bool IsEmailConfirmed { get; init; }

    }
}

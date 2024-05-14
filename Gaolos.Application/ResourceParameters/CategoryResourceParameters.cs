using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.ResourceParameters
{
    public class CategoryResourceParameters:BaseResourceParameters
    {
        public string OrderBy { get; set; } = "Name";

    }
}

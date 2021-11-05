using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aemo_test_project.Model.Dto
{
    public class ResponseDto
    {
        public List<int> IndexPositions { get; set; } = new List<int>();
        public string Message { get; set; }
    }
}

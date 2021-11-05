using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aemo_test_project.Model.Dto
{
    public class RequestDto
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public string SubText { get; set; }
    }

}

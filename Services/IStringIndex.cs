using Aemo_test_project.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aemo_test_project.Services
{
    public interface IStringIndex
    {
        Task<ResponseDto> GetStringIndex(string text, string subtext);
    }
}

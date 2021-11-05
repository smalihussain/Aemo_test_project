using Aemo_test_project.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aemo_test_project.Services
{
    public class StringIndex : IStringIndex
    {
        public async Task<ResponseDto> GetStringIndex(string text, string subtext)
        {
            ResponseDto response = new ResponseDto();

            Regex rx = new Regex(subtext, RegexOptions.IgnoreCase);
            foreach (Match match in rx.Matches(text))
            {
                response.IndexPositions.Add(match.Index);
            }

            if (response.IndexPositions.Count > 0)
                response.Message = $"substring Text : '{subtext}' was found at following indexes "  + string.Join(", ", response.IndexPositions);

            return await Task.Run(() =>
            {
                return response;
            });
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }
    }
}

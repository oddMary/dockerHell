using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShows.Lib.Features
{
    public class StringTransform
    {
        public static string FirstUpper(string stringToTransform)
        {
            return stringToTransform.Substring(0, 1).ToUpper() + (stringToTransform.Length > 1 ? stringToTransform.Substring(1) : "");
        }
    }
}

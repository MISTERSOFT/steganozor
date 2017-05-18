using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steganography.Exceptions
{
    public class SourceImageHeightGreaterThanHost : Exception
    {
        public override string Message
        {
            get
            {
                return "Source image height is greater than host image height.";
            }
        }
    }
}

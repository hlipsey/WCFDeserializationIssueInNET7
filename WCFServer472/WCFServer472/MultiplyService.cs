using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer472
{
    public class MultiplyService : IMultiplyService
    {
        public MultiplyResponse Multiply(MultiplyRequest request)
        {
            return new MultiplyResponse() { Result = request.X * request.Y };
        }
    }
}

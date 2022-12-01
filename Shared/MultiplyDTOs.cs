using System;
using System.Runtime.Serialization;

namespace Shared
{
    [DataContract]
    public class MultiplyRequest
    {
        [DataMember(Order = 1)]
        public double X { get; set; }
        [DataMember(Order = 2)]
        public double Y { get; set; }
    }

    [DataContract]
    public class MultiplyResponse
    {
        [DataMember(Order = 1)]
        public double Result { get; set; }
    }
}

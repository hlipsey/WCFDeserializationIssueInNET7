using System.ServiceModel;

namespace Shared
{
    [ServiceContract]
    public interface IMultiplyService
    {
        [OperationContract]
        MultiplyResponse Multiply(MultiplyRequest request);
    }
}

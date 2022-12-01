using Shared;

namespace WCFClient7
{
    internal class Program
    {
        static void Main()
        {
            MultiplyResponse response = null;

            //Works
            WCFClient.UsingMultiplyService(s =>
            {
                response = s.Multiply(new MultiplyRequest() { X = 3, Y = 2 });
            });
            Console.WriteLine(response.Result);

            //Exception
            WCFClient.UsingMultiplyService(s =>
            {
                response = s.Multiply(new MultiplyRequest() { X = 3.14159, Y = 2.65358 });
            });
            Console.WriteLine(response.Result);
        }
    }
}
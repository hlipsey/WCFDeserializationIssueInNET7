using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient7
{
    public class WCFClient
    {
        public static void UsingMultiplyService(Action<IMultiplyService> codeBlock)
        {
            IClientChannel channel = null;
            try
            {
                CustomBinding netBinding = new CustomBinding();

                TcpTransportBindingElement el = new TcpTransportBindingElement();
                netBinding.Elements.Add(el);

                Uri serviceUri = new Uri($"net.tcp://{Dns.GetHostName()}/WCFServer/WCFServer472.MultiplyService.svc");

                var channelFactory = new ChannelFactory<IMultiplyService>(netBinding, new EndpointAddress(serviceUri));
                channel = channelFactory.CreateChannel() as IClientChannel;

                codeBlock((IMultiplyService)channel);
                channelFactory.Close();
            }
            finally
            {
                if (channel?.State != CommunicationState.Faulted)
                {
                    channel?.Close();
                }
                else
                {
                    channel?.Abort();
                }

                channel?.Dispose();
            }
        }
    }
}

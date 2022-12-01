using Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer472
{
    public class WCFHost
    {
        private ServiceHost _serviceHost = null;

        public void StartService()
        {
            Type hostType = typeof(MultiplyService);
            _serviceHost = new ServiceHost(hostType);

            CustomBinding binding = new CustomBinding();
            TcpTransportBindingElement el = new TcpTransportBindingElement();
            binding.Elements.Add(el);

            _serviceHost.AddServiceEndpoint(typeof(IMultiplyService), binding, new Uri($"net.tcp://{Dns.GetHostName()}/WCFServer/{hostType.Namespace}.{hostType.Name}.svc"));

            _serviceHost.Open();
        }

        public void StopService() 
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
            }

            _serviceHost = null;
        }
    }
}

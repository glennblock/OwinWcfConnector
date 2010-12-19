using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace Owin.Wcf
{
    public class OwinConnectorMessageInspector : IDispatchMessageInspector
    {
        private IOwinRequestFactory _requestFactory;

        public OwinConnectorMessageInspector(IOwinRequestFactory requestFactory)
        {
            _requestFactory = requestFactory;
        }

        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            request.CreateBufferedCopy(int.MaxValue);
            var owinRequest = _requestFactory.CreateRequest(request);
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            throw new NotImplementedException();
        }
    }
}

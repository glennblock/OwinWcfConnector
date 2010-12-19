using System.ServiceModel.Channels;
using Owin;
using Owin.Wcf;

namespace Given_a_host_is_configured_with_an_owin_connector
{
    public class FakeRequestFactory : IOwinRequestFactory
    {
        public bool RequestWasCreated;

        public IRequest CreateRequest(Message request)
        {
            RequestWasCreated = true;
            return null;
        }
    }
}
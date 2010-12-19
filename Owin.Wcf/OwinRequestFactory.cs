using System.ServiceModel.Channels;

namespace Owin.Wcf
{
    public class OwinRequestFactory : IOwinRequestFactory
    {
        public IRequest CreateRequest(Message request)
        {
            return null;
        }
    }
}
using System.ServiceModel.Channels;

namespace Owin.Wcf
{
    public interface IOwinRequestFactory
    {
        IRequest CreateRequest(Message request);
    }
}
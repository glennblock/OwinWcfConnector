using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owin.Wcf;
using Owin.Wcf.Test;

namespace Given_a_host_is_configured_with_an_owin_connector
{
    [TestClass]
    public class when_a_request_is_received : using_owin_context
    {
        public override void Context()
        {
            base.Context();
            Message message = Message.CreateMessage(MessageVersion.None, "Foo");
            connector.AfterReceiveRequest(ref message, clientChannel, instanceContext);
        }

        [TestMethod]
        public void then_an_owin_request_is_created()
        {
            Assert.IsTrue(this.requestFactory.RequestWasCreated);
        }

        [TestMethod]
        public void then_an_application_is_invoked()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_a_response_is_received()
        {
            Assert.Fail();
        }
    }

    [TestClass]
    public class when_the_request_is_created : using_owin_context
    {
        [TestMethod]
        public void then_the_uri_is_set()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_the_method_is_set()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_the_body_is_set()
        {
            
        }

        [TestMethod]
        public void then_the_accept_headers_are_set()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_the_content_type_header_is_set()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_the_headers_are_set()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void then_the_owin_required_properties_are_set()
        {
            Assert.Fail();
        }


    }

    [TestClass]
    public class when_the_response_is_created : using_owin_context
    {
        public void then_the_status_is_set()
        {
            Assert.Fail();
        }

        public void then_the_content_type_header_is_set()
        {
            Assert.Fail();
        }

        public void then_then_headers_are_set()
        {
            Assert.Fail();
        }
    }

    public class using_owin_context
    {
        public OwinConnectorMessageInspector connector;
        public FakeRequestFactory requestFactory;
        public FakeClientChannel clientChannel;
        public InstanceContext instanceContext;

        public using_owin_context()
        {
            Context();
        }

        public virtual void Context()
        {
            requestFactory = new FakeRequestFactory();
            clientChannel = new FakeClientChannel();
            instanceContext = new InstanceContext("Foo");
            connector = new OwinConnectorMessageInspector(requestFactory);
        }
    }
}


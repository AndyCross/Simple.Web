﻿namespace Simple.Web.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Text;
    using Behaviors;
    using ContentTypeHandling;
    using Mocks;
    using Xunit;

    public class GetHandlerTests
    {
        [Fact]
        public void GetRootWithHtmlReturnsHtml()
        {
        }
    }

    

    [UriTemplate("/")]
    [RespondsWith(ContentType.Html)]
    public class RootHandler : IGet, IOutput<RawHtml>
    {
        public Status Get()
        {
            return Status.OK;
        }

        public RawHtml Output { get { return "<h1>Hello</h1>"; } }
    }
}

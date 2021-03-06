namespace Simple.Web.CodeGeneration
{
    using System.Linq;
    using System.Text;
    using Behaviors;
    using ContentTypeHandling;
    using Http;

    static class WriteRawHtml
    {
        internal static void Impl(IOutput<RawHtml> handler, IContext context)
        {
            context.Response.ContentType =
                context.Request.AcceptTypes.FirstOrDefault(
                    at => at == ContentType.Html || at == ContentType.XHtml) ?? "text/html";
            if (context.Request.HttpMethod.Equals("HEAD")) return;
            var bytes = Encoding.UTF8.GetBytes(handler.Output.ToString());
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
    }
}
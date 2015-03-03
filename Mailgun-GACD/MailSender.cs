using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Mailgun_GACD
{
    class MailSender
    {
        public static RestResponse SendSimpleMessage(String ToReceptor, String EmailReceptor)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v2");
            client.Authenticator =new HttpBasicAuthenticator("api","key-15a1fdc5acc8f0188ad85cd0dc6e2efa");
            RestRequest request = new RestRequest();

            request.AddParameter("domain", "sandbox8e6ac167372b467991b84322a935c73e.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";

            request.AddParameter("from", "Mailgun Sandbox <sandbox8e6ac167372b467991b84322a935c73e.mailgun.org>");
            request.AddParameter("to", ToReceptor+" "+"<"+EmailReceptor+">");
            request.AddParameter("subject", "Confirmación Cuenta de StackOverflow");
            request.AddParameter("text", "Bienvenido@, tu cuenta ha sido activada.");
            request.Method = Method.POST;
            return (RestResponse)client.Execute(request);
        }
    }
}

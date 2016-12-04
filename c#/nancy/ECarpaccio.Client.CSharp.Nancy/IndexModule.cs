using System;
using Nancy;
using Nancy.ModelBinding;
using ECarpaccio.Client.CSharp.Nancy.Models;

namespace ECarpaccio.Client.CSharp.Nancy
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Post["/quote"] = _ =>
            {
                var order = this.Bind<Quote>();
                var bill = HandlerOrder(order);
                if (bill == null)
                {
                    return new {};
                }
                else
                    return bill;
            };

            Post["/feedback"] = _ =>
            {
                var feedback = this.Bind<Feedback>();
       
                HandleFeedback(feedback);

                return Negotiate.WithStatusCode(HttpStatusCode.OK);
            };
        }
        private void HandleFeedback(Feedback feedback)
        {
            Console.WriteLine(feedback.message);
        }
        private Bill HandlerOrder(Quote order)
        {
            return null;
        }        
    }
}
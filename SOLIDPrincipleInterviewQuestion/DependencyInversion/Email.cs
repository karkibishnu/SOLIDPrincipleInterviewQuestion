using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.DependencyInversion
{
    public class Email : IMessageSender
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void Send()
        {
            //send email
        }
    }
}

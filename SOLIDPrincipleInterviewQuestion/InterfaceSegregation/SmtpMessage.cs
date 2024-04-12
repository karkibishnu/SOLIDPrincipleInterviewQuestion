using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.InterfaceSegregation
{
    public class SmtpMessage : IEmailMessage
    {
        public string Subject { get; set; }
        public IList<string> BccAddresses { get; set; }

        public bool Send(IList<string> toAddress, string messageBody)
        {
            //code for sending email
            throw new NotImplementedException();
        }
    }
}

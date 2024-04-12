using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.InterfaceSegregation
{
    //Many client-specific interfaces are better than one general-purpose interface.
    //SmsMessage needs only toAddress and messageBody, so now we can utilise
    //IMessage interface to avoid unnecessary implementation.
    public class SmsMessage : IMessage
    {
        public bool Send(IList<string> toAddress, string messageBody)
        {
            //code for sending SMS
            throw new NotImplementedException();
        }
    }
}

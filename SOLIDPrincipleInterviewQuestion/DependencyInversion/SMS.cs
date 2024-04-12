using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.DependencyInversion
{
    public class SMS : IMessageSender
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void Send()
        {
            //send sms
        }
    }
}

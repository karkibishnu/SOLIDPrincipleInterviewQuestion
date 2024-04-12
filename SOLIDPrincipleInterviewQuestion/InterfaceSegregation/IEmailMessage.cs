using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.InterfaceSegregation
{
    public interface IEmailMessage : IMessage
    {
        public string Subject { get; set; }
        public IList<string> BccAddresses { get; set; }
    }
}

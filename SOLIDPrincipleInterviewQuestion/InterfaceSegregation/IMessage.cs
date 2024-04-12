using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.InterfaceSegregation
{
    public interface IMessage
    {
        bool Send(IList<string> toAddress, string messageBody);
    }
}

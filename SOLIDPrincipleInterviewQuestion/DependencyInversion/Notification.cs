using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.DependencyInversion
{
    // the Notification class depends on the IMessageSender interface
    // rather than concrete implementations like Email and SMS.
    // This allows us to inject different implementations of
    // IMessageSender (e.g., Email or SMS) into Notification
    // at runtime, promoting flexibility and easier testing.
    public class Notification
    {
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Send()
        {
            _messageSender.Send();
        }
    }
}

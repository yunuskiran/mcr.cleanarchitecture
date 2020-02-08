using Mcr.Core.Events;
using System;

namespace Mcr.Core.Commands
{
    public class Command
        : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}

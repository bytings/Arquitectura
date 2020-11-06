using ArquitecturaCore.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ArquitecturaCore.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}

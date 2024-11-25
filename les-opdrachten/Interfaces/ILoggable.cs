using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILoggable
    {

        DateTime createdAt { get; }
        int ID { get; }

        string GetLogMessage();

    }
}

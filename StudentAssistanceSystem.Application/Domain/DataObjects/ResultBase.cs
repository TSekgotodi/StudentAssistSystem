using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistanceSystem.Application.Domain.DataObjects
{
    public class ResultBase<T>
    {
        private readonly bool success;
        private readonly string message;
        private readonly T payload;

        public ResultBase(bool success, string message, T payload)
        {
            this.success=success;
            this.message = message;
            this.payload = payload;
        }

        public bool Success => success;
        public string Message => message;
        public T Payload => payload;



    }
}

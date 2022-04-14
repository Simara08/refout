using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {
            throw new NotFoundException("Medicine Not Found ");
        }
    }
}

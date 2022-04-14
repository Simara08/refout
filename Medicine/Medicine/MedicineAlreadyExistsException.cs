using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message) : base(message)
        {
            throw new MedicineAlreadyExistsException(" Medicine Already Exists");
        }
    }
}

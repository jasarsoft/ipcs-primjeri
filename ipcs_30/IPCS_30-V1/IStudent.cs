using System;
using System.Collections.Generic;
using System.Text;

namespace IPCS_30_V1
{
    interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; }
        int YearofBirth { set; }
    }
}

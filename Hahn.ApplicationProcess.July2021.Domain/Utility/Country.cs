using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace Hahn.ApplicationProcess.July2021.Domain.Utility
{
    [Serializable]
    public class Country : ICountry
    {
        public string Name { get; set; }
    }
}

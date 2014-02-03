using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method)]

class VersionAttribute : System.Attribute
{
    public string Version { get; private set; }

    public VersionAttribute(string version)
    {
        this.Version = version;
    }
    
}
using Rcl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKI.ROS.Interfaces.ROS
{
    public interface IRosNodeService : IBaseInterface
    {
        public void Init();

        RclContext CreateContext();

        IRclNode CreateNode(string nodeName);

    }
}


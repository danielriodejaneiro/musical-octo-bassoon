using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_Todo_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITodoProductService" in both code and config file together.
    [ServiceContract]
    public interface ITodoProductService
    {
        [OperationContract]
        void DoWork();
    }
}

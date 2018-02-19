using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTodo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTodo" in both code and config file together.
    [ServiceContract]
    public interface IServiceTodo
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", RequestFormat = WebMessageFormat.Json)]
        List<Todo> findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", RequestFormat = WebMessageFormat.Json)]
        Todo find(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool create(Todo todo);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool edit(Todo todo);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool delete(Todo todo);
    }
}

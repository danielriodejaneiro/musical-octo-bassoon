using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Http.Cors;

namespace WcfServiceTodo
{

    [ServiceContract]
    public interface IServiceTodo
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Todo> findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Todo find(string id);

        //ADDED SOME CORS TAGGING
        [OperationContract]
        [EnableCors("*", "*", "*")]
        [WebInvoke(Method = "POST", UriTemplate = "create", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool create(Todo todo);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool edit(Todo todo);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool delete(Todo todo);

        //[OperationContract]
        //[WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        //void GetOptions();
    }
}

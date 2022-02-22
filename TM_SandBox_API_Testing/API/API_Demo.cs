using System;
using RestSharp;
using TM_SandBox_API_Testing.DTO;
using TM_SandBox_API_Testing.Helper;

namespace TM_SandBox_API_Testing
{
    public class Demo<T>
    {
        public ListOfUsersDTO GetUser(string endpoint)
        {
            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUsersDTO content = user.GetContent<ListOfUsersDTO>((RestResponse)response);
            return content;
        }
    }
}

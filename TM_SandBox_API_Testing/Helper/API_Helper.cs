using System;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace TM_SandBox_API_Testing.Helper
{
    public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseURL = "https://api.tmsandbox.co.nz";

        //Setting up URL
        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            var restClient = new RestClient(url);
            return restClient;
        }

        //Create Post Request
        public RestRequest CreatePostRequest(string payload)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;
        }

        // Create Get Request
        public RestRequest CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        // Get Response from the server
        public IRestResponse GetResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }

        //Deserlize
        public DTO GetContent<DTO>(RestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }


    }
}

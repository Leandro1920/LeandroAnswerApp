using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnswerApp.Models
{
    public  class UserRole
    {
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentype = "Content-Type";

        public int UserRoleId { get; set; }
        public string UserRole1 { get; set; }

       
        public async Task<List<UserRole>> GetUserRoleList()
        {
            try
            {
                string routeSufix = string.Format("UserRoles/GetSelectableUserRoles");
              
                string FinalApiRoute = CnnToAPI.ProductionRoute + routeSufix;

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Get);

                //agregar la info de seguridad, en este caso api key 
                request.AddHeader(CnnToAPI.ApiKeyName, CnnToAPI.ApiKeyValue);
                request.AddHeader(contentype, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                if (statusCode == HttpStatusCode.OK)
                {
                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }

        }



    }
}

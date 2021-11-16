using FieldFinder.API;
using FieldFinder.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FieldFinder.Service
{
    public class FieldService : IFieldService
    {
        private readonly string URL = "http://f5dc-118-99-110-56.ngrok.io";
        public async Task<FieldDetailModel> GetDetailModelAsync(long id)
        {
            string url = $"{URL}/api/fielddetail/getdetailfield?id={id}";

            HttpClient client = new HttpClient();
            HttpResponseMessage res = await client.GetAsync(url);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string result = await res.Content.ReadAsStringAsync();
                FieldDetailModel jsonResult = JsonConvert.DeserializeObject<FieldDetailModel>(result);
                return jsonResult;
            }
            else
            {
                return null;
            }
        }

        public async Task<ObservableCollection<NearYouModel>> SetDataNearYou()
        {
            string url = $"{URL}/api/fielddetail/getlistnear";

            HttpClient client = new HttpClient();
            HttpResponseMessage res = await client.GetAsync(url);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string result = await res.Content.ReadAsStringAsync();
                ObservableCollection<NearYouModel> jsonRes = JsonConvert.DeserializeObject<ObservableCollection<NearYouModel>>(result);
                return jsonRes;
            }
            else
            {
                return null;
            }
        }
    }
}

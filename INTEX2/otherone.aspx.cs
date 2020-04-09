using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace INTEX2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lbPredict_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/874c75e5182443109db72b9ee2f05480/services/e02e9a6e0e014ec583cf5facc3121e8e/execute?api-version=2.0&details=true");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer LhXY9lyLEnjHYXGfpViGy7PGaq51DGn9ZqZCO/x38Om94F/FrsRP0N/QWMi1v5om4A/G8eIq3a14stW31APS/A==");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n\"Inputs\": {\r\n\"input1\": {\r\n\"ColumnNames\": [\r\n\"category\",\r\n\"visible_in_search\",\r\n\"status\",\r\n\"deactivated\",\r\n\"state\"\r\n],\r\n\"Values\": [\r\n[\r\n\"" + txtCategory.Text + "\",\r\n\"" + rblVisible.SelectedValue + "\",\r\n\"" + rblStatus.SelectedValue + "\",\r\n\"" + rblDeactive.SelectedValue + "\",\r\n\"" + rblState.SelectedValue + "\"\r\n]\r\n]\r\n}\r\n},\r\n\"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            var results = JObject.Parse(response.Content);
            string prediction = results["Results"]["output1"]["value"]["Values"].ToString().Replace("[", "").Replace("]", "").Replace("\"", "");

            lblResults.Text = prediction;

        }
    }
}
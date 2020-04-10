using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;
namespace IntexStuff
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void lbPredict_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/3387204766d94876956c2334f54933fe/services/904e64aac16344fbac5c8c699ed0fb77/execute?api-version=2.0&details=true");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer 44vD9Xe9/C1bxcObJKSd6vm3c4UL6CE0j8UbnZ31AKHHfCJnyNCxaJLWpxtLFbLtmhT/XrbEP1BEXte3erQV+Q==");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n\"Inputs\": {\r\n\"input1\": {\r\n\"ColumnNames\": [\r\n\"campaign_id\",\r\n\"auto_fb_post_mode\",\r\n\"category_id\",\r\n\"current_$amount\",\r\n\"goal\",\r\n\"title\",\r\n\"description\",\r\n\"has_beneficiary\",\r\n\"location_country\",\r\n\"is_charity\"\r\n],\r\n\"Values\": [\r\n[\r\n\"" + txtCampID.Text + "\",\r\n\"" + rblFBpost.SelectedValue + "\",\r\n\"" + txtCatID.Text + "\",\r\n\"0\",\r\n\"" + txtGoal.Text + "\",\r\n\"" + txtTitle.Text + "\",\r\n\"" + txtDes.Text + "\",\r\n\"" + rblbeneficiary.SelectedValue + "\",\r\n\"" + txtCountry.Text + "\",\r\n\"" + rblcharity.SelectedValue + "\"\r\n]\r\n]\r\n}\r\n},\r\n\"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            //lblResults.Text = response.Content.ToString();
            var results = JObject.Parse(response.Content);
            string prediction = results["Results"]["output1"]["value"]["Values"].ToString().Replace("[", "").Replace("]", "").Replace("\"", "");
            //prediction = prediction.Replace("[", "").Replace("]", "");
            lblResults.Text = prediction;
        }
    }
}
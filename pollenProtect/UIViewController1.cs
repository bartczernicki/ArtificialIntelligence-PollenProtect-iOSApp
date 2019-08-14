using Foundation;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using UIKit;

namespace testBartPhone
{
    public partial class UIViewController1 : UIViewController
    {
        string pollenString = "{\"Url\": \"https://bartmlpublic.blob.core.windows.net/publicdata/PredWithPollen.jpg\"}";
        string noPollenString = "{\"Url\": \"https://bartmlpublic.blob.core.windows.net/publicdata/PredNoPollen.jpg\"}";

        string treeToUse = "{\"Url\": \"https://bartmlpublic.blob.core.windows.net/publicdata/PredNoPollen.jpg\"}";

        partial void UIButton623_TouchUpInside(UIButton sender)
        {

        }

        public UIViewController1 (IntPtr handle) : base (handle)
        {

        }

        partial void UIButton5537_TouchUpInside(UIButton sender)
        {
            HttpClient client = new HttpClient();

            string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v2.0/Prediction/90b70038-a5b5-4c72-b376-8bbb13fe869e/url?iterationId=5cc9cd17-9b95-46dc-bf55-a276149a5afe";
            var uri = new Uri(url);

            // Request
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            // TODO: Add API Key
            request.Headers.Add("Prediction-Key", "");

            request.Content = new StringContent(
                treeToUse,
                Encoding.UTF8,
                "application/json"
            );

            // request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.SendAsync(request).Result;

            var content = result.Content;
            var stringContent = content.ReadAsStringAsync().Result;
            var prediction = JsonConvert.DeserializeObject<RootObject>(stringContent);

            if (prediction.predictions[0].tagName == "no pollen" && 
                prediction.predictions[0].probability > 0.5)
            {
                this.imageHappy.Alpha = 1.0f;
                this.imageSad.Alpha = 0.2f;
            }
            else
            {
                this.imageHappy.Alpha = 0.2f;
                this.imageSad.Alpha = 1.0f;
            }

            var prefix = "We are ";
            if (this.imageHappy.Alpha == 1.0f)
            {
                if (prediction.predictions[0].tagName == "no pollen")
                {
                    this.predPercentage.Text = prefix + Math.Round(prediction.predictions[0].probability*100, 2).ToString() + "% sure this is a NON-POLLINATED area.";
                }
                if (prediction.predictions[1].tagName == "no pollen")
                {
                    this.predPercentage.Text = prefix + Math.Round(prediction.predictions[1].probability*100, 2).ToString() + "% sure this is a NON-POLLINATED area.";
                }
            }

            if (this.imageHappy.Alpha == 0.2f)
            {
                if (prediction.predictions[0].tagName == "pollen")
                {
                    this.predPercentage.Text = prefix + Math.Round(prediction.predictions[0].probability*100, 2).ToString() + "% sure this is a POLLINATED area.";
                }
                if (prediction.predictions[1].tagName == "pollen")
                {
                    this.predPercentage.Text = prefix + Math.Round(prediction.predictions[1].probability*100, 2).ToString() + "% sure this is a POLLINATED area.";
                }
            }
        }

        partial void pollenTreeChanged(UISwitch sender)
        {
            if (this.pollenSwitch.On == true)
            {
                treeToUse = noPollenString;
                cameraPreview.Image = UIImage.FromBundle("PredNoPollen.jpg");
            }
            else
            {
                treeToUse = pollenString;
                cameraPreview.Image = UIImage.FromBundle("PredWithPollen.jpg");
            }
        }
    }
}
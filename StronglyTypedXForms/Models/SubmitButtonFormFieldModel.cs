using System.Xml.Linq;
using EPiServer;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Submit button form field
    /// </summary>
    public class SubmitButtonFormFieldModel : FormFieldModel 
    {
        public string ButtonText { get; set; }
        public SubmitFormActions Action { get; set; }
        public string RecipientEmailAddress { get; set; }
        public string SenderEmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string Url { get; set; }

        /// <summary>
        /// Serialize to XElement
        /// </summary>
        /// <returns></returns>
        public override XElement Serialize(XNamespace namespaceXForms)
        {
            var builder = new UrlBuilder(GetFormAction());
            if (this.RecipientEmailAddress != null)
            {
                builder.QueryCollection.Add("to", this.RecipientEmailAddress);
            }
            if (this.SenderEmailAddress != null)
            {
                builder.QueryCollection.Add("from", this.SenderEmailAddress);
            }
            if (this.EmailSubject != null)
            {
                builder.QueryCollection.Add("subject", this.EmailSubject);
            }
            
            var formElement = new XElement(namespaceXForms + "submit",
                    new XAttribute("action", builder.ToString()),
                    new XAttribute("method", string.Empty),
                    new XAttribute("name", "ctl00$FullRegion$FormControl$ctl11"));

            var formLabelElement = new XElement(namespaceXForms + "label", this.ButtonText);
            formElement.Add(formLabelElement);

            return formElement;
        }

        /// <summary>
        /// Get form action
        /// </summary>
        /// <returns></returns>
        private string GetFormAction()
        {
            switch (this.Action)
            {
                case SubmitFormActions.SaveToDatabase:
                    return "http://localhost/sql";
                case SubmitFormActions.SaveToDatabaseAndSendMail:
                    return "http://localhost/sql_mailto:";
                case SubmitFormActions.SendEmail:
                    return "mailto:";
                case SubmitFormActions.SendToUrl:
                    return this.Url;
            }
            return string.Empty;
        }
    }
}
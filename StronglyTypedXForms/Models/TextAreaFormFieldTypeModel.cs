using System.Xml.Linq;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Textarea form field type model
    /// </summary>
    public class TextareaFormFieldTypeModel : TextBoxFormFieldTypeModel
    {
        public int NumberOfRows { get; set; }

        /// <summary>
        /// Serialize to XElement
        /// </summary>
        /// <returns></returns>
        public override XElement Serialize(XNamespace namespaceXForms)
        {
            var formElement = new XElement(namespaceXForms + "textarea",
                    new XAttribute("id", this.Name),
                    new XAttribute("ref", this.Name),
                    new XAttribute("rows", this.NumberOfRows.ToString()),
                    new XAttribute("cols", this.NumberOfCharacters.ToString()),
                    new XAttribute("required", this.Required));

            var formLabelElement = new XElement(namespaceXForms + "label", this.Heading);
            formElement.Add(formLabelElement);

            return formElement;
        }
    }
}
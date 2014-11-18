using System.Xml.Linq;
using EPiServer.ServiceLocation;
using StronglyTypedXForms.Serialize;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Textbox formfield type model
    /// </summary>
    public class TextBoxFormFieldTypeModel : FormFieldTypeModel
    {
        public int NumberOfCharacters { get; set; }
        public TextFormFieldValidateType ValidateAs { get; set; }

        /// <summary>
        /// Serialize to XElement
        /// </summary>
        /// <returns></returns>
        public override XElement Serialize(XNamespace namespaceXForms)
        {
            var formFieldSerializeUtils = ServiceLocator.Current.GetInstance<IFormFieldSerializeUtils>();

            var formElement = new XElement(namespaceXForms + "input",
                    new XAttribute("id", this.Name),
                    new XAttribute("ref", this.Name),
                    new XAttribute("required", this.Required));

            var validateAs = formFieldSerializeUtils.GetFieldValidateAsValue(this.ValidateAs);
            if (!string.IsNullOrEmpty(validateAs))
            {
                formElement.Add(new XAttribute("xsitype", validateAs));
            }

            var formLabelElement = new XElement(namespaceXForms + "label", this.Heading);
            formElement.Add(formLabelElement);

            return formElement;
        }
    }
}
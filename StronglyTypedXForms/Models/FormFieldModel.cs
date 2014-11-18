using System.Xml.Linq;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Formfield model
    /// </summary>
    public abstract class FormFieldModel
    {
        /// <summary>
        /// Serialize to XElement
        /// </summary>
        /// <returns></returns>
        public abstract XElement Serialize(XNamespace namespaceXForms);
    }
}
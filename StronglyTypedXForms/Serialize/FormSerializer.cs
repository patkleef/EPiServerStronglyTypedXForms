using System.Xml.Linq;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Serialize
{
    /// <summary>
    /// Form XML serializer 
    /// </summary>
    public class FormSerializer : IFormSerializer
    {
        private readonly IFormFieldSerializeUtils _formFieldSerializeUtils;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="formFieldSerializeUtils"></param>
        public FormSerializer(IFormFieldSerializeUtils formFieldSerializeUtils)
        {
            _formFieldSerializeUtils = formFieldSerializeUtils;
        }

        /// <summary>
        /// Serialize FormTypeModel
        /// </summary>
        /// <param name="formTypeModel"></param>
        /// <returns></returns>
        public XDocument Serialize(FormTypeModel formTypeModel)
        {
            var xDoc = new XDocument();

            var namespaceXForms = XNamespace.Get("http://www.w3.org/2002/xforms");
            var namespaceXml = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");

            var rootElement = new XElement("root", new XAttribute(XNamespace.Xmlns + "xforms", namespaceXForms), new XAttribute(XNamespace.Xmlns + "xsi", namespaceXml));
            var modelElement = new XElement("model");
            var instanceElement = new XElement("instance");

            rootElement.Add(modelElement);
            modelElement.Add(instanceElement);

            var tableElement = new XElement("table", new XAttribute("id", "id_matrix"));
            var tbodyElement = new XElement("tbody");

            rootElement.Add(tableElement);
            tableElement.Add(tbodyElement);
            
            foreach (FormRowModel row in formTypeModel.Fields)
            {
                var trElement = new XElement("tr");
                foreach (FormColumnModel column in row.Columns)
                {
                    var tdElement = new XElement("td", new XAttribute("valign", "top"));
                    foreach (FormFieldModel item in column.FormFields)
                    {
                        if (item is FormFieldTypeModel)
                        {
                            var xElement = new XElement(((FormFieldTypeModel) item).Name);
                            if (item is TextBoxFormFieldTypeModel)
                            {
                                var validateAs = _formFieldSerializeUtils.GetFieldValidateAsValue(((TextBoxFormFieldTypeModel)item).ValidateAs);
                                if (!string.IsNullOrEmpty(validateAs))
                                {
                                    xElement.Add(new XAttribute(namespaceXml + "type", validateAs));
                                }
                            }
                            instanceElement.Add(xElement);
                        }
                        tdElement.Add(item.Serialize(namespaceXForms));
                    }
                    trElement.Add(tdElement);
                }
                tbodyElement.Add(trElement);
            }
            xDoc.Add(rootElement);

            return xDoc;
        }
    }
}
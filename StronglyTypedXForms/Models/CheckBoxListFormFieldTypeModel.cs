﻿using System.Xml.Linq;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Radio button form field type model
    /// </summary>
    public class CheckboxListFormFieldTypeModel : DropdownFormFieldTypeModel
    {
        public bool HorizontalAlign { get; set; }

        /// <summary>
        /// Serialize to XElement
        /// </summary>
        /// <returns></returns>
        public override XElement Serialize(XNamespace namespaceXForms)
        {
            var formElement = new XElement(namespaceXForms + "select",
                    new XAttribute("id", this.Name),
                    new XAttribute("ref", this.Name),
                    new XAttribute("appearance", "full"),
                    new XAttribute("horizontalalign", this.HorizontalAlign.ToString().ToLower()),
                    new XAttribute("required", this.Required));

            var formLabelElement = new XElement(namespaceXForms + "label", this.Heading);

            foreach (var option in this.Options)
            {
                var formOptionsElement = new XElement(namespaceXForms + "item",
                    new XElement(namespaceXForms + "label", option),
                    new XElement(namespaceXForms + "value", option));

                formElement.Add(formOptionsElement);
            }
            formElement.Add(formLabelElement);

            return formElement;
        }
    }
}
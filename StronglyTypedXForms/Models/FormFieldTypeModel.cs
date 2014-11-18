using System;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Form fieldtype model
    /// </summary>
    public abstract class FormFieldTypeModel : FormFieldModel
    {
        public string Name { get; set; }
        public string Heading { get; set; }
        public Type FieldType { get; set; }
        public string ToolTip { get; set; }
        public string CssClass { get; set; }
        public bool Required { get; set; }
    }
}
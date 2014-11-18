namespace StronglyTypedXForms.Attributes
{
    public abstract class FormFieldTypeAttribute : FormFieldAttribute
    {
        public string Name { get; set; }
        public string Heading { get; set; }
        public string ToolTip { get; set; }
        public string CssClass { get; set; }
        public bool Required { get; set; }
    }
}
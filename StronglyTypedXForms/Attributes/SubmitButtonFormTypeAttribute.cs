using System;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Attributes
{
    /// <summary>
    /// Submit button form type attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SubmitButtonFormTypeAttribute : FormFieldAttribute
    {
        public string ButtonText { get; set; }
        public SubmitFormActions Action { get; set; }
        public string RecipientEmailAddress { get; set; }
        public string SenderEmailAddress { get; set; }
        public string EmailSubject { get; set; }
        public string Url { get; set; }

        /// <summary>
        /// From attribute
        /// </summary>
        /// <returns></returns>
        public override FormFieldModel FromAttribute()
        {
            return FormFieldModelBuilder.Create(this);
        }
    }
}
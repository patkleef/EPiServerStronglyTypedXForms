using System;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class TextFormFieldTypeAttribute : FormFieldTypeAttribute
    {
        public int NumberOfCharacters { get; set; }
        public TextFormFieldValidateType ValidateAs { get; set; }

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
using System;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Attributes
{
    /// <summary>
    /// Text area field type attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class TextareaFormFieldTypeAttribute : TextFormFieldTypeAttribute
    {
        public int NumberOfRows { get; set; }

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
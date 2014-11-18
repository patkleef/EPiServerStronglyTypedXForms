using System;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Attributes
{
    /// <summary>
    /// Dropdown form filed type attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class DropdownFormFieldTypeAttribute : FormFieldTypeAttribute
    {
        public string[] Options { get; set; }

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
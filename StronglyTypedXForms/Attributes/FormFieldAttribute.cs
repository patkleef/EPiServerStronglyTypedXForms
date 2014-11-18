using System;
using EPiServer.ServiceLocation;
using StronglyTypedXForms.Models;
using StronglyTypedXForms.Models.Builders;

namespace StronglyTypedXForms.Attributes
{
    /// <summary>
    /// Formfield attribute
    /// </summary>
    public abstract class FormFieldAttribute : Attribute
    {
        /// <summary>
        /// Protected constructor
        /// </summary>
        protected FormFieldAttribute()
        {
            FormFieldModelBuilder = ServiceLocator.Current.GetInstance<IFormFieldModelBuilder>();
        }

        protected IFormFieldModelBuilder FormFieldModelBuilder;
        public int SortOrder { get; set; }
        public abstract FormFieldModel FromAttribute();
    }
}
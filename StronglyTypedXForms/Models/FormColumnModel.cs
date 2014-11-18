using System.Collections.Generic;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Form column model
    /// </summary>
    public class FormColumnModel
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public FormColumnModel()
        {
            FormFields = new List<FormFieldModel>();
        }

        public IList<FormFieldModel> FormFields { get; set; }
    }
}
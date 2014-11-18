using System.Collections.Generic;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Form row model
    /// </summary>
    public class FormRowModel
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public FormRowModel()
        {
            Columns = new List<FormColumnModel>();
        }

        public IList<FormColumnModel> Columns { get; private set; }
    }
}
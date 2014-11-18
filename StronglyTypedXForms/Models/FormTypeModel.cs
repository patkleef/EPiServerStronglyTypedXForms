using System;
using System.Collections.Generic;

namespace StronglyTypedXForms.Models
{
    /// <summary>
    /// Form type model
    /// </summary>
    public class FormTypeModel
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public FormTypeModel()
        {
            Fields = new List<FormRowModel>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public bool FormCanBeSentWithoutLoggingIn { get; set; }
        public bool SamePersonCanSendTheFormSeveralTimes { get; set; }

        public Type FormType { get; set; }

        public IList<FormRowModel> Fields { get; private set; }
    }
}
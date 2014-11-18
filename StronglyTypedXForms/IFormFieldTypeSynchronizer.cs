using System.Collections.Generic;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms
{
    public interface IFormFieldTypeSynchronizer
    {
        /// <summary>
        /// Analyze for form field properties
        /// </summary>
        /// <param name="formFieldType"></param>
        /// <returns></returns>
        IList<FormRowModel> Analyze(FormTypeModel formFieldType);
    }
}
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Serialize
{
    public interface IFormFieldSerializeUtils
    {
        /// <summary>
        /// Get field validate as value
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetFieldValidateAsValue(TextFormFieldValidateType type);
    }
}
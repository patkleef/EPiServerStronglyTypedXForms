using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Serialize
{
    /// <summary>
    /// Form serialize utils
    /// </summary>
    public class FormFieldSerializeUtils : IFormFieldSerializeUtils
    {
        /// <summary>
        /// Get field validate as value
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetFieldValidateAsValue(TextFormFieldValidateType type)
        {
            switch (type)
            {
                case TextFormFieldValidateType.EmailAddress:
                    return "email";
                case TextFormFieldValidateType.Integer:
                    return "integer";
                case TextFormFieldValidateType.PositiveInteger:
                    return "positiveinteger";
                case TextFormFieldValidateType.Date_DD_MM_YYYY:
                    return "date1";
                case TextFormFieldValidateType.Date_MM_DD_YYYY:
                    return "date2";
                case TextFormFieldValidateType.Date_YYYY_MM_DD:
                    return "date3";
            }
            return string.Empty;
        }
    }
}

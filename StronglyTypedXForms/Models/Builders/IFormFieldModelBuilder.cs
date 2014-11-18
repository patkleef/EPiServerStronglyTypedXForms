using StronglyTypedXForms.Attributes;

namespace StronglyTypedXForms.Models.Builders
{
    public interface IFormFieldModelBuilder
    {
        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        TextBoxFormFieldTypeModel Create(TextFormFieldTypeAttribute attribute);

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        TextBoxFormFieldTypeModel Create(TextareaFormFieldTypeAttribute attribute);

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        DropdownFormFieldTypeModel Create(DropdownFormFieldTypeAttribute attribute);

        /// <summary>
        /// Create radio button form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        RadioButtonFormFieldTypeModel Create(RadioButtonFormFieldTypeAttribute attribute);

        /// <summary>
        /// Create checkbox list form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        CheckboxListFormFieldTypeModel Create(CheckboxListFormFieldTypeAttribute attribute);

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        SubmitButtonFormFieldModel Create(SubmitButtonFormTypeAttribute attribute);
    }
}
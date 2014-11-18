using StronglyTypedXForms.Attributes;

namespace StronglyTypedXForms.Models.Builders
{
    /// <summary>
    /// Formfield model builder
    /// </summary>
    public class FormFieldModelBuilder : IFormFieldModelBuilder
    {
        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public TextBoxFormFieldTypeModel Create(TextFormFieldTypeAttribute attribute)
        {
            var fieldModel = new TextBoxFormFieldTypeModel();
            fieldModel.CssClass = attribute.CssClass;
            fieldModel.NumberOfCharacters = attribute.NumberOfCharacters;
            fieldModel.ValidateAs = attribute.ValidateAs;
            fieldModel.Name = attribute.Name;
            fieldModel.Heading = attribute.Heading;
            fieldModel.Required = attribute.Required;

            return fieldModel;
        }

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public TextBoxFormFieldTypeModel Create(TextareaFormFieldTypeAttribute attribute)
        {
            var fieldModel = new TextareaFormFieldTypeModel();
            fieldModel.CssClass = attribute.CssClass;
            fieldModel.NumberOfCharacters = attribute.NumberOfCharacters;
            fieldModel.NumberOfRows = attribute.NumberOfRows;
            fieldModel.ValidateAs = attribute.ValidateAs;
            fieldModel.Name = attribute.Name;
            fieldModel.Heading = attribute.Heading;
            fieldModel.Required = attribute.Required;

            return fieldModel;
        }

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public DropdownFormFieldTypeModel Create(DropdownFormFieldTypeAttribute attribute)
        {
            var fieldModel = new DropdownFormFieldTypeModel();
            fieldModel.CssClass = attribute.CssClass;
            fieldModel.Name = attribute.Name;
            fieldModel.Heading = attribute.Heading;
            fieldModel.Required = attribute.Required;
            fieldModel.Options = attribute.Options;

            return fieldModel;
        }

        /// <summary>
        /// Create radio button form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public RadioButtonFormFieldTypeModel Create(RadioButtonFormFieldTypeAttribute attribute)
        {
            var fieldModel = new RadioButtonFormFieldTypeModel();
            fieldModel.CssClass = attribute.CssClass;
            fieldModel.Name = attribute.Name;
            fieldModel.Heading = attribute.Heading;
            fieldModel.Required = attribute.Required;
            fieldModel.Options = attribute.Options;
            fieldModel.HorizontalAlign = attribute.HorizontalAlign;

            return fieldModel;
        }

        /// <summary>
        /// Create checkbox list form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public CheckboxListFormFieldTypeModel Create(CheckboxListFormFieldTypeAttribute attribute)
        {
            var fieldModel = new CheckboxListFormFieldTypeModel();
            fieldModel.CssClass = attribute.CssClass;
            fieldModel.Name = attribute.Name;
            fieldModel.Heading = attribute.Heading;
            fieldModel.Required = attribute.Required;
            fieldModel.Options = attribute.Options;
            fieldModel.HorizontalAlign = attribute.HorizontalAlign;

            return fieldModel;
        }

        /// <summary>
        /// Create textbox form field type model
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public SubmitButtonFormFieldModel Create(SubmitButtonFormTypeAttribute attribute)
        {
            var fieldModel = new SubmitButtonFormFieldModel();
            fieldModel.Action = attribute.Action;
            fieldModel.ButtonText = attribute.ButtonText;
            fieldModel.EmailSubject = attribute.EmailSubject;
            fieldModel.RecipientEmailAddress = attribute.RecipientEmailAddress;
            fieldModel.SenderEmailAddress = attribute.SenderEmailAddress;
            fieldModel.Url = attribute.Url;

            return fieldModel;
        } 
    }
}
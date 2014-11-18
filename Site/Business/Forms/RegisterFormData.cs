using StronglyTypedXForms;
using StronglyTypedXForms.Attributes;
using StronglyTypedXForms.Models;

namespace Site.Business.Forms
{
    [FormType(
        GUID = "09858B5E-14B7-445C-AF4D-BE02B90916DA",
        Name = "Register form data",
        CreatedBy = "Patrick van Kleef",
        FormCanBeSentWithoutLoggingIn = true,
        SamePersonCanSendTheFormSeveralTimes = false)]
    public class RegisterFormData : FormData
    {
        [TextFormFieldType(
            Name = "Firstname",
            Heading = "Firstname",
            NumberOfCharacters = 20,
            CssClass = "text-field",
            ToolTip = "Firstname",
            SortOrder = 1)]
        public string FirstName { get; set; }

        [TextFormFieldType(
            Name = "Lastname",
            Heading = "Lastname",
            NumberOfCharacters = 20,
            CssClass = "text-field",
            ToolTip = "Lastname",
            SortOrder = 2)]
        public string LastName { get; set; }

        [RadioButtonFormFieldType(
            Name = "Gender",
            Heading = "Gender",
            Required = true,
            Options = new[] { "Male", "Female" },
            HorizontalAlign = true,
            SortOrder = 3)]
        public string Gender { get; set; }

        [TextFormFieldType(
            Name = "Emailaddress",
            Heading = "Emailaddress",
            NumberOfCharacters = 20,
            CssClass = "text-field",
            ToolTip = "Emailaddress",
            SortOrder = 3)]
        public string EmailAddress { get; set; }

        [SubmitButtonFormType(
           ButtonText = "Submit",
           Action = SubmitFormActions.SaveToDatabase,
           SortOrder = 4)]
        public SubmitFormActions SubmitButton { get; set; }
    }
}
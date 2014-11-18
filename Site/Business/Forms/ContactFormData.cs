using StronglyTypedXForms;
using StronglyTypedXForms.Attributes;
using StronglyTypedXForms.Models;

namespace Site.Business.Forms
{
    /// <summary>
    /// Contact form data
    /// </summary>
    [FormType(
        GUID = "B6CE7290-D1A5-46FF-94C5-380B44331032",
        Name = "Contact form test",
        CreatedBy = "Patrick van Kleef", 
        FormCanBeSentWithoutLoggingIn = true, 
        SamePersonCanSendTheFormSeveralTimes = true)]
    public class ContactFormData : FormData
    {
        [TextFormFieldType(
            Name = "Name",
            Heading = "Name",
            NumberOfCharacters = 20,
            CssClass = "textfield",
            ToolTip = "Name",
            SortOrder = 1,
            Required = true)]
        public string NameTextField { get; set; }

        [RadioButtonFormFieldType(
            Name = "Gender",
            Heading = "Gender",
            Required = true,
            Options = new[] { "Male", "Female" },
            HorizontalAlign = true,
            SortOrder = 2)]
        public string GenderRadioButtonListField { get; set; }

        [TextFormFieldType(
            Name = "Age",
            Heading = "Age",
            NumberOfCharacters = 20,
            CssClass = "textfield",
            ToolTip = "Age",
            SortOrder = 3,
            ValidateAs = TextFormFieldValidateType.PositiveInteger)]
        public string AgeTextField { get; set; }

        [TextFormFieldType(
            Name = "DateOfBirth",
            Heading = "Date of birth",
            NumberOfCharacters = 20,
            CssClass = "datefield",
            ToolTip = "Date of birth",
            SortOrder = 4,
            ValidateAs = TextFormFieldValidateType.Date_MM_DD_YYYY)]
        public string DateOfBirthTextField { get; set; }

        [TextFormFieldType(
            Name = "EmailAddress",
            Heading = "Emailadress",
            NumberOfCharacters = 20,
            CssClass = "textfield",
            ToolTip = "Emailaddress",
            SortOrder = 5,
            ValidateAs = TextFormFieldValidateType.EmailAddress)]
        public string EmailAddressTextField { get; set; }

        [TextFormFieldType(
            Name = "Company",
            Heading = "Company", 
            NumberOfCharacters = 20, 
            CssClass = "textfield", 
            ToolTip = "Company",
            SortOrder = 6)]
        public string CompanyTextField { get; set; }

        [DropdownFormFieldType(
            Name = "Country",
            Heading = "Country",
            Required = true,
            Options = new[] { "Netherlands", "Belgium", "Sweden", "Germany" },
            SortOrder = 7)]
        public string CountryDropdownField { get; set; }

        [CheckboxListFormFieldType(
            Name = "FavoriteColor",
            Heading = "Favorite color",
            Required = true,
            Options = new[] { "Blue", "Green", "Yellow" },
            HorizontalAlign = true,
            SortOrder = 8)]
        public string FavoritesCheckboxListField { get; set; }

        [TextareaFormFieldType(
            Name = "Message",
            Heading = "Message",
            NumberOfCharacters = 20,
            NumberOfRows = 6,
            ToolTip = "Message",
            SortOrder = 9)]
        public string MessageTextareaField { get; set; }

        [SubmitButtonFormType(
            ButtonText = "Send",
            Action = SubmitFormActions.SaveToDatabaseAndSendMail,
            RecipientEmailAddress = "patrick.van.kleef@macaw.nl",
            SenderEmailAddress = "patrick.van.kleef@macaw.nl",
            EmailSubject = "Contact form",
            SortOrder = 10)]
        public SubmitFormActions ActionButton { get; set; }
    }
}
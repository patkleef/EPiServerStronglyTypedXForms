using EPiServer.XForms;

namespace StronglyTypedXForms.Models.Builders
{
    public interface IXFormBuilder
    {
        /// <summary>
        /// Create XForm from FormTypeModel
        /// </summary>
        /// <param name="formTypeModel"></param>
        /// <returns></returns>
        XForm Create(FormTypeModel formTypeModel);
    }
}
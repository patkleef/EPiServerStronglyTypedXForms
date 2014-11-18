using System.Xml.Linq;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms.Serialize
{
    /// <summary>
    /// Form serializer interface
    /// </summary>
    public interface IFormSerializer
    {
        /// <summary>
        /// Serialize FormTypeModel
        /// </summary>
        /// <param name="formTypeModel"></param>
        /// <returns></returns>
        XDocument Serialize(FormTypeModel formTypeModel);
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EPiServer.DataAnnotations;
using StronglyTypedXForms.Attributes;
using StronglyTypedXForms.Models;

namespace StronglyTypedXForms
{
    /// <summary>
    /// Form field type synchronizer
    /// </summary>
    public class FormFieldTypeSynchronizer : IFormFieldTypeSynchronizer
    {
        /// <summary>
        /// Analyze for form field properties
        /// </summary>
        /// <param name="formFieldType"></param>
        /// <returns></returns>
        public IList<FormRowModel> Analyze(FormTypeModel formFieldType)
        {
            var rows = new List<FormRowModel>();
            var properties = GetProperties(formFieldType);

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                var formFieldAttribute = attributes.OfType<FormFieldAttribute>().FirstOrDefault();

                if (formFieldAttribute != null)
                {
                    var row = new FormRowModel();
                    var column = new FormColumnModel();

                    column.FormFields.Add(formFieldAttribute.FromAttribute());
                    row.Columns.Add(column);

                    rows.Add(row);
                }
            }
            return rows;
        }

        /// <summary>
        /// Get properties
        /// </summary>
        /// <param name="formFieldType"></param>
        /// <returns></returns>
        private IEnumerable<PropertyInfo> GetProperties(FormTypeModel formFieldType)
        {
            var propertyInfoArray = formFieldType.FormType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.SetProperty);
            foreach (var propertyInfo in this.FilterPropertiesWithPublicGetAndSetAccessor(propertyInfoArray))
            {
                if (propertyInfo.IsDefined(typeof(IgnoreAttribute), true))
                {
                    continue;
                }
                yield return propertyInfo;
            }
        }

        /// <summary>
        /// Filter properties with public get and set accessor
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        private IEnumerable<PropertyInfo> FilterPropertiesWithPublicGetAndSetAccessor(IEnumerable<PropertyInfo> properties)
        {
            return properties.Where(property =>
            {
                if (property.GetGetMethod() == null)
                {
                    return false;
                }
                return property.GetSetMethod() != null;
            });
        }
    }
}
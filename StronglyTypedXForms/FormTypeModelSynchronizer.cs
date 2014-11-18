using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer.Framework.TypeScanner;
using StronglyTypedXForms.Attributes;
using StronglyTypedXForms.Models;
using StronglyTypedXForms.Models.Builders;

namespace StronglyTypedXForms
{
    /// <summary>
    /// Form type model synchronizer
    /// </summary>
    public class FormTypeModelSynchronizer : IFormTypeModelSynchronizer
    {
        private readonly IList<FormTypeModel> _formTypeModels;
        private readonly IXFormBuilder _xFormBuilder;
        private readonly IFormFieldTypeSynchronizer _formFieldTypeSynchronizer;
        private readonly ITypeScannerLookup _typeScannerLookup;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormTypeModelSynchronizer(IXFormBuilder xFormBuilder, IFormFieldTypeSynchronizer formFieldTypeSynchronizer, ITypeScannerLookup typeScannerLookup)
        {
            _formTypeModels = new List<FormTypeModel>();
            _xFormBuilder = xFormBuilder;
            _formFieldTypeSynchronizer = formFieldTypeSynchronizer;
            _typeScannerLookup = typeScannerLookup;
        }

        /// <summary>
        /// Create model
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private FormTypeModel CreateModel(Type type)
        {
            var formTypeModel = Activator.CreateInstance<FormTypeModel>();
            formTypeModel.FormType = type;

            object[] attributes = formTypeModel.FormType.GetCustomAttributes(typeof(FormTypeAttribute), false);

            var formTypeAttribute = attributes[0] as FormTypeAttribute;
            if (formTypeAttribute != null)
            {
                formTypeModel.Guid = Guid.Parse(formTypeAttribute.GUID);
                formTypeModel.Name = formTypeAttribute.Name;
                formTypeModel.FormCanBeSentWithoutLoggingIn = formTypeAttribute.FormCanBeSentWithoutLoggingIn;
                formTypeModel.SamePersonCanSendTheFormSeveralTimes = formTypeAttribute.SamePersonCanSendTheFormSeveralTimes;

                var fields = _formFieldTypeSynchronizer.Analyze(formTypeModel);
                foreach (var field in fields)
                {
                    formTypeModel.Fields.Add(field); 
                }
            }
            return formTypeModel;
        }
        
        /// <summary>
        /// Commit the forms
        /// </summary>
        public void Commit()
        {
            foreach (var item in _formTypeModels)
            {
                _xFormBuilder.Create(item).Save();
            }
        }
        
        /// <summary>
        /// Search for FormData implementations
        /// </summary>
        public void Analyze()
        {
            var formDataTypes = _typeScannerLookup.AllTypes.Where(
                t => typeof(FormData).IsAssignableFrom(t) &&
                t != typeof(FormData) &&
                !t.IsAbstract);

            foreach (var item in formDataTypes)
            {
                _formTypeModels.Add(CreateModel(item));
            }
        }
    }
}
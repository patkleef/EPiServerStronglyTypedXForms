using System;
using EPiServer.XForms;
using EPiServer.XForms.Util;
using StronglyTypedXForms.Serialize;

namespace StronglyTypedXForms.Models.Builders
{
    /// <summary>
    /// XForm builder
    /// </summary>
    public class XFormBuilder : IXFormBuilder
    {
        private readonly IFormSerializer _formSerializer;

        /// <summary>
        /// Public constructor
        /// </summary>
        public XFormBuilder(IFormSerializer formSerializer)
        {
            _formSerializer = formSerializer;
        }

        /// <summary>
        /// Create XForm from FormTypeModel
        /// </summary>
        /// <param name="formTypeModel"></param>
        /// <returns></returns>
        public XForm Create(FormTypeModel formTypeModel)
        {
            var form = new XForm();
            form.Id = formTypeModel.Guid;
            form.FormName = formTypeModel.Name;
            form.CreatedBy = formTypeModel.CreatedBy;
            form.Created = DateTime.Now;
            form.ChangedBy = formTypeModel.CreatedBy;
            form.Changed = DateTime.Now;
            form.AllowAnonymousPost = formTypeModel.FormCanBeSentWithoutLoggingIn;
            form.AllowMultiplePost = formTypeModel.SamePersonCanSendTheFormSeveralTimes;

            form.Document = new SerializableXmlDocument();
            form.Document.LoadXml(_formSerializer.Serialize(formTypeModel).ToString());

            return form;
        }
    }
}
using System;

namespace StronglyTypedXForms.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class FormTypeAttribute : Attribute
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public bool FormCanBeSentWithoutLoggingIn { get; set; }
        public bool SamePersonCanSendTheFormSeveralTimes { get; set; }
    }
}
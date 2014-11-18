using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StronglyTypedXForms.Models.Builders;
using StronglyTypedXForms.Serialize;
using StructureMap;

namespace StronglyTypedXForms.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            container.For<IFormSerializer>().Use<FormSerializer>();
            container.For<IFormFieldSerializeUtils>().Use<FormFieldSerializeUtils>();
            container.For<IFormFieldModelBuilder>().Use<FormFieldModelBuilder>();
            container.For<IXFormBuilder>().Use<XFormBuilder>();

            container.For<IFormTypeModelSynchronizer>().Use<FormTypeModelSynchronizer>();
            container.For<IFormFieldTypeSynchronizer>().Use<FormFieldTypeSynchronizer>();

        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}

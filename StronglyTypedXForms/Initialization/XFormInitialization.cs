using EPiServer.Data;
using EPiServer.Framework;
using EPiServer.ServiceLocation;

namespace StronglyTypedXForms.Initialization
{
    /// <summary>
    /// XForm intialization
    /// </summary>
    [InitializableModule]
    [ModuleDependency(new[] { typeof(DataInitialization), typeof(DependencyResolverInitialization) })]
    public class XFormInitialization : IInitializableModule
    {
        /// <summary>
        /// Initalize method
        /// </summary>
        /// <param name="context"></param>
        public void Initialize(EPiServer.Framework.Initialization.InitializationEngine context)
        {
            var formTypeModelSynchronizer = ServiceLocator.Current.GetInstance<IFormTypeModelSynchronizer>();

            // Search for FormData implementations
            formTypeModelSynchronizer.Analyze();

            // Commit the forms
            formTypeModelSynchronizer.Commit();
        }

        /// <summary>
        /// Preload method
        /// </summary>
        /// <param name="parameters"></param>
        public void Preload(string[] parameters)
        {

        }

        /// <summary>
        /// Uninitialize
        /// </summary>
        /// <param name="context"></param>
        public void Uninitialize(EPiServer.Framework.Initialization.InitializationEngine context)
        {

        }
    }
}
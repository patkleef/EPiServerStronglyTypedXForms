namespace StronglyTypedXForms
{
    public interface IFormTypeModelSynchronizer
    {
        /// <summary>
        /// Commit the forms
        /// </summary>
        void Commit();

        /// <summary>
        /// Search for FormData implementations
        /// </summary>
        void Analyze();
    }
}
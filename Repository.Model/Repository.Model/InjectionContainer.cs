namespace Repository.Model
{
    /// <summary>
    /// This class contains information about a Dependency Injection container
    /// </summary>
    public class InjectionContainer
    {
        /// <summary>
        /// Gets or sets name of the container
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets company name of container
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets description of container
        /// </summary>
        public string Description { get; set; }

    }
}
namespace Repository.CSV
{
    using System.Collections.Generic;
    using System.IO;

    using Repository.Core;
    using Repository.Model;

    /// <summary>
    /// The comma seperated values repository.
    /// </summary>
    public class CSVRepository : IRepository
    {
        /// <summary>
        /// Fetches collection of InjectionContainers
        /// </summary>
        /// <returns>Collection of InjectionContainers</returns>
        public IEnumerable<InjectionContainer> GetContainers()
        {
            var containers = new List<InjectionContainer>();
            var reader = new StreamReader(File.OpenRead("InjectionContainers.txt"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    continue;
                }

                var values = line.Split(';');
                containers.Add(
                    new InjectionContainer
                        {
                            Name = values[0].Trim(), 
                            Author = values[1].Trim(), 
                            Description = values[2].Trim()
                        });
            }

            return containers;
        }
    }
}
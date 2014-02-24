using Humour.Infrastructure.DataContextStorage;

namespace Humour.Respository
{
    /// <summary>
    /// Manages instances of the ContactManagerContext and stores them in an appropriate storage container.
    /// </summary>
    public static class DataContextFactory
    {
        /// <summary>
        /// Clears out the current ContactManagerContext.
        /// </summary>
        public static void Clear()
        {
            var dataContextStorageContainer = DataContextStorageFactory<HumourContext>.CreateStorageContainer();
            dataContextStorageContainer.Clear();
        }

        /// <summary>
        /// Retrieves an instance of ContactManagerContext from the appropriate storage container or
        /// creates a new instance and stores that in a container.
        /// </summary>
        /// <returns>An instance of ContactManagerContext.</returns>
        public static HumourContext GetDataContext()
        {
            var dataContextStorageContainer = DataContextStorageFactory<HumourContext>.CreateStorageContainer();
            var humourContext = dataContextStorageContainer.GetDataContext();
            if (humourContext == null)
            {
                humourContext = new HumourContext();
                dataContextStorageContainer.Store(humourContext);
            }
            return humourContext;
        }
    }
}

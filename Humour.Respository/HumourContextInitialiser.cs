using System.Data.Entity;

namespace Humour.Respository
{
    /// <summary>
    /// Used to initialize the HumourContext from Integration Tests
    /// </summary>
    public static class HumourContextInitializer
    {
        /// <summary>
        /// Sets the IDatabaseInitializer for the application.
        /// </summary>
        /// <param name="dropDatabaseIfModelChanges">When true, uses the MyDropCreateDatabaseIfModelChanges to recreate the database when necessary.
        /// Otherwise, database initialization is disabled by passing null to the SetInitializer method.
        /// </param>
        public static void Init(bool dropDatabaseIfModelChanges)
        {
            if (dropDatabaseIfModelChanges)
            {
                Database.SetInitializer(new MyDropCreateDatabaseIfModelChanges());
                using (var db = new HumourContext())
                {
                    db.Database.Initialize(false);
                }
            }
            else
            {
                Database.SetInitializer<HumourContext>(null);
            }
        }
    }
}

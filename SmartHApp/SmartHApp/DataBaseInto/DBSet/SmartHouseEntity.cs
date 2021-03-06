namespace DataBaseInto.DBSet
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SmartHouseEntity : DbContext
    {
        // Your context has been configured to use a 'SmartHouseEntity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataBaseInto.DBSet.SmartHouseEntity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SmartHouseEntity' 
        // connection string in the application configuration file.
        public SmartHouseEntity()
            : base("name=SmartHouseEntity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Meteo> Meteo { get; set; }
        public virtual DbSet<Logger> Logger { get; set; }
        public virtual DbSet<Errors> Errors { get; set; }
        public virtual DbSet<Electric> Electric { get; set; }
        public virtual DbSet<ElectricState> ElectricState { get; set; }
    }
}
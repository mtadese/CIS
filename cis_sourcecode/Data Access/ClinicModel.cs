namespace CIS.Data.DataAccess
{
    using Application.Entities;
    using System.Data.Entity;

    public class ClinicModel : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ClinicModel' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Data_Access.ClinicModel' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ClinicModel'  en el archivo de configuración de la aplicación.
        public ClinicModel()
            : base("name=ClinicModel")
        {
            Database.SetInitializer(new ClinicInitializer());
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Clinic> Clinicians { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}
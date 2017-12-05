namespace HC_SB.Modelos
{
    using HC_SB.Modelos.HistoriasClinicas;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HC_SBContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'HC_SBContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'HC_SB.Modelos.HC_SBContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'HC_SBContext'  en el archivo de configuración de la aplicación.
        public HC_SBContext()
            : base("name=HC_SBContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<HistoriaClinica> Tbl_HistoriasClinicas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
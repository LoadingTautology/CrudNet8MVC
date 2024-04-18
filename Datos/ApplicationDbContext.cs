using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        #region Modelos BD
        //Agregar los modelos aqui, cada modelo corresponde a una tabla en la BD
        public DbSet<Contacto> ContactoModelo { get; set; }

        #endregion


    }
}

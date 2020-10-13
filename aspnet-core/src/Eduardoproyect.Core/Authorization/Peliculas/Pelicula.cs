using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Eduardoproyect.Authorization.Users;
using Abp.Domain.Entities.Auditing;
using Abp.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Eduardoproyect.Authorization.Peliculas
{
    [Table("AbpPeliculas")]
    public class Pelicula : Entity
    {

        public Pelicula()
        {
            
        }

        public string director {get; set;}
        public string productor { get; set; }
        public int year { get; set; }
        public bool successfull { get; set; }
    }
}

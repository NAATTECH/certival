using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace CERTIVAL.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "CURP")]
        public string Curp { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Required]
        [Display(Name = "Domicilio")]
        public string Domicilio { get; set; }

        [Required]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Required]
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        [Required]
        [Display(Name = "Entidad Federativa donde radica")]
        public string EntidadFederativa { get; set; }

        [Required]
        [Display(Name = "Delegacion/Municipio donde radica")]
        public string Municipio { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Casa")]
        public string TelefonoCasa { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono celular")]
        public string TelefonoCelular { get; set; }

        [Required]
        [Display(Name = "Medio por el que se entero de este programa")]
        public string MedioInformativo { get; set; }

        [Required]
        [Display(Name = "Aceptación de aviso de conformidad")]
        public bool AceptaAvisoConformidad { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ApplicationDbContext", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        static ApplicationDbContext()
        {
            //#if DEBUG
            //    Database.SetInitializer<ApplicationDbContext>(new DropCreateIfChangeApplicationDbContextInitializer());
            //#else
            //    Database.SetInitializer<ApplicationDbContext>(new CreateApplicationDbContextInitializer());        
            //#endif

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public void Seed(ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "AppAdmin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "AppAdmin" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "UsuarioRegistrado"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "UsuarioRegistrado" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "pablo.vilchis@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { AceptaAvisoConformidad = true, ApellidoPaterno = "Vilchis", ApellidoMaterno = "Diaz Santana", Nombre = "Juan Pablo", Domicilio = "Plaza Napoli 1155", CodigoPostal = "64102", Colonia = "Las Plazas", Email = "pablo.vilchis@gmail.com", EmailConfirmed = true, Curp = "VIDJ790131HMCLZN00", EntidadFederativa = "Nuevo León", Municipio = "Monterrey", FechaNacimiento = new DateTime(1979,01,31), Genero = "Masculino", MedioInformativo = "Internet", Nacionalidad = "Mexicana", PhoneNumber = "8117631522", PhoneNumberConfirmed = true, UserName = "pablo.vilchis@gmail.com", TelefonoCasa = "8117631522", TelefonoCelular = "8117631522" };

                manager.Create(user, "G3r0n1m0");
                manager.AddToRole(user.Id, "AppAdmin");
            }

        }
    }
}
using CERTIVAL.DAL.Entities;
using CERTIVAL.Models;
using ExpressMapper;

namespace CERTIVAL
{
    internal class MappingConfig
    {
        internal static void MappingRegistration()
        {
            Mapper.Register<RegistrarSolicitudViewModel, Solicitud>()
                .Member(dest=>dest.Genero,src=>src.Genero.ToString())
                .Ignore(dest => dest.Id)
                .Ignore(dest => dest.Edad)
                .Ignore(dest => dest.SolicitudId)
                .Ignore(dest => dest.AdjuntoActaNacimiento)
                .Ignore(dest => dest.AdjuntoAntecedenteAcademicoInmediato)
                .Ignore(dest => dest.AdjuntoCertificadoCompetenciaLaboral)
                .Ignore(dest => dest.AdjuntoConstanciaHonorabilidad)
                .Ignore(dest => dest.AdjuntoConstanciaMaximaEstudios)
                .Ignore(dest => dest.AdjuntoCVActualizado)
                .Ignore(dest => dest.AdjuntoEvaluacionAprobatoriaEstudios)
                .Ignore(dest => dest.AdjuntoIdentificacionOficial)
                .Ignore(dest => dest.AdjuntoPortafolioEvidencias);

            Mapper.Register<RegisterViewModel, ApplicationUser>()
                .Ignore(dest => dest.PasswordHash)
                .Ignore(dest => dest.AccessFailedCount)
                .Ignore(dest => dest.Claims)
                .Ignore(dest => dest.Id)
                .Ignore(dest => dest.LockoutEnabled)
                .Ignore(dest => dest.LockoutEndDateUtc)
                .Ignore(dest => dest.Logins)
                .Ignore(dest => dest.PhoneNumber)
                .Ignore(dest => dest.PhoneNumberConfirmed)
                .Ignore(dest => dest.Roles)
                .Ignore(dest => dest.SecurityStamp)
                .Ignore(dest => dest.TwoFactorEnabled)
                .Ignore(dest => dest.EmailConfirmed)
                .Ignore(dest => dest.PhoneNumberConfirmed)
                .Member(dest => dest.UserName, src=> src.Email);

            Mapper.Compile();

        }
    }
}
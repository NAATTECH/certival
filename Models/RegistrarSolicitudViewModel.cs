using CERTIVAL.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CERTIVAL.Models
{
    public class RegistrarSolicitudViewModel
    {

        [ScaffoldColumn(false)]
        [DataType(DataType.Text)]
        public string SolicitudId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Procedimiento { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre(s)")]
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
        [RegularExpression(@"^[a-zA-Z]{4}((\d{2}((0[13578]|1[02])(0[1-9]|[12]\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\d|30)|02(0[1-9]|1\d|2[0-8])))|([02468][048]|[13579][26])0229)(H|M)(AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|SM|NE)([a-zA-Z]{3})([a-zA-Z0-9\s]{1})\d{1}$+")]
        public string Curp { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Género")]
        public Genero Genero { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Calle y Número")]
        public string Domicilio { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Estado donde radica")]
        public string EntidadFederativa { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Municipio donde radica")]
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
        [DataType(DataType.Text)]
        [Display(Name = "Medio por el que se entero de este programa")]
        public string MedioInformativo { get; set; }

        [Required]
        [Display(Name = "Aceptación de aviso de conformidad")]
        public bool AceptaAvisoConformidad { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nivel que desea acreditar")]
        public string NivelAcreditar { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Perfil Profesional que acreditó")]
        public string PerfilProfesional { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Acta de Nacimiento")]
        public HttpPostedFileBase AdjuntoActaNacimiento { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Identificación Oficial vigente")]
        public HttpPostedFileBase AdjuntoIdentificacionOficial { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Antecedente Académico inmediato")]
        public HttpPostedFileBase AdjuntoAntecedenteAcademicoInmediato { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Constancia que avale el grado máximo de estudios")]
        public HttpPostedFileBase AdjuntoConstanciaMaximaEstudios { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar, ¿Cuenta usted con alguna evaluación aprobatoria de los estudios que desea acreditar?")]
        public HttpPostedFileBase AdjuntoEvaluacionAprobatoriaEstudios { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Constancia de Honorabilidad")]
        public HttpPostedFileBase AdjuntoConstanciaHonorabilidad { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar CV actualizado, con fotografía y firma")]
        public HttpPostedFileBase AdjuntoCVActualizado { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Certificado de Competencia Laboral")]
        public HttpPostedFileBase AdjuntoCertificadoCompetenciaLaboral { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        [DataType(DataType.Upload)]
        [Display(Name = "Agregar Portafolio de Evidencias de Trabajo")]
        public HttpPostedFileBase AdjuntoPortafolioEvidencias { get; set; }

    }
}
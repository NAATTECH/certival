using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CERTIVAL.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recirdarme en este Navegador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "No cerrar sesión")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        [System.ComponentModel.DataAnnotations.Compare("Email")]
        [Display(Name = "Confirmar correo electrónico")]
        public string ConfirmEmail{ get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos de {2} caracteres.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirma Contraseña")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "La Contraseña y la confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

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
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Domicilio")]
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
        [Display(Name = "Entidad Federativa donde radica")]
        public string EntidadFederativa { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Delegacion/Municipio donde radica")]
        public string Municipio { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Casa")]
        public string TelefonoCasa { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Celular")]
        public string TelefonoCelular { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Medio por el que se entero de este programa")]
        public string MedioInformativo { get; set; }

        [Required]
        [Display(Name = "Aceptación de aviso de conformidad")]
        public bool AceptaAvisoConformidad { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos de {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "La contraseña y la confirmación de la contraseña No considen.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

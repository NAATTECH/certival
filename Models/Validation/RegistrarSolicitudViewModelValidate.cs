using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CERTIVAL.Models.Validation
{
    public class RegistrarSolicitudViewModelValidate
    {

        public static void Validate(RegistrarSolicitudViewModel model, ModelStateDictionary modelState)
        {
            //Validar Adjuntos
            ValidateAttachment(model.AdjuntoActaNacimiento, "AdjuntoActaNacimiento", modelState);
            ValidateAttachment(model.AdjuntoIdentificacionOficial, "AdjuntoIdentificacionOficial", modelState);
            ValidateAttachment(model.AdjuntoAntecedenteAcademicoInmediato, "AdjuntoAntecedenteAcademicoInmediato", modelState);
            ValidateAttachment(model.AdjuntoConstanciaMaximaEstudios, "AdjuntoConstanciaMaximaEstudios", modelState);
            ValidateAttachment(model.AdjuntoEvaluacionAprobatoriaEstudios, "AdjuntoEvaluacionAprobatoriaEstudios", modelState);
            ValidateAttachment(model.AdjuntoConstanciaHonorabilidad, "AdjuntoConstanciaHonorabilidad", modelState);
            ValidateAttachment(model.AdjuntoCVActualizado, "AdjuntoCVActualizado", modelState);
            ValidateAttachment(model.AdjuntoCertificadoCompetenciaLaboral, "AdjuntoCertificadoCompetenciaLaboral", modelState);
            ValidateAttachment(model.AdjuntoPortafolioEvidencias, "AdjuntoCertificadoCompetenciaLaboral", modelState);
        }


        private static void ValidateAttachment(HttpPostedFileBase file, string propertyName, ModelStateDictionary modelState)
        {
            var validImageTypes = new string[]
            {
                            "image/jpeg",
                            "application/pdf"
            };
            var requiredError = "Este campo es requerido";
            var contentTypeError = "Por favor escoja un archivo JPEG o PDF.";

            if ((file == null || file.ContentLength == 0))
            {
                //modelState.AddModelError(propertyName, requiredError);
            }
            else if (file.ContentType != null && !validImageTypes.Contains(file.ContentType))
            {
                modelState.AddModelError(propertyName, contentTypeError);
            }
        }
    }
}
using CERTIVAL.BLL;
using CERTIVAL.DAL.Entities;
using CERTIVAL.Models;
using CERTIVAL.Models.Validation;
using CERTIVAL.Utilities;
using System.Linq;
using System.Web.Mvc;
using ExpressMapper;

namespace CERTIVAL.Controllers
{
    [Authorize]
    public class SolicitudController : Controller
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }

        //
        // GET: /Account/Register
        [HttpGet]
        public ActionResult Register(string procedimiento = "General")
        {
            SetViewBag(procedimiento);
            var model = new RegistrarSolicitudViewModel { Procedimiento = procedimiento };
            return View(model);
        }

        [HttpGet]
        public JsonResult GetPerfiles(int nivelId)
        {
            var perfiles = new SelectList(SolicitudProcessor.ObtenerPerfilesProfesionalesPorNivel(nivelId), "Id", "Nombre");
            return Json(perfiles, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegistrarSolicitudViewModel model)
        {
            RegistrarSolicitudViewModelValidate.Validate(model, ModelState);

            if (ModelState.IsValid)
            {
                var solicitud = SolicitudProcessor.Crear();
                solicitud = Mapper.Map(model, solicitud);

                SubirAdjuntos(model, solicitud);

                var creadaSolicitud = SolicitudProcessor.Guardar(solicitud);

                if (creadaSolicitud == 1)
                    return RedirectToAction("Index");
            }

            SetViewBag(model.Procedimiento);

            return View(model);
        }

        private static void SubirAdjuntos(RegistrarSolicitudViewModel model, Solicitud solicitud)
        {
            solicitud.AdjuntoActaNacimiento = FileUtility.UploadFile(model.AdjuntoActaNacimiento);
            solicitud.AdjuntoIdentificacionOficial = FileUtility.UploadFile(model.AdjuntoIdentificacionOficial);
            solicitud.AdjuntoAntecedenteAcademicoInmediato = FileUtility.UploadFile(model.AdjuntoAntecedenteAcademicoInmediato);
            solicitud.AdjuntoConstanciaMaximaEstudios = FileUtility.UploadFile(model.AdjuntoConstanciaMaximaEstudios);
            solicitud.AdjuntoEvaluacionAprobatoriaEstudios = FileUtility.UploadFile(model.AdjuntoEvaluacionAprobatoriaEstudios);
            solicitud.AdjuntoConstanciaHonorabilidad = FileUtility.UploadFile(model.AdjuntoConstanciaHonorabilidad);
            solicitud.AdjuntoCVActualizado = FileUtility.UploadFile(model.AdjuntoCVActualizado);
            solicitud.AdjuntoCertificadoCompetenciaLaboral = FileUtility.UploadFile(model.AdjuntoCertificadoCompetenciaLaboral);
        }

        private void SetViewBag(string procedimiento)
        {
            ViewBag.Entidades = new SelectList(SolicitudProcessor.ObtenerEntidades(), "Id", "Nombre");
            ViewBag.Medios = new SelectList(SolicitudProcessor.ObtenerMediosInformativos(), "Id", "Nombre");
            ViewBag.Niveles = new SelectList(SolicitudProcessor.ObtenerNivelesPorProcedimiento(procedimiento), "Id", "Nombre");
        }

    }
}

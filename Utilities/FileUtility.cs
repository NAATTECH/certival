using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace CERTIVAL.Utilities
{
    public static class FileUtility
    {
        public static string UploadFile(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var uploadDir = ConfigurationManager.AppSettings["uploadDirectory"].ToString();
                var imagePath = Path.Combine(HttpContext.Current.Server.MapPath(uploadDir), file.FileName);
                var imageUrl = Path.Combine(uploadDir, file.FileName);
                file.SaveAs(imagePath);
                return imageUrl;
            }
            return null;
        }
    }
}
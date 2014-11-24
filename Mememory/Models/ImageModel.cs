using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Mememory.Models
{
    public class ImageModel : List<UploadModel>
    {
        public ImageModel()
        {
            string imagesDir = HttpContext.Current.Server.MapPath("~/App_Data/");
            XDocument imagesMetaData = XDocument.Load(imagesDir + @"/ImagesMetaData.xml");
            var images = from image in imagesMetaData.Descendants("image")
                         select new UploadModel(image.Element("title").Value,
                         image.Element("url").Value,
                         image.Element("description").Value,
                         image.Element("genre").Value);
            this.AddRange(images.ToList<UploadModel>());
        }
    }
}
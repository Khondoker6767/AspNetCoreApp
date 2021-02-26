using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models.ViewModes
{
    public class ImageViewModel:CreatePlayerModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}

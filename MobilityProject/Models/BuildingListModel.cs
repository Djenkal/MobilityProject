using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilityProject.Models
{
    public class BuildingListModel
    {
        public Room room;
        public SelectList buildings;
        public string building { get; set; } 
    }
}

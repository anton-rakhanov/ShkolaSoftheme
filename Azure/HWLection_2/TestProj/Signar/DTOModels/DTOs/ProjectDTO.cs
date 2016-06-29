using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModels.DTOs
{
    public class ProjectDTO
    {
        public string Name { get; set; }

        public string Prefix { get; set; }

        public bool IsDeleted { get; set; }

        public ProjectDTO()
        {

        }
    }
}

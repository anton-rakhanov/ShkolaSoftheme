using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignarDTOModels.AsignarDatabaseDTOs
{
    public class BugDTO
    {

        public string BugName { get; set; }


        public string Subject { get; set; }


        public string Description { get; set; }


        public UserDTO UserID { get; set; }


        public List<AttachmentDTO> Attachments { get; set; }


        public ProjectDTO ProjectID { get; set; }


        public DateTime CreationDate { get; set; }


        public DateTime ModificationDate { get; set; }


        public sbyte BugState { get; set; }


        public sbyte Priority { get; set; }


        public BugDTO()
        {

        }

    }
}

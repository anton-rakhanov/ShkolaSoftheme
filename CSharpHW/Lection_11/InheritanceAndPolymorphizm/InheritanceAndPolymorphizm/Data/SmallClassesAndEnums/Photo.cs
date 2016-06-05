using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphizm.Data.SmallClassesAndEnums
{
    public class Photo
    {
        public string PhotoName { get; set; }

        public Photo(string photoName)
        {
            this.PhotoName = photoName;
        }
    }
}

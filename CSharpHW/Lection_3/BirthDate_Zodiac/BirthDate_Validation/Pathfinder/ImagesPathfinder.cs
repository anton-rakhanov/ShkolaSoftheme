using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHandlerLibrary.Pathfinder
{
    public class ImagesPathfinder
    {
        private string _pathPattern = @"{0}\ZodiacImages\{1}.jpg";

        private string _fullPath = string.Empty;

        public string PathForIcons(string iconName)
        {
            return _fullPath = string.Format(_pathPattern, System.IO.Directory.GetCurrentDirectory(), iconName);
        }
    }
}

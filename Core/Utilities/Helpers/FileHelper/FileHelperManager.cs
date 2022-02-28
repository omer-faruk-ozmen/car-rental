using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Helpers.GuidHelper;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public IResult Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }


            return Upload(file, root);

        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string fileExtension = Path.GetExtension(file.FileName);
                string guid = GuidHelperManager.CreateGuid();
                string filePath = guid + fileExtension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }

            return null;
        }
    }
}

﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        IResult Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
        string Upload(IFormFile file, string root);
    }
}

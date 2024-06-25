using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Interfaces.Storage
{
    public interface ILocalStorage
    {
        Task<(string FileName,string Path)> UploadAsync(int id,string folderName,IFormFile file);

        Task<IList<(string FilesName, string Path)>> UploadManyAsync(int id,string folderName,IFormFileCollection files);

        Task DeleteAsync(string Path,string fileName);

         IList<string> GetFile(string Path);
    }
}

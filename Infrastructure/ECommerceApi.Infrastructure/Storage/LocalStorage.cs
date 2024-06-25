using ECommerceApi.Application.Interfaces.Storage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.Storage
{
    public class LocalStorage : ILocalStorage
    {


        private readonly IWebHostEnvironment webHost;

        private readonly string _wwwroot;
       
        private readonly string FolderPath="images";


        public LocalStorage(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
            _wwwroot= webHost.WebRootPath;
        }


         public Task DeleteAsync(string path, string fileName)
        {
            path=FolderPath;
            string FileForDelete = Path.Combine($"{_wwwroot}/{path}", fileName);
            if (File.Exists(FileForDelete))
                File.Delete(FileForDelete);
            return Task.CompletedTask;
        }

        public IList<string> GetFile(string Path)
        {
            throw new NotImplementedException();
        }

        public async Task<(string FileName, string Path)> UploadAsync(int id, string folderName, IFormFile file)
        {
            if (!Directory.Exists($"{_wwwroot}/{FolderPath}/{folderName}"))
                Directory.CreateDirectory($"{_wwwroot}/{FolderPath}/{folderName}");
            DateTime DateOfCreation = DateTime.Now;

             
                string FileExtention = Path.GetExtension(file.FileName);

                string NewFileName = $"{file.FileName.Replace(FileExtention,$"_{id}").ToLower()}_{DateOfCreation.Date:dd_MM_yyyy}{FileExtention}";

                string path = Path.Combine($"{_wwwroot}/{FolderPath}/{folderName}", NewFileName);

                await using var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, (1024 * 1024), false);

                await file.CopyToAsync(stream);
                await stream.FlushAsync();

                return ((NewFileName, path));

       
        }

        public async Task<IList<(string FilesName, string Path)>> UploadManyAsync(int id, string folderName, IFormFileCollection files)
        {
            if (!Directory.Exists($"{_wwwroot}/{FolderPath}/{folderName}"))
                Directory.CreateDirectory($"{_wwwroot}/{FolderPath}/{folderName}");
            DateTime DateOfCreation = DateTime.Now;

            List <(string FilesName, string Path)> ListOfImages= new();

            foreach (IFormFile file in files)
            {
                string FileExtention= Path.GetExtension(file.FileName);

                string NewFileName = $"{file.FileName.Replace(FileExtention, $"_{id}").ToLower()}_{DateOfCreation.Date:dd_MM_yyyy}.{FileExtention}";

                string path = Path.Combine($"{_wwwroot}/{FolderPath}/{folderName}", NewFileName);

                await using var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None,(1024*1024),false);

                await file.CopyToAsync(stream);
                await stream.FlushAsync();

                ListOfImages.Add((NewFileName, path));

            }
            return ListOfImages;

        }
    }
}

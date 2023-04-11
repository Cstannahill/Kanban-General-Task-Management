using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Domain.Files;
using Services.Interfaces;
using Sabio.Web.Models.Responses;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs;


namespace Web.Api.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IFileService _fileService = null;
        private readonly BlobServiceClient _blobServiceClient;
        public FileController(IFileService fileService, BlobServiceClient blobServiceClient)
        {
            _fileService = fileService;
            _blobServiceClient = blobServiceClient;
        }
        [HttpPost]
        public async Task<ActionResult<ItemResponse<string>>> Upload(IFormFile file)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient("images");
            await containerClient.CreateIfNotExistsAsync();
            string returnUrl = $"https://ctandevstorage.blob.core.windows.net/images/{file.FileName}";
            var blobClient = containerClient.GetBlobClient(file.FileName);
            var response = await blobClient.UploadAsync(file.OpenReadStream());
            ItemResponse<string> res = new ItemResponse<string>() { Item = returnUrl };
            return res;
        }
    }
    
}


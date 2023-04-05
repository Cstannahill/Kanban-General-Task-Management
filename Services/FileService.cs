using Azure;
using Azure.Storage.Blobs;
using Data.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure;
using Models.Domain.Files;
using Models.Domain.Users;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Services
{
    public class FileService : IFileService
    {

        IDataProvider _data = null;


        public FileService(IDataProvider data)
        {
            _data = data;
        }

        public async void UploadFile(List<IFormFile> files)
        {
            Console.WriteLine("Console");
        }
        //    Console.WriteLine(files);
        //    var blobStorageConnectionString = "DefaultEndpointsProtocol = https; AccountName = ctandevstorage; AccountKey = S3cdBCmeJ2B4hLM3QM9b81CIhAbOomOfRX6HAHZ + uKjlcRGP5CYVGY5q4Zv1jHl85TXmC + v6oqBw + ASt9JZPww ==; EndpointSuffix = core.windows.net";
        //    //var blobContainerName = "images";
        //    //var containerClient = new BlobContainerClient(blobStorageConnectionString, blobContainerName);
        //    //string fileName = "Img1";
        //    //string filePath = "C:/Users/Christian/Pictures/Images/Img1.jpg";
        //    // Use a connection string
        //    string sas = "https://ctandevstorage.blob.core.windows.net/images?sp=racwdli&st=2023-01-26T16:56:28Z&se=2023-02-03T00:56:28Z&sv=2021-06-08&sr=c&sig=%2B07zd1MklX98OdX9DWc5Jna789TDdHu9GKqARYUo7Uk%3D";
        //    // Or use a SAS token
        //    BlobServiceClient blob_service_client = BlobServiceClient.

        //    // Create a blob client
        //    CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

        //    // Get a reference to the container
        //    CloudBlobContainer container = blobClient.GetContainerReference("images");

        //    // Create the container if it doesn't exist
        //    await container.CreateIfNotExistsAsync();

        //    // Get a reference to the blob
        //    CloudBlockBlob blockBlob = container.GetBlockBlobReference("<blob-name>");

        //    // Open the file stream to read the image
        //    using (FileStream fileStream = System.IO.File.OpenRead("<path-to-image>"))
        //    {
        //        // Upload the image to the container
        //        await blockBlob.UploadFromStreamAsync(fileStream);
        //    }
        //    //storageAccount = CloudStorageAccount.Parse(sas);
        //    //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
        //    //Get a reference to a blob named "sample-file" in a container named "sample-container"
        //    //Upload a blob
        //    //CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");
        //    //container.CreateIfNotExistsAsync();
        //    //var blob = container.GetBlockBlobReference("myblob");
        //    //blob.UploadFromStreamAsync("<stream>");

        //    //Retrieve a blob
        //    //CloudBlockBlob blockBlob = container.GetBlockBlobReference("myblob");
        //    //using (var memoryStream = new MemoryStream())
        //    //{
        //    //    await blockBlob.DownloadToStreamAsync(memoryStream);
        //    //    // Do something with the memoryStream
        //    //}



        //    //Upload local file

        //}




    }


}


using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace GoogleDriveApi
{
   public class FileOperations
    {
       
        private FilesResource.ListRequest ParameterizedRequest()
        {
            CreateApiService createApiService = new CreateApiService();
            FilesResource.ListRequest listRequest = createApiService.CallAppiService().Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";
            return listRequest;
        }
        public List<UserFiles> FetchListOfFiles()
        {
            List<UserFiles> userFiles = new List<UserFiles>();
            IList<Google.Apis.Drive.v3.Data.File> files = ParameterizedRequest().Execute()
               .Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
               
                foreach (var file in files)
                {
                    userFiles.Add(new UserFiles { FileName = file.Name, FileID = file.Id, CreationTime = file.CreatedTime });
                }
            }
            return userFiles;
        }
    }
}

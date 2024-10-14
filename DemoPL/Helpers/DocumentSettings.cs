using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace DemoPL.Helpers
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            // 1. Get Located Folder Path
            // string FolderPath = "D:\\Route\\Back-End\\06 MVC\\Session 05\\Demos\\G03 Demo Solution\\DemoPL\\Helpers\\";
            // string FolderPath = Directory.GetCurrentDirectory() + @"\wwwroot\files\" + folderName;

            string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);

            // 2. Get File Path
            string fileName = $"{Guid.NewGuid()}{ file.FileName}";

            // 3. Get File Path
            string filePath = Path.Combine(folderpath, fileName);

            // 4. Save File As Streams[Data per Time]
            var fileStream = new FileStream(filePath, FileMode.Create);
        
            file.CopyTo(fileStream);

            return fileName;
        
        
        }
    
    
    
        public static void DeleteFile(string fileName , String folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory (), "wwwroot\\files", folderName);
            if(File.Exists(filePath))
                File.Delete(filePath);
        }
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

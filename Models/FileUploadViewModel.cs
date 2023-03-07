using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FILE_UPLOAD.Models
{
    public class FileUploadViewModel
    {
        public List<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
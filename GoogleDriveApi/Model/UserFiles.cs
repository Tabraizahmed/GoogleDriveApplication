using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleDriveApi.Model
{
   public class UserFiles
    {
        public string FileID { get; set; }
        public string FileName { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}

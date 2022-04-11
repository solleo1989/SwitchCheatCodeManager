using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;

namespace SwitchCheatCodeManager.Model
{
    public class FtpUtility
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }

        public List<string> LoadFileList()
        {
            // Create a FTP request
            var request = (FtpWebRequest)WebRequest.Create(Path);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(UserName, Password);
            // List files
            List<string> files = new List<string>();
            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    var reader = new StreamReader(responseStream);
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line) == false)
                        {
                            var fileName = line.Split(new[] { ' ', '\t' }).Last();
                            if (!fileName.StartsWith("."))
                                files.Add(fileName);
                        }
                    }
                    return files;
                }
            }
        }
    }
}

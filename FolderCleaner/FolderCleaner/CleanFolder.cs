using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCleaner
{
    class CleanFolder 
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        public List<string> fileTypeToKeep = new List<string>();
        public System.IO.DirectoryInfo destPath;

        public void CleanDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, you
                // can try to elevate your privileges and access the file again.
                log.Add(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    //Console.WriteLine(fi.FullName);
                    if (!fileTypeToKeep.Contains(fi.Extension))
                    {
                        try
                        {
                            string fileName = System.IO.Path.Combine(fi.Directory.ToString(), fi.FullName);
                            string destFile = System.IO.Path.Combine(destPath.ToString(), fi.ToString());

                            if (File.Exists(destFile))
                            {
                                File.Delete(destFile);
                                File.Move(fileName, destFile);
                            }
                            else
                            {
                                System.IO.File.Move(fileName, destFile);
                            }
                        }
                        catch (IOException e)
                        {

                            throw e;
                        }
                       
                    }
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    CleanDirectoryTree(dirInfo);
                }
            }
        }
    }
}

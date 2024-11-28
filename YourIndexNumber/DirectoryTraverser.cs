using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourIndexNumber
{
    internal class DirectoryTraverser
    {
        public DirectoryTraverser(string folderName)
        {
            Console.WriteLine(folderName);
        }

        public void RecursiveDirectoryTraverser(DirectoryInfo dir, int rootLevel)
        {
            foreach (FileSystemInfo child in dir.GetFileSystemInfos())
            {
                if (child is DirectoryInfo)
                {
                    for (int i = 0; i < rootLevel; i++)
                    {
                        if (i == rootLevel - 1)
                        {
                            Console.Write(" ------ ");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                    Console.WriteLine(child.Name);
                    RecursiveDirectoryTraverser((DirectoryInfo)child, rootLevel + 1);
                }
                else if (child is FileInfo)
                {
                    for (int i = 0; i < rootLevel - 1; i++)
                    {
                        Console.Write("\t");
                    }
                    Console.Write("|");
                    Console.WriteLine("\t{0}", child.Name);
                }
            }
        }

        public void IterativeDirectoryTraverser(DirectoryInfo dir)
        {
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
            stack.Push(dir);
            int rootLevel = 1;
            while (stack.Count > 0)
            {
                DirectoryInfo currentDir = stack.Pop();
                try
                {

                    // Print file names
                    foreach (FileInfo file in currentDir.GetFiles())
                    {
                        for (int i = 0; i < rootLevel - 1; i++)
                        {

                            Console.Write("\t");

                        }
                        Console.Write("|");
                        Console.WriteLine("\t{0}", file.FullName);
                    }

                    // Push all subdirectories onto the stack
                    foreach (DirectoryInfo subDir in currentDir.GetDirectories())
                    {
                        for (int i = 0; i < rootLevel; i++)
                        {
                            if (i == rootLevel - 1)
                            {
                                Console.Write(" ------ ");
                            }
                            else
                            {
                                Console.Write("\t");
                            }
                        }

                        Console.WriteLine(subDir.Name);
                        stack.Push(subDir);

                        // Increment the root level
                        rootLevel++;
                    }


                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Access denied to: " + currentDir.FullName);
                }
            }
        }
    }
}

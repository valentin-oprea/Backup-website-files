/*
   Copyright (c) 2016 Valentin Oprea | Olympia WA.

   Permission is hereby granted, free of charge, to any person obtaining
   a copy of this software and associated documentation files (the "Software"),
   to deal in the Software without restriction, including without limitation
   the rights to use, copy, modify, merge, publish, distribute, sublicense,
   and/or sell copies of the Software, and to permit persons to whom the Software
   is furnished to do so, subject to the following conditions:

   The above copyright notice and this permission notice shall be included in
   all copies or substantial portions of the Software.

   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
   EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
   OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
   OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/


using System;
// make sure you add the reference assemblies to your project: System.IO.Compression and System.IO.Compression.FileSystem
using System.IO.Compression;

namespace Website_backUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //provide your folder path to be zipped
            string folderToZip = @"C:\Users\your_username\path_to_location\domain.com";
            // new name for the zipped folder based on date
            string folder_name = DateTime.Now.ToString("backup on MMM-dd HH-mm");

            //provide your path and name for the zip file to be created
            string zipFile = @"C:\Users\your_username\path_to_new_location\" + folder_name + ".zip";

            //call the ZipFile.CreateFromDirectory() method
            ZipFile.CreateFromDirectory(folderToZip, zipFile);
        }
    }
}

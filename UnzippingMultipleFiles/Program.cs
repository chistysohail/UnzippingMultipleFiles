using System.IO.Compression;

namespace UnzipMultipleFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the folder containing the .zip files:");
            string folderPath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(folderPath))
            {
                Console.WriteLine("No folder path was provided. Exiting...");
                return;
            }

            // Ensure the directory exists
            if (Directory.Exists(folderPath))
            {
                // Get all .zip files in the directory
                string[] zipFiles = Directory.GetFiles(folderPath, "*.zip");

                foreach (var zipFile in zipFiles)
                {
                    try
                    {
                        // Define the extraction path
                        string extractPath = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(zipFile));

                        // Ensure the extraction path directory exists
                        if (!Directory.Exists(extractPath))
                        {
                            Directory.CreateDirectory(extractPath);
                        }

                        // Extract the zip file
                        ZipFile.ExtractToDirectory(zipFile, extractPath, true);
                        Console.WriteLine($"Extracted: {zipFile}");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"Error extracting {zipFile}: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"The directory {folderPath} does not exist.");
            }
        }
    }
}

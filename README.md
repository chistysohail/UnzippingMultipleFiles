# UnzippingMultipleFiles

The entry point of the application is the Main method in the Program class. It does the following:

Prompts the User for the Folder Path: The application starts by asking the user to input the path to the folder containing the .zip files. This is achieved through Console.WriteLine for the prompt and Console.ReadLine to read the user input.

Checks the Input: It checks if the user has entered a path. If not, it displays a message and exits.

Validates the Directory: It checks if the provided path points to an existing directory. If the directory doesn't exist, it notifies the user and exits.

Finds and Extracts Zip Files: The application searches for all .zip files in the given directory. For each .zip file found, it does the following:

Determines an extraction path by creating a subfolder named after the .zip file (excluding the .zip extension).
Checks if the extraction path (subfolder) exists. If not, it creates the subfolder.
Extracts the .zip file into the subfolder using ZipFile.ExtractToDirectory.
Handles any errors during extraction (e.g., if a file cannot be extracted) and prints an error message.
Error Handling
The application includes basic error handling to manage situations like inaccessible files or non-existent directories. It catches exceptions thrown during the extraction process and displays an error message to the user.

Dependencies
The application relies on the System.IO.Compression namespace for working with zip files, which is part of the standard .NET libraries.




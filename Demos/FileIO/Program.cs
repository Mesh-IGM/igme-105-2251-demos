namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The file path is relative to the directory in which the program is
            // running. "<sln file folder>\FileIODemo\bin\Debug\net6.0" in this case.
            // The ..\..\..\ brings it up to the folder that your sln file is in
            // (The \ chars are also escaped)
            // https://docs.microsoft.com/en-us/dotnet/standard/io/file-path-formats  

            // RELATIVE path from exe up to code folder
            // String filename = "..\\..\\..\\data_files\\test_file.txt";

            // ABSOLUTE path that only works for Prof. Mesh
            string filename = "D:\\Profiles\\esmvcs\\Documents\\GitHub\\IGME-105\\igme-105-2251-demos\\Demos\\FileIO\\data_files\\test_file.txt";


            // Create the variable here since we need it
            // after the try
            StreamWriter writer = null;

            try
            {
                // When we open for writing, create
                // the file if it doesn't exist yet
                writer = new StreamWriter(filename);
                int b = 0;
                // Write some data
                writer.Write("Hello ");
                writer.WriteLine("there!");
                writer.WriteLine("This works!");
                writer.WriteLine(12 / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error writing: " + e.Message);
            }

            // Close it as long as it was actually opened
            if (writer != null)
            {
               // writer.Close();
            }




            // The file path is relative to the directory in which the program is
            // running. "<sln file folder>\FileIODemo\bin\Debug\net6.0" here.
            // The ..\..\..\ brings it up to the folder that your sln file is in
            // (The \ chars are also escaped)
            // https://docs.microsoft.com/en-us/dotnet/standard/io/file-path-formats  
            //String filename = "..\\..\\..\\test_file.txt";


            // Create the variable outside the try
            // since we'll need it afterwards
            StreamReader reader = null;

            try
            {
                // Creating the stream reader opens the file
                reader = new StreamReader(filename);

                // Loop through the file, one line at a time
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file: "
                    + e.Message);
            }

            // Ensure that we can close the file, as long
            // as it was actually opened in the first place
            if (reader != null)
            {
                reader.Close();
            }


        }
    }
}

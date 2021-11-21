using System.Diagnostics;

while (true)
{
    //command prompt
    Console.Write("~");
    string searchTerm = Console.ReadLine();

    //allows user to enter filename of game if they so choose
    string[] filePaths = Directory.GetFiles(@"C:\fceux\roms\", searchTerm + ".nes");

    //if there is actually a file that is found run the file else run commands or say invalid syntax
    if (filePaths.Length > 0)
    {
        //makes a new string that is the first file in the filePaths array so it can be run
        string gameFile = filePaths.First().Trim();

        //actually runs the fucking game
        // Prepare the process to run
        ProcessStartInfo start = new ProcessStartInfo();
        // Enter in the command line arguments, everything you would enter after the executable name itself
        start.Arguments = gameFile;
        // Enter the executable to run, including the complete path
        start.FileName = @"C:\fceux\fceux";
        // Do you want to show a console window?
        start.WindowStyle = ProcessWindowStyle.Hidden;
        start.CreateNoWindow = true;
        int exitCode;

        // Run the external process & wait for it to finish
        using (Process proc = Process.Start(start))
        {
            proc.WaitForExit();

            // Retrieve the app's exit code
            exitCode = proc.ExitCode;
        }
    }

    //where commands go
    if (filePaths.Length == 0)
    {
        if (searchTerm == "dir")
        {
            //gets the directory listing and puts it in the filePaths Array
            string[] dirListing = Directory.GetFiles(@"C:\fceux\roms\");
            //prints out every object in the filePaths array
            Array.ForEach(dirListing, Console.WriteLine);
        }
        if (searchTerm == "clear")
        {
            Console.Clear();
        }
        if (searchTerm == "exit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid command or file");
            continue;
        }
    }
    
    
    
}

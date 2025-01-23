using System.Diagnostics;

namespace HW16_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Process process = null;

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = @"C:\Users\Rog\source\repos\HW16.01\HW16.01\bin\Debug\net8.0\HW16.01.exe",
                UseShellExecute = false,
            };

            try
            {
                process = Process.Start(processStartInfo);
                process.WaitForExit();

                Console.WriteLine("Exit Code: " + process.ExitCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (process != null)
                {
                    process.Dispose();
                }
            }
        }
    }
}

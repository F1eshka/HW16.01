using System;
using System.Diagnostics;

namespace HW2
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

                Console.WriteLine("Виберіть дію: ");
                Console.WriteLine("1. Очікувати завершення дочірнього процесу");
                Console.WriteLine("2. Примусово завершити дочірній процес");
                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    process.WaitForExit();
                    Console.WriteLine("Exit Code: " + process.ExitCode);
                }
                else if (choice == "2")
                {
                    process.Kill();
                    Console.WriteLine("Дочірній процес було примусово завершено");
                }
                else
                {
                    Console.WriteLine("Неправильний вибір. Завершення програми");
                }
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

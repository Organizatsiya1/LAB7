using Logic;
using Model;

namespace Lab_7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // 1) ���� ��������� ������-������ ��� ����� ����������
            var Logic = new BusinessLogic();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(Logic));
            
            
        }
    }
}
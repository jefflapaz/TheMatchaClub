using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.Winforms;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using var context = DbContextHelper.Create();
        var authService = new AuthService(context);

        bool hasAdmin = authService.AdminExistsAsync().Result;

        if (!hasAdmin)
        {
            using var setup = new AdminSetupForm();
            if (setup.ShowDialog() != DialogResult.OK)
                return;
        }

        using var login = new LoginForm();
        if (login.ShowDialog() != DialogResult.OK)
            return;

        // TEMP MAIN FORM PLACEHOLDER
        MessageBox.Show("Login complete");

        System.Windows.Forms.Application.Run(new Form()); 
    }
}

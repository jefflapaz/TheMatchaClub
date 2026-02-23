using Microsoft.EntityFrameworkCore;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Winforms;

namespace TheMatchaClub.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {

        //Register Syncfusion<sup style="font-size:70%">&reg;</sup> license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF1cWGhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdENjW35XcHNRQWVUVEB3V0leYQ==");

        ApplicationConfiguration.Initialize();

        using var context = DbContextHelper.Create();
        context.Database.Migrate();
        var authService = new AuthService(context);
        var sessionService = new SessionService(context);

        // Admin setup or login
        bool hasAdmin = authService.AdminExistsAsync().GetAwaiter().GetResult();

        if (!hasAdmin)
        {
            using var setup = new AdminSetupForm();
            if (setup.ShowDialog() != DialogResult.OK)
                return;
        }

        using var login = new LoginForm();
        if (login.ShowDialog() != DialogResult.OK)
            return;

        
        System.Windows.Forms.Application.Run(new MainForm());
    }

   
       
    
}

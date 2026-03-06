using TheMatchaClub.Winforms;
using TheMatchaClub.Winforms.Forms;

namespace TheMatchaClub.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        System.Windows.Forms.Application.Run(new TestDeleteWhenPublish());
    }
}
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Xpo;

namespace SecurityDemo.UiLevel.Win
{
    public partial class SecurityDemoWindowsFormsApplication : WinApplication
    {
		public SecurityDemoWindowsFormsApplication()
        {
            InitializeComponent();
        }

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
        
        private void SecurityDemoWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            try {
                e.Updater.Update();
                e.Handled = true;
            }
            catch(CompatibilityException exception) {
                if(exception.Error is CompatibilityUnableToOpenDatabaseError) {
                    throw new UserFriendlyException(
                    "The connection to the database failed. This demo requires the local instance of Microsoft SQL Server Express. To use another database server,\r\nopen the demo solution in Visual Studio and modify connection string in the \"app.config\" file.");
                }
            }
        }
    }
}

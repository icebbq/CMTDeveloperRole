using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace CMTDeveloperRole.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CompositionContainer MEFContainer;

        protected override void OnStartup(StartupEventArgs e)
        {
            var asmCat = new AssemblyCatalog(typeof(App).Assembly);
            var dirCat = new DirectoryCatalog(".", "*.dll");
            var aggCat = new AggregateCatalog(asmCat, dirCat);
            MEFContainer = new CompositionContainer(aggCat);
        }
    }
}

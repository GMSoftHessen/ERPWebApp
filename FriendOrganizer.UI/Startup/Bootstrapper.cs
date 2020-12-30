using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;
using System.ComponentModel;

namespace FriendOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        public Autofac.IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}

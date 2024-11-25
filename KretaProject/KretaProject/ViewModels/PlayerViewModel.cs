using CommunityToolkit.Mvvm.ComponentModel;
using KretaProject.Models;
using System.Collections.ObjectModel;

namespace KretaProject.ViewModels
{
    public partial class PlayerViewModel : ObservableObject
    {
        [ObservableProperty]
        private Player _player=new Player();
        [ObservableProperty]
        private ObservableCollection<Player> _players = new ObservableCollection<Player>();
    }

}

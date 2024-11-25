using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaProject.Models;
using System.Collections.ObjectModel;
using System.Printing;

namespace KretaProject.ViewModels
{
    public partial class PlayerViewModel : ObservableObject
    {
        [ObservableProperty]
        private Player _player=new Player();
        [ObservableProperty]
        private ObservableCollection<Player> _players = new ObservableCollection<Player>();
        [ObservableProperty]
        private Player _selectedPlayer = new Player();

        [RelayCommand]
        public void DoSave(Player player)
        {
            Players.Add(player);
            Player = new Player();
            Player.CreationDate = DateTime.Now;
            OnPropertyChanged(nameof(Player));
        }
        [RelayCommand]
        public void DoNewPlayer()
        {
            Player = new Player();
            Player.CreationDate = DateTime.Now;
            OnPropertyChanged(nameof(Player));
        }
        [RelayCommand]
        public void DoDelete(Player player)
        {
            Players.Remove(player);
            Player = new Player();
            Player.CreationDate = DateTime.Now;
            OnPropertyChanged(nameof(Player));
        }
    }

}

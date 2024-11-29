using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaProject.Models;
using System.Collections.ObjectModel;
using System.Printing;
using System.Windows;

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

        public PlayerViewModel()
        {
            Player.CreationDate = DateTime.Now; 
        }

        [RelayCommand]
        public void DoSave(Player player)
        {
            if (player.PlayerCheck() != "") 
            {
                MessageBox.Show(player.PlayerCheck(),"Invalid value(s)!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                Players.Add(player);
                /*Player = new Player();
                Player.CreationDate = DateTime.Now;
                OnPropertyChanged(nameof(Player));*/
            }
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

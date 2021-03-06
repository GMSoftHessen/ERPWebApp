﻿using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService _friendDataService;
        private Friend _SelectedFriend;
        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            var friends = await _friendDataService.GetAllAsync();
            Friends.Clear();

            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }       
        public ObservableCollection<Friend> Friends { get; set; }
        public Friend SelectedFriend
        {
            get { return _SelectedFriend; }
            set 
            { 
                _SelectedFriend = value;                
                OnPropertyChanged();
            }
        }
        
    }
}

﻿using Library.Commands.FilialSectionCommans;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class FilialViewModel : BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        private ObservableCollection<Filial> allFilials;
        public ObservableCollection<Filial> AllFilials
        {
            get
            {
                return allFilials;
            }
            set
            {
                allFilials = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllFilials)));
            }
        }
        public FilialViewModel()
        {
            CurrentFilial = new Filial();
        }
        private Filial currentFilial;
        public Filial CurrentFilial
        {
            get
            {
                return currentFilial;
            }
            set
            {
                currentFilial = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentFilial)));
            }
        }

        private Filial selectedFilial;
        public Filial SelectedFilial
        {
            get
            {
                return selectedFilial;
            }
            set
            {
                selectedFilial = value;
                if (value != null)
                {
                    CurrentFilial = SelectedFilial.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedFilial)));
            }
        }

    }
}

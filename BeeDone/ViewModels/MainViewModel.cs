using BeeDone.Data;
using BeeDone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeDone.ViewModels
{
    public class MainViewModel
    {
        private readonly ITacheDataProvider _tacheDataProvider;
        public ObservableCollection<Tache> Taches { get; } = new ObservableCollection<Tache>();

        public MainViewModel(ITacheDataProvider tacheDataProvider)
        {
            _tacheDataProvider = tacheDataProvider;
        }

        public void ChargerTaches()
        {
            foreach (Tache tache in _tacheDataProvider.GetTaches())
            {
                Taches.Add(tache);
            }
        }

        public bool AjouterTache()
        {
            throw new NotImplementedException();
        }

        public bool SupprimerTache()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XamarinCalendarProject.Base;
using XamarinCalendarProject.Models;
using XamarinCalendarProject.Repositorio;

namespace XamarinCalendarProject.ViewModels
{
    public class CalendarioViewModel:ViewModelBase
    {
        RepositorioCalendario repo;

        public CalendarioViewModel(RepositorioCalendario repo)
        {
            this.repo = repo;
            Task.Run(async()=> await CargarEventos());
        }
        public async Task CargarEventos()
        {
            List<Eventos> evento = await repo.EventoUsuario(1);
            Eventos = new ObservableCollection<Eventos>(evento);
        }
        private ObservableCollection<Eventos> _Eventos;
        public ObservableCollection<Eventos> Eventos
        {
            get { return _Eventos; }
            set
            {
                _Eventos = value;
                OnPropertyChanged("Eventos");
            }
        }
    }
}

using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class MainWindowVM : ObservableObject
    {
        private List<Superheroe> heroes;
        private ListaSuperheroesService servicioheroes;

        private Superheroe _heroeActual;

        public Superheroe HeroeActual
        {
            get { return _heroeActual; }
            set 
            { 
                SetProperty(ref _heroeActual, value);
            }
        }

        private int _total;

        public int Total
        {
            get { return _total; }
            set 
            { 
                SetProperty(ref _total, value);
            }
        }

        private int _actual;

        public int Actual
        {
            get { return _actual; }
            set 
            { 
                SetProperty(ref _actual, value);
            }
        }


        public MainWindowVM()
        {
            servicioheroes = new ListaSuperheroesService();
            heroes = servicioheroes.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
        }

        public void Siguiente()
        { 
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual-1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual-1];
            }
        }
    }
}

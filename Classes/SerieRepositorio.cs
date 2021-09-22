using System;
using DIO.FPROJ.Interfaces;
using System.Collections.Generic;


namespace DIO.FPROJ
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return this.listaSerie.Count;
        }

        public Serie RetornaPorID(int id)
        {
            return listaSerie[id];
        }
    }
}
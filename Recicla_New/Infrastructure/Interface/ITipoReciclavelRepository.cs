using Domain.Entities;
using System;

namespace Infrastructure.Interface
{

    public interface ITipoReciclavelRepository
    {
        public TipoReciclavel GetTipoReciclavel(int id);
        public List<TipoReciclavel> GetTiposReciclaveis();
        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel);
        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel);
        public void DeleteTipoReciclavel(TipoReciclavel tipoReciclavel);
    }
}

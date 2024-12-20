﻿using System;
using Domain.Entities;

namespace Infrastructure.Interface
{

    public interface IVeiculoRepository
    {

        public Veiculo GetVeiculo(int id);
        public List<Veiculo> GetVeiculos();
        public void InsertVeiculo(Veiculo veiculo);
        public void UpdateVeiculo(Veiculo veiculo);
        public void DeleteVeiculo(int id);

    }
}


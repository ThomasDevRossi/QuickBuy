﻿using System;

namespace QuickBuy.Repositorio
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        TEntity ObterPorId(int id);
        IEquatable<TEntity> ObterTodos();

    }
}

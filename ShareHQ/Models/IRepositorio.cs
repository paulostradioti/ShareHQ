﻿using System.Collections.Generic;
using System.Linq;

namespace ShareHQ.Models
{
    public interface IRepositorio
    {
        #region [Usuário]

        IQueryable<Usuario> Usuarios { get; }

        void AdicionaUsuario(Usuario usuario);

        void UpdateUsuario(Usuario usuario);

        void RemoveUsuario(Usuario usuario);

        #endregion [Usuário]

        #region [Categoria]

        Categoria GetCategoriaById(int Id);

        List<Categoria> GetCategorias();

        IQueryable<Categoria> Categorias { get; }

        void AdicionaCategoria(Categoria categoria);

        void UpdateCategoria(Categoria categoria);

        void RemoveCategoria(Categoria categoria);

        #endregion [Categoria]

        #region [Item]

        Item GetItemById(int Id);

        List<Item> GetItens();

        void AddItem(Item item);

        void UpdateItem(Item item);

        void RemoveItem(Item item);

        #endregion [Item]

        #region [ItemEmpresatdo]

        ItemEmprestado GetEmprestadoById(int Id);

        List<ItemEmprestado> GetEmprestado();

        void Add(ItemEmprestado itensEmprestado);

        void Update(ItemEmprestado itensEmprestado);

        void Remove(ItemEmprestado itensEmprestado);

        #endregion [ItemEmpresatdo]
    }
}
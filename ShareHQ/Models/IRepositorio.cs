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
        #endregion

        #region [Categoria]
        Categoria GetCategoriaById(int Id);

        List<Categoria> GetCategorias();
        IQueryable<Categoria> Categorias { get; }
        void AdicionaCategoria(Categoria categoria);
        void UpdateCategoria(Categoria categoria);
        void RemoveCategoria(Categoria categoria);
        #endregion
    }

}
using System;
using MiAppHexagonal.Domain.Entities;

namespace MiAppHexagonal.Domain.Ports;
public interface IGenericRepository<T>
    {
        List<T> ObtenerTodos();
        void Crear(T entity);
        void Actualizar(T entity);
        void Eliminar(int id);
    }
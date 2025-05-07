using System;
using MiAppHexagonal.Domain.Factory;
using MiAppHexagonal.Domain.Ports;
using MiAppHexagonal.Infrastructure.Repositories;

namespace MiAppHexagonal.Infrastructure.Pgsql;

public class NpgsqlgDbFactory : IDbFactory
{
    private readonly string _connectionString;

    public NpgsqlgDbFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IClienteRepository CrearClienteRepository()
    {
        return new lmpClienteRepository(_connectionString);
    }

    public IProductoRepository CrearProductoRepository()
    {
        return new ProductoRepository(_connectionString);
    }
}
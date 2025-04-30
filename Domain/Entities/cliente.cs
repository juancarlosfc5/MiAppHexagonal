using System;

namespace MiAppHexagonal.Domain.Entities;

public class Cliente
{
    public int Id { get; set; }
    public string? Nombre { get; set; }

    // Asociacion simple con Direccion (1:1)
    public string? Direccion { get; set; }

    // Agregacion: un cliente puede tener varios pedidos
    public List<Pedido>? Pedidos { get; set; } = new();
}
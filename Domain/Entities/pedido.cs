using System;

namespace MiAppHexagonal.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }

    // Composicion con DEtalles
    /*Agregagacion (1:N): Pedido
        Un cliente tiene multiples pedidos. Si el cliente se elimina, los pedidos podrian
        seguir existiendo si hay logica para migrarlos o archivarlos.
    */
    public List<DetallePedido>? Detalles { get; set; }
}
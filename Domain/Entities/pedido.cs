using System;

namespace MiAppHexagonal.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }

    // Composición con Detalles
    /*Agregación (1:N): Pedido
        Un cliente tiene múltiples pedidos. Si el cliente se elimina, los pedidos podrían 
        seguir existiendo si hay lógica para migrarlos o archivarlos.
    */
    public List<DetallePedido>? Detalles { get; set; }
}
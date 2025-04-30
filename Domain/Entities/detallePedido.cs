using System;

namespace MiAppHexagonal.Domain.Entities;

/*Composicion (Pedido -> DetallePedido)
La clase DetallePedido no puede existir sin Pedido, por eso usamos composicion.*/
public class DetallePedido
{
    public int ProductoId { get; set; }
    public string? NombreProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Total => Cantidad * PrecioUnitario;
}
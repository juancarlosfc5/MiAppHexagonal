using System;

namespace MiAppHexagonal.Domain.Entities;
public class Direccion
{
    /*
    Asociacion (1:1) Direccion
    Relacion de asociacion simple. Cliente tiene una referencia a Direccion,
    pero esta puede existir por si sola.
    */
    public int Id { get; set; }
    public string? Ciudad { get; set; }
    public string? Calle { get; set; }
    public string? CodigoPostal { get; set; }
}
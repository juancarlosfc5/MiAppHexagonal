﻿using MiAppHexagonal.Application.Services;
using MiAppHexagonal.Application.UI.Clientes;
using MiAppHexagonal.Application.UI.Principal;
using MiAppHexagonal.Domain.Entities;
using MiAppHexagonal.Domain.Factory;
using MiAppHexagonal.Infrastructure.Mysql;

internal class Program
{
    private static void Main(string[] args)
    {
        string connStr = "server=localhost;database=introcsharp;user=root;password=Elise567*;";
        IDbFactory factory = new MySqlDbFactory(connStr);
        UIPrincipal UIPrincipal = new UIPrincipal(factory);
        UIPrincipal.MostrarMenu();     
    }
}
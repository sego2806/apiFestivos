﻿using apiFestivos.Dominio.Entidades;
using apiFestivos.Dominio.DTOs;


namespace apiFestivos.Core.Interfaces.Repositorios
{
    public interface IFestivoRepositorio
    {
        Task<IEnumerable<Festivo>> ObtenerTodos();

        Task<Festivo> Obtener(int Id);

        Task<IEnumerable<Festivo>> Buscar(string Dato);

        Task<Festivo> Agregar(Festivo Festivo);

        Task<Festivo> Modificar(Festivo Festivo);

        Task<bool> Eliminar(int Id);
        Task<IEnumerable<FechaFestivo>> ObtenerAño(int año);

    }
}

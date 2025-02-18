﻿namespace PeliculasAPI.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task<string> GuardarArchivos(byte[] contenido, string extension, string contenedor, string contentType);
        Task<string> EditarArchivos(byte[] contenido, string extension, string contenedor, string ruta, string contentType);
        Task BorrarArchivo(string ruta, string contenedor);
    }
}

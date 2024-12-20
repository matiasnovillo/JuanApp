using JuanApp.Areas.JuanApp.Entities;
using System.Data;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp.Areas.JuanApp.Interfaces
{
    public interface IProductoService
    {
        void ExportToExcel(string path, DataTable dtProducto);

        void ExportToCSV(string path, List<Producto> lstProducto);

        void ExportToPDF(string path, List<Producto> lstProducto);

        List<Producto> ImportExcel(string path, int userId);
    }
}
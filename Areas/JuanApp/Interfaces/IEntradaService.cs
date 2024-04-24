using System.Data;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Library;

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
    public interface IEntradaService
    {
        #region Exportations
        DateTime ExportAsPDF(Ajax Ajax, string ExportationType);

        DateTime ExportAsExcel(List<Entrada> lstEntrada, Ajax Ajax, string ExportationType, string pathToSave);

        DateTime ExportAsCSV(Ajax Ajax, string ExportationType);
        #endregion
    }
}

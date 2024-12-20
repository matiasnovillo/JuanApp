using System.Data;
using System.Globalization;
using ClosedXML.Excel;
using CsvHelper;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Library;
using JuanApp.DatabaseContexts;

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

namespace JuanApp.Areas.JuanApp.Services
{
    public class SalidaService : ISalidaService
    {
        protected readonly JuanAppContext _context;

        public SalidaService(JuanAppContext context)
        {
            _context = context;
        }

        #region Exportations
        public DateTime ExportAsPDF(Ajax Ajax, string ExportationType)
        {
            throw new NotImplementedException();
        }

        public DateTime ExportAsExcel(List<Salida> lstSalida, Ajax Ajax, string ExportationType, string pathToSave)
        {
            DateTime Now = DateTime.Now;

            using var Book = new XLWorkbook();

            if (ExportationType == "All")
            {
                DataTable dtSalida = new();

                //We define another DataTable dtSalidaCopy to avoid issue related to DateTime conversion
                DataTable dtSalidaCopy = new();

                #region Define columns for dtSalidaCopy
                DataColumn dtColumnSalidaIdFordtSalidaCopy = new DataColumn();
                    dtColumnSalidaIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSalidaIdFordtSalidaCopy.ColumnName = "SalidaId";
                    dtSalidaCopy.Columns.Add(dtColumnSalidaIdFordtSalidaCopy);

                    DataColumn dtColumnActiveFordtSalidaCopy = new DataColumn();
                    dtColumnActiveFordtSalidaCopy.DataType = typeof(string);
                    dtColumnActiveFordtSalidaCopy.ColumnName = "Active";
                    dtSalidaCopy.Columns.Add(dtColumnActiveFordtSalidaCopy);

                    DataColumn dtColumnDateTimeCreationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeCreationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeCreationFordtSalidaCopy.ColumnName = "DateTimeCreation";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeCreationFordtSalidaCopy);

                    DataColumn dtColumnDateTimeLastModificationFordtSalidaCopy = new DataColumn();
                    dtColumnDateTimeLastModificationFordtSalidaCopy.DataType = typeof(string);
                    dtColumnDateTimeLastModificationFordtSalidaCopy.ColumnName = "DateTimeLastModification";
                    dtSalidaCopy.Columns.Add(dtColumnDateTimeLastModificationFordtSalidaCopy);

                    DataColumn dtColumnUserCreationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserCreationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserCreationIdFordtSalidaCopy.ColumnName = "UserCreationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserCreationIdFordtSalidaCopy);

                    DataColumn dtColumnUserLastModificationIdFordtSalidaCopy = new DataColumn();
                    dtColumnUserLastModificationIdFordtSalidaCopy.DataType = typeof(string);
                    dtColumnUserLastModificationIdFordtSalidaCopy.ColumnName = "UserLastModificationId";
                    dtSalidaCopy.Columns.Add(dtColumnUserLastModificationIdFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeClienteFordtSalidaCopy.ColumnName = "CodigoDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeClienteFordtSalidaCopy);

                    DataColumn dtColumnNombreDeClienteFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeClienteFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeClienteFordtSalidaCopy.ColumnName = "NombreDeCliente";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeClienteFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeProductoFordtSalidaCopy.ColumnName = "CodigoDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeProductoFordtSalidaCopy);

                    DataColumn dtColumnNombreDeProductoFordtSalidaCopy = new DataColumn();
                    dtColumnNombreDeProductoFordtSalidaCopy.DataType = typeof(string);
                    dtColumnNombreDeProductoFordtSalidaCopy.ColumnName = "NombreDeProducto";
                    dtSalidaCopy.Columns.Add(dtColumnNombreDeProductoFordtSalidaCopy);

                    DataColumn dtColumnKilosRealesFordtSalidaCopy = new DataColumn();
                    dtColumnKilosRealesFordtSalidaCopy.DataType = typeof(string);
                    dtColumnKilosRealesFordtSalidaCopy.ColumnName = "KilosReales";
                    dtSalidaCopy.Columns.Add(dtColumnKilosRealesFordtSalidaCopy);

                    DataColumn dtColumnPrecioFordtSalidaCopy = new DataColumn();
                    dtColumnPrecioFordtSalidaCopy.DataType = typeof(string);
                    dtColumnPrecioFordtSalidaCopy.ColumnName = "Precio";
                    dtSalidaCopy.Columns.Add(dtColumnPrecioFordtSalidaCopy);

                    DataColumn dtColumnSubtotalFordtSalidaCopy = new DataColumn();
                    dtColumnSubtotalFordtSalidaCopy.DataType = typeof(string);
                    dtColumnSubtotalFordtSalidaCopy.ColumnName = "Subtotal";
                    dtSalidaCopy.Columns.Add(dtColumnSubtotalFordtSalidaCopy);

                    DataColumn dtColumnCodigoDeBarraFordtSalidaCopy = new DataColumn();
                    dtColumnCodigoDeBarraFordtSalidaCopy.DataType = typeof(string);
                    dtColumnCodigoDeBarraFordtSalidaCopy.ColumnName = "CodigoDeBarra";
                    dtSalidaCopy.Columns.Add(dtColumnCodigoDeBarraFordtSalidaCopy);

                    
                #endregion

                #region Create another DataTable to copy
                List<Salida> lstSalidaAll = _context.Salida.ToList();

                DataTable DataTable = new();
                DataTable.Columns.Add("SalidaId", typeof(string));
                DataTable.Columns.Add("Active", typeof(string));
                DataTable.Columns.Add("DateTimeCreation", typeof(string));
                DataTable.Columns.Add("DateTimeLastModification", typeof(string));
                DataTable.Columns.Add("UserCreationId", typeof(string));
                DataTable.Columns.Add("UserLastModificationId", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeProducto", typeof(string));
                DataTable.Columns.Add("NombreDeProducto", typeof(string));
                DataTable.Columns.Add("KilosReales", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));
                DataTable.Columns.Add("CodigoDeBarra", typeof(string));
                

                foreach (Salida salida in lstSalidaAll)
                        {
                            DataTable.Rows.Add(
                                salida.SalidaId,
                        salida.Active,
                        salida.DateTimeCreation,
                        salida.DateTimeLastModification,
                        salida.UserCreationId,
                        salida.UserLastModificationId,
                        salida.CodigoDeCliente,
                        salida.NombreDeCliente,
                        salida.CodigoDeProducto,
                        salida.NombreDeProducto,
                        salida.KilosReales,
                        salida.Precio,
                        salida.Subtotal,
                        salida.NroDePesaje
                        
                                );
                        }
                #endregion

                dtSalida = DataTable;

                foreach (DataRow DataRow in dtSalida.Rows)
                {
                    dtSalidaCopy.Rows.Add(DataRow.ItemArray);
                }

                var Sheet = Book.Worksheets.Add(dtSalidaCopy);

                Sheet.ColumnsUsed().AdjustToContents();

                Book.SaveAs($@"wwwroot/ExcelFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                DataSet dsSalida = new();

                //We define another DataTable dtSalidaCopy to avoid issue related to DateTime conversion
                DataTable dtSalidaCopy = new();

                #region Define columns for dtSalidaCopy
                DataColumn dtColumnSalidaIdFordtSalidaCopy = new DataColumn();
                dtColumnSalidaIdFordtSalidaCopy.DataType = typeof(string);
                dtColumnSalidaIdFordtSalidaCopy.ColumnName = "SalidaId";
                dtSalidaCopy.Columns.Add(dtColumnSalidaIdFordtSalidaCopy);

                DataColumn dtColumnCodigoDeBarraFordtSalidaCopy = new DataColumn();
                dtColumnCodigoDeBarraFordtSalidaCopy.DataType = typeof(string);
                dtColumnCodigoDeBarraFordtSalidaCopy.ColumnName = "CodigoDeBarra";
                dtSalidaCopy.Columns.Add(dtColumnCodigoDeBarraFordtSalidaCopy);

                DataColumn dtColumnCodigoDeClienteFordtSalidaCopy = new DataColumn();
                dtColumnCodigoDeClienteFordtSalidaCopy.DataType = typeof(string);
                dtColumnCodigoDeClienteFordtSalidaCopy.ColumnName = "CodigoDeCliente";
                dtSalidaCopy.Columns.Add(dtColumnCodigoDeClienteFordtSalidaCopy);

                DataColumn dtColumnNombreDeClienteFordtSalidaCopy = new DataColumn();
                dtColumnNombreDeClienteFordtSalidaCopy.DataType = typeof(string);
                dtColumnNombreDeClienteFordtSalidaCopy.ColumnName = "NombreDeCliente";
                dtSalidaCopy.Columns.Add(dtColumnNombreDeClienteFordtSalidaCopy);

                DataColumn dtColumnCodigoDeProductoFordtSalidaCopy = new DataColumn();
                dtColumnCodigoDeProductoFordtSalidaCopy.DataType = typeof(string);
                dtColumnCodigoDeProductoFordtSalidaCopy.ColumnName = "CodigoDeProducto";
                dtSalidaCopy.Columns.Add(dtColumnCodigoDeProductoFordtSalidaCopy);

                DataColumn dtColumnNombreDeProductoFordtSalidaCopy = new DataColumn();
                dtColumnNombreDeProductoFordtSalidaCopy.DataType = typeof(string);
                dtColumnNombreDeProductoFordtSalidaCopy.ColumnName = "NombreDeProducto";
                dtSalidaCopy.Columns.Add(dtColumnNombreDeProductoFordtSalidaCopy);

                DataColumn dtColumnKilosRealesFordtSalidaCopy = new DataColumn();
                dtColumnKilosRealesFordtSalidaCopy.DataType = typeof(string);
                dtColumnKilosRealesFordtSalidaCopy.ColumnName = "KilosReales";
                dtSalidaCopy.Columns.Add(dtColumnKilosRealesFordtSalidaCopy);

                DataColumn dtColumnPrecioFordtSalidaCopy = new DataColumn();
                dtColumnPrecioFordtSalidaCopy.DataType = typeof(string);
                dtColumnPrecioFordtSalidaCopy.ColumnName = "Precio";
                dtSalidaCopy.Columns.Add(dtColumnPrecioFordtSalidaCopy);

                DataColumn dtColumnSubtotalFordtSalidaCopy = new DataColumn();
                dtColumnSubtotalFordtSalidaCopy.DataType = typeof(string);
                dtColumnSubtotalFordtSalidaCopy.ColumnName = "Subtotal";
                dtSalidaCopy.Columns.Add(dtColumnSubtotalFordtSalidaCopy);
                #endregion

                dsSalida.Tables.Add(dtSalidaCopy);

                #region Create another DataTable to copy

                DataTable DataTable = new();
                DataTable.Columns.Add("SalidaId", typeof(string));
                DataTable.Columns.Add("CodigoDeBarra", typeof(string));
                DataTable.Columns.Add("CodigoDeCliente", typeof(string));
                DataTable.Columns.Add("NombreDeCliente", typeof(string));
                DataTable.Columns.Add("CodigoDeProducto", typeof(string));
                DataTable.Columns.Add("NombreDeProducto", typeof(string));
                DataTable.Columns.Add("KilosReales", typeof(string));
                DataTable.Columns.Add("Precio", typeof(string));
                DataTable.Columns.Add("Subtotal", typeof(string));



                foreach (Salida salida in lstSalida)
                {
                    DataTable.Rows.Add(
                        salida.SalidaId,
                        salida.NroDePesaje,
                        salida.CodigoDeCliente,
                        salida.NombreDeCliente,
                        salida.CodigoDeProducto,
                        salida.NombreDeProducto,
                        salida.KilosReales,
                        salida.Precio,
                        salida.Subtotal);
                }
                #endregion

                dtSalidaCopy = DataTable;

                foreach (DataRow DataRow in dtSalidaCopy.Rows)
                {
                    dsSalida.Tables[0].Rows.Add(DataRow.ItemArray);
                }

                for (int i = 0; i < dsSalida.Tables.Count; i++)
                {
                    var Sheet = Book.Worksheets.Add(dsSalida.Tables[i]);
                    Sheet.ColumnsUsed().AdjustToContents();
                }
                Book.SaveAs($@"{pathToSave}/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.xlsx");
            }
            return Now;
        }

        public DateTime ExportAsCSV(Ajax Ajax, string ExportationType)
        {
            DateTime Now = DateTime.Now;
            List<Salida> lstSalida = new List<Salida> { };

            if (ExportationType == "All")
            {
                lstSalida = _context.Salida.ToList();
            }
            else
            {
                string[] RowsChecked = Ajax.AjaxForString.Split(',');

                foreach (string RowChecked in RowsChecked)
                {
                    Salida Salida = _context.Salida
                                            .Where(x => x.SalidaId == Convert.ToInt32(RowChecked))
                                            .FirstOrDefault();      
                    lstSalida.Add(Salida);
                }
            }

            using (var Writer = new StreamWriter($@"wwwroot/CSVFiles/JuanApp/Salida/Salida_{Now.ToString("yyyy_MM_dd_HH_mm_ss_fff")}.csv"))
            using (var CsvWriter = new CsvWriter(Writer, CultureInfo.InvariantCulture))
            {
                CsvWriter.WriteRecords(lstSalida);
            }

            return Now;
        }
        #endregion
    }
}
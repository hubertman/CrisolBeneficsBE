using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.APIBusiness.DBContext.Interface;
using UPC.APIBusiness.DBEntity.Model;

namespace DBContext
{
    public class TicketRepository : BaseRepository, ITicketRepository
    {
        public EntityBaseResponse GetTicketId(int id)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var ticket = new List<EntityTicket>();
                    const string sql = "usp_ListarTicketsPorUsuario";
                    var p = new DynamicParameters();
                    p.Add(name: "@Id_Usuario", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    ticket = db.Query<EntityTicket>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (ticket.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = ticket;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = null;
                    }

                }
            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.ErrorCode = "0001";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }
            return response;
        }

        public EntityBaseResponse PutTicket(string Codigo_QR, DateTime Fecha_de_generacion, string Estado,
            DateTime Fecha_de_vencimiento, int Id_Oferta, int Id_Usuario, int Id_Evento)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var ticket = new List<EntityTicket>();
                    const string sql = "usp_InsertarTicket";
                    var p = new DynamicParameters();
                    p.Add(name: "@Codigo_QR", value: Codigo_QR, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Fecha_de_generacion", value: Fecha_de_generacion, dbType: DbType.Date, direction: ParameterDirection.Input);
                    p.Add(name: "@Estado", value: Estado, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Fecha_de_vencimiento", value: Fecha_de_vencimiento, dbType: DbType.Date, direction: ParameterDirection.Input);
                    p.Add(name: "@Id_Oferta", value: Id_Oferta, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@Id_Usuario", value: Id_Usuario, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@Id_Evento", value: Id_Evento, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    ticket = db.Query<EntityTicket>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (ticket.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = ticket;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = null;
                    }

                }
            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.ErrorCode = "0001";
                response.ErrorMessage = ex.Message;
                response.Data = null;
            }
            return response;
        }
    }
}

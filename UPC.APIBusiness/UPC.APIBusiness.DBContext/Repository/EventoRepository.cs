using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public class EventoRepository : BaseRepository, IEventoRepository
    {
        public EntityBaseResponse GetEventoId(int id)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var eventos = new List<EntityEvento>();
                    const string sql = "usp_ObtenerEventoPorId";
                    var p = new DynamicParameters();
                    p.Add(name: "@Id_evento", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    eventos = db.Query<EntityEvento>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (eventos.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = eventos;
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

        public EntityBaseResponse GetEventos() {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var eventos = new List<EntityEvento>();
                    const string sql = "usp_ListarEventos";
                    eventos = db.Query<EntityEvento>(
                        sql: sql,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (eventos.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = eventos;
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

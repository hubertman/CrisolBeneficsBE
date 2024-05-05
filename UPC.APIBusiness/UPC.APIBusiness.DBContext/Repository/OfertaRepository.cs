using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.APIBusiness.DBEntity.Model;

namespace DBContext
{
    public class OfertaRepository : BaseRepository, IOfertaRepository
    {
        public EntityBaseResponse GetOfertaId(int id)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var eventos = new List<EntityOferta>();
                    const string sql = "usp_ObtenerOfertaPorId";
                    var p = new DynamicParameters();
                    p.Add(name: "@Id_oferta", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    eventos = db.Query<EntityOferta>(
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

        public EntityBaseResponse GetOfertas()
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var eventos = new List<EntityOferta>();
                    const string sql = "usp_ListarOfertas";
                    eventos = db.Query<EntityOferta>(
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

using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.APIBusiness.DBContext.Interface;

namespace DBContext
{
    public class AhorroRepository : BaseRepository, IAhorroRepository
    {
        public EntityBaseResponse GetAhorroUsuario(int usuarioid)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var ahorro = new List<EntityAhorro>();
                    const string sql = "usp_ListarAhorros";
                    var p = new DynamicParameters();
                    p.Add(name: "@Id_Usuario", value: usuarioid, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    ahorro = db.Query<EntityAhorro>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (ahorro.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = ahorro;
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

        public EntityBaseResponse UpdateAhorroUsuario(int usuarioid, double ahorr)
        {
            var response = new EntityBaseResponse();
            try
            {
                using (var db = GetSqlConnection())
                {
                    var ahorro = new List<EntityAhorro>();
                    const string sql = "usp_GuardarAhorro";
                    var p = new DynamicParameters();
                    p.Add(name: "@Id_Usuario", value: usuarioid, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    p.Add(name: "@Monto_Ahorrado", value: ahorr, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    ahorro = db.Query<EntityAhorro>(
                        sql: sql,
                        param: p,
                        commandType: CommandType.StoredProcedure
                        ).ToList();
                    if (ahorro.Count > 0)
                    {
                        response.IsSuccess = true;
                        response.ErrorCode = "0000";
                        response.ErrorMessage = string.Empty;
                        response.Data = ahorro;
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

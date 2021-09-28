using System.Data;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace CodeCompanion
{
    public static class NpgsqlConnectionExtensions
    {
        public static Refcursors QueryRefcursors(this NpgsqlConnection connection, NpgsqlTransaction transaction, string functionName, object param = null) =>
            new(connection, transaction, connection.Query<string>(functionName, transaction: transaction, param: param, commandType: CommandType.StoredProcedure).GetEnumerator());

        public static async Task<Refcursors> QueryRefcursorsAsync(this NpgsqlConnection connection, NpgsqlTransaction transaction, string functionName, object param = null) =>
            new(connection, transaction, (await connection.QueryAsync<string>(functionName, transaction: transaction, param: param, commandType: CommandType.StoredProcedure)).GetEnumerator());
    }
}
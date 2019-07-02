using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChepeauModel;

namespace ChepeauDAL
{
    public class Table_DAO : Base
    {
        public void UpdateRecord(Table table)
        {
            string query = "UPDATE [Table] SET [Status]=' + table.Status.ToString() + ' WHERE TableID=" + table.TableNumber  + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Table> Db_Get_All_Tables()
        {
            string query = "SELECT TableID, Status FROM [Table] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Table GetTable(int TableNumber)
        {
            string query = $"SELECT TableID, Status FROM [Table] where TableID = {TableNumber} ";
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return FindTable(ExecuteSelectQuery(query, sqlParameter));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table((int)dr["TableID"], (Enum_TableStatus)Enum.Parse(typeof(Enum_TableStatus), (string)dr["Status"], true));
                tables.Add(table);
            }
            return tables;
        }
        private Table FindTable(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table((int)dr["TableID"], (Enum_TableStatus)Enum.Parse(typeof(Enum_TableStatus), (string)dr["Status"], true));
                tables.Add(table);
            }
            return tables[0];
        }
    }
}

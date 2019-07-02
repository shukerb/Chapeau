using System;
using System.Collections.Generic;
using ChepeauDAL;
using ChepeauModel;

namespace ChepeauLogic
{
    public class Table_Service
    {
        Table_DAO Table_DB = new Table_DAO();

        //to get all the Tables
        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = Table_DB.Db_Get_All_Tables();
                return tables;

            }
            catch (Exception)
            {

                throw new Exception("System couldn't connect to the database");
            }
        }

        //To get a specific Table
        public Table GetTable(int TableNumber)
        {
            try
            {
                Table table = Table_DB.GetTable(TableNumber);
                return table;
            }
            catch (Exception)
            {

                throw new Exception("The system couldn't connect to the database");
            }
        }
        //change the Status of the table
        public void updateTable(Table table)
        {
            Table_DB.UpdateRecord(table);
        }
    }
}

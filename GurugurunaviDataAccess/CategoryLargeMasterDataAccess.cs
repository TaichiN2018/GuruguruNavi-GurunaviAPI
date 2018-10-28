using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class CategoryLargeMasterDataAccess
    {
        public void CreateTable()
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS MASTER_CATEGORY_LARGE("
                        + "category_l_code STRING NOT NULL PRIMARY KEY,"
                        + "category_l_name STRING NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void DropTable()
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText =
                        "DROP TABLE IF EXISTS MASTER_CATEGORY_LARGE";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void RecreateTable(CategoryLargeMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        private void InsertData(CategoryLargeMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (CategoryL cl in dc.category_l)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_CATEGORY_LARGE(category_l_code, category_l_name) VALUES(" +
                            $"'{cl.category_l_code}', '{cl.category_l_name}')";
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
    }
}

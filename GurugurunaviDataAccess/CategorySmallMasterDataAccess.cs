using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class CategorySmallMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_CATEGORY_SMALL("
                        + "category_s_code STRING NOT NULL PRIMARY KEY,"
                        + "category_s_name STRING NOT NULL,"
                        + "category_l_code STRING NOT NULL)";
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
                        "DROP TABLE IF EXISTS MASTER_CATEGORY_SMALL";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void RecreateTable(CategorySmallMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        private void InsertData(CategorySmallMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (Category c in dc.category_s)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_CATEGORY_SMALL(category_s_code, category_s_name, category_l_code) VALUES(" +
                            $"'{c.category_s_code}', '{c.category_s_name}', '{c.category_l_code}')";
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

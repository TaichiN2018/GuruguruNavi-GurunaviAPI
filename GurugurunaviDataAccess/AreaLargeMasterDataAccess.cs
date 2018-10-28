using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class AreaLargeMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA_LARGE("
                        + "areacode_l STRING NOT NULL PRIMARY KEY,"
                        + "areaname_l STRING NOT NULL)";
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
                        "DROP TABLE IF EXISTS MASTER_AREA_LARGE";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void RecreateTable(AreaLargeMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }
        private void InsertData(AreaLargeMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (GareaLarge a in dc.garea_large)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_AREA_LARGE(areacode_l, areaname_l) VALUES(" +
                            $"'{a.areacode_l}', '{a.areaname_l}')";
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

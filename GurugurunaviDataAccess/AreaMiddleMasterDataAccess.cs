using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class AreaMiddleMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA_MIDDLE("
                        + "areacode_m STRING NOT NULL PRIMARY KEY,"
                        + "areaname_m STRING NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                finally {
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
                        "DROP TABLE IF EXISTS MASTER_AREA_MIDDLE";
                    cmd.ExecuteNonQuery();
                }
                finally {
                    con.CloseConnection();
                }
            }
        }

        public void RecreateTable(AreaMiddleMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        private void InsertData(AreaMiddleMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (GareaMiddle a in dc.garea_middle)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_AREA_MIDDLE(areacode_m, areaname_m) VALUES(" +
                            $"'{a.areacode_m}', '{a.areaname_m}')";
                        cmd.ExecuteNonQuery();
                    }
                }
                finally {
                    con.CloseConnection();
                }
            }
        }
    }
}

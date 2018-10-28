using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class AreaRegionMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA_REGION("
                        + "area_code STRING NOT NULL PRIMARY KEY,"
                        + "area_name STRING NOT NULL)";
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
                        "DROP TABLE IF EXISTS MASTER_AREA_REGION";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void RecreateTable(AreaRegionMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        private void InsertData(AreaRegionMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (Area a in dc.area)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_AREA_REGION(area_code, area_name) VALUES(" +
                            $"'{a.area_code}', '{a.area_name}')";
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void SelectData(AreaRegionMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    //MASTER(AREA)
                    cmd.CommandText = "SELECT * FROM MASTER_AREA_REGION";

                    SQLiteDataReader resultReader = cmd.ExecuteReader();
                    try
                    {
                        while (resultReader.Read())
                        {
                            Area a = new Area() { };
                            dc.area.Add(a);
                            a.area_code = resultReader["area_code"].ToString();
                            a.area_name = resultReader["area_name"].ToString();
                        }
                    }
                    finally
                    {
                        resultReader.Close();
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

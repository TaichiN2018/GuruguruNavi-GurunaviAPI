using System.Collections.Generic;
using System.Data.SQLite;
using GNaviDataClass;

namespace GNaviDataAccess
{
    public class AreaSmallMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA_SMALL("
                        + "areacode_s STRING NOT NULL PRIMARY KEY,"
                        + "areaname_s STRING NOT NULL)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS MASTER_RELATION_SMALL_PREF("
                        + "areaSCode STRING NOT NULL,"
                        + "prefCode STRING NOT NULL,"
                        + "PRIMARY KEY(areaSCode, prefCode))";
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
                        "DROP TABLE IF EXISTS MASTER_AREA_SMALL";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "DROP TABLE IF EXISTS MASTER_RELATION_SMALL_PREF";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void RecreateTable(AreaSmallMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        private void InsertData(AreaSmallMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (GareaSmall a in dc.garea_small)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_AREA_SMALL(areacode_s, areaname_s) VALUES(" +
                            $"'{a.areacode_s}', '{a.areaname_s}')";
                        cmd.ExecuteNonQuery();
                    }
                    foreach (GareaSmall a in dc.garea_small)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_RELATION_SMALL_PREF(areaSCode, prefCode) VALUES(" +
                            $"'{a.areacode_s}', '{a.pref.pref_code}')";
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void GetAreaSmallCode(IEnumerable<string> areaCodeSList)
        {
            List<string> listACS = (List<string>)areaCodeSList;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();

                    cmd.CommandText = "SELECT areacode_s FROM MASTER_AREA_SMALL";
                    SQLiteDataReader sqlitedr = cmd.ExecuteReader();
                    while (sqlitedr.Read() == true)
                    {
                        listACS.Add(sqlitedr["areacode_s"].ToString());
                    }
                    sqlitedr.Close();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void GetAreaSmallData(string prefCode, AreaSmallMasterDataClass dcSmall)
        {
            List<GareaSmall> listACS = dcSmall.garea_small;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();

                    cmd.CommandText = "SELECT * FROM MASTER_AREA_SMALL as tblS LEFT OUTER JOIN MASTER_RELATION_SMALL_PREF as tblR ON tblS.areacode_s = tblR.areaSCode WHERE tblR.prefCode = :prefCode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("prefCode", System.Data.DbType.String).Value = prefCode;
                    SQLiteDataReader sqlitedr = cmd.ExecuteReader();
                    while (sqlitedr.Read() == true)
                    {
                        GareaSmall s = new GareaSmall();
                        listACS.Add(s);
                        s.areacode_s = sqlitedr["areacode_s"].ToString();
                        s.areaname_s = sqlitedr["areaname_s"].ToString();
                    }
                    sqlitedr.Close();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
    }
}

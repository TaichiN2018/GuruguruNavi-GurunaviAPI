using System.Collections.Generic;
using System.Data.SQLite;
using GNaviDataClass;


namespace GNaviDataAccess
{
    public class AreaPrefMasterDataAccess
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
                        "CREATE TABLE IF NOT EXISTS MASTER_AREA_PREF("
                        + "pref_code STRING NOT NULL PRIMARY KEY,"
                        + "pref_name STRING NOT NULL)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS MASTER_RELATION_REGION_PREF("
                        + "pref_code STRING NOT NULL,"
                        + "area_code STRING NOT NULL,"
                        + "PRIMARY KEY (pref_code, area_code))";
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
                        "DROP TABLE IF EXISTS MASTER_AREA_PREF";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "DROP TABLE IF EXISTS MASTER_RELATION_REGION_PREF";
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public void RecreateTable(AreaPrefMasterDataClass dc)
        {
            DropTable();
            CreateTable();
            InsertData(dc);
        }

        public void InsertData(AreaPrefMasterDataClass dc)
        {
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    foreach (Pref p in dc.pref)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_AREA_PREF(pref_code, pref_name) VALUES(" +
                            $"'{p.pref_code}', '{p.pref_name}')";
                        cmd.ExecuteNonQuery();
                    }
                    foreach (Pref p in dc.pref)
                    {
                        cmd.CommandText = "INSERT INTO MASTER_RELATION_REGION_PREF(pref_code, area_code) VALUES(" +
                            $"'{p.pref_code}', '{p.area_code}')";
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        public string SelectPrefName(string prefCode)
        {
            string prefName = string.Empty;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText =
                        string.Format("SELECT FROM MASTER_AREA_PREF WHERE pref_code = {0}", prefCode);
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        prefName = rdr["pref_name"].ToString();
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
            return prefName;
        }

        public void SelectAllPrefCode(IEnumerable<string> prefcodeList)
        {
            List<string> pcList = (List<string>)prefcodeList;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText = "SELECT * FROM MASTER_AREA_PREF";
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        pcList.Add(rdr["pref_code"].ToString());
                    }
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }
        public void SelectPrefDatas(string regionCode, AreaPrefMasterDataClass dcPref)
        {
            List<Pref> pcList = dcPref.pref;
            var con = new GNDBConnector();
            using (var cmd = new SQLiteCommand(con.SLConnect))
            {
                try
                {
                    con.OpenConnection();
                    cmd.CommandText = "SELECT * FROM MASTER_AREA_PREF as tblP LEFT OUTER JOIN MASTER_RELATION_REGION_PREF as tblR ON tblP.pref_code = tblR.pref_code WHERE tblR.area_code = :area_code";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("area_code", System.Data.DbType.String).Value = regionCode;
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Pref p = new Pref() { };
                        pcList.Add(p);
                        p.pref_code = rdr["pref_code"].ToString();
                        p.pref_name = rdr["pref_name"].ToString();
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
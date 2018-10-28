//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

using System.Data.SQLite;

namespace GNaviDataAccess
{
    public class GNDBConnector
    {
        private const string DB_FILE_PATH = "GuruguruNavi.db";

        private SQLiteConnection _connection;
        private SQLiteConnection GetConnection()
        {
            if (_connection == null)
            {
                var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "GuruguruNavi.db" };
                _connection = new SQLiteConnection(sqlConnectionSb.ToString());
            }

            return _connection;

        }
        public SQLiteConnection SLConnect
        {
            get { return GetConnection(); }
            private set {; }
        }

        public void OpenConnection() {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection() {
            this._connection.Close();
        }
    }
}

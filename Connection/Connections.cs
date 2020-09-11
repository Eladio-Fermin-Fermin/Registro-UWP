using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Connections : DataConnection
    {
        public Connections() : base(new SqlServerDataProvider("", SqlServerVersion.v2012),
             "Data Source=DESKTOP-MK9933E\\MK9933E;Database=sales_system;Integrated Security=true;")
        { }
    }
}

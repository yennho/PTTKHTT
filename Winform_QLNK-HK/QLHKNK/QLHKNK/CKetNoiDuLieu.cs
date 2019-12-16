using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLHKNK
{
    class CKetNoiDuLieu
    {
       public SqlConnection conn;
       public SqlDataAdapter bodocghi;
    public CKetNoiDuLieu()
    {
        conn = new SqlConnection();
        string chuoiKetNoi = "Data Source=.;Initial Catalog=qlht;Integrated Security=True";
        conn.ConnectionString = chuoiKetNoi;
    }
    public DataTable Doc_Du_Lieu(string sql)
    {
        bodocghi = new  SqlDataAdapter(sql, conn);
        DataTable bangtam = new DataTable();
        bodocghi.Fill(bangtam);
        return bangtam;
    }
// cap nhat
    public  void Cap_Nhat(DataTable dt,SqlDataAdapter bdg)
    {
        SqlCommandBuilder capnhat = new SqlCommandBuilder(bdg);
        bdg.Update(dt);
    }
    }
}

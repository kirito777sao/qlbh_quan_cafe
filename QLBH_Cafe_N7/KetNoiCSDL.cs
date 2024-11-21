using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_Cafe_N7
{
    internal class KetNoiCSDL
    {
        SqlConnection conn;

        public void openConnection()
        {
            string chuoikn = "Server=THAI\\PHAMDUYTHAI;Database=QuanLyQuanCafe;Integrated Security=True";
            conn = new SqlConnection(chuoikn);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        //CRUD
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        //Bổ sung chức năng ReadData với SqlParameter
        public DataTable ReadData(string sql, SqlParameter[] sqlParameters)
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return dt;
        }

        public void CreateUpdateDelete(string sql, SqlParameter[] sqlParameters = null)
        //tích hợp CUD không cần xem trước kết quả trả về và truyền vào 1 mảng ký tự có hoặc không do người dùng nhập vào
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);//đưa tất cả vào paramester
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            finally { closeConnection(); }
        }

        public void CreateUpdateDelete(string sql, SqlParameter[] sqlParameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType; // Thêm dòng này

                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            finally { closeConnection(); }
        }
    }
}

using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassRepository
    {

        public string _connection_String = "";
        public ClassRepository()
        {
              _connection_String = ConfigurationManager.ConnectionStrings["ShawaaEntities"].ToString();
            

        }
        public IEnumerable<ShawaaClass> GetAll()
        {
            IEnumerable<ShawaaClass> _Classes = Enumerable.Empty<ShawaaClass>();
            using (System.Data.IDbConnection _Conn = new SqlConnection(_connection_String))
            {
                  _Classes = _Conn.Query<ShawaaClass>("select * from ShawaaClass");
               
               

            }
            return _Classes;


        }
        public ShawaaClass Get(int ClassId) 
        {
             ShawaaClass _Classes =new ShawaaClass();
            using (System.Data.IDbConnection _Conn = new SqlConnection(_connection_String))
            {
                _Classes = _Conn.QueryFirstOrDefault<ShawaaClass>("select * from ShawaaClass where ClassId=@ClassId", new { ClassId = ClassId });



            }
            return _Classes;


        }

        public void Change(int ClassId)  
        {
             
            using (System.Data.IDbConnection _Conn = new SqlConnection(_connection_String)) 
            {
                 _Conn.Execute("Update  ShawaaClass SET IsDeleted=1 ,DeletedDate=@DeletedDate where ClassId=@ClassId", new { ClassId = ClassId, DeletedDate=DateTime.Now.ToUniversalTime() });

            }
          


        }

        public void Delete(int ClassId)
        {

            using (System.Data.IDbConnection _Conn = new SqlConnection(_connection_String))
            {
                _Conn.Execute("Update  ShawaaClass SET IsDeleted=1 ,DeletedDate=@DeletedDate where ClassId=@ClassId", new { ClassId = ClassId, DeletedDate = DateTime.Now.ToUniversalTime() });

            }



        }
    }
}

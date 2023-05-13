using System.Data;
using MySql.Data.MySqlClient;
namespace dal;
public class Dbutil
{ 

   private static string connection=@"server=localhost;uid=root;pwd=sourabh@123;database=audiobook";
 
    public static MySqlConnection conn =null;
       
   public  static MySqlConnection connect(){
       if(conn==null){
        conn=new MySqlConnection(connection);
    
       }
     return conn;
       
    }  

    
   

}

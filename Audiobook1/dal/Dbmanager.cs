using dal;
using System.Data;
using MySql.Data.MySqlClient;
class Dbmanager
{   
   
  
   MySqlConnection conn =Dbutil.connect();

   
    int addbook(string filname, string link){
    conn.Open();
    try
    {
       MySqlCommand cmd=new MySqlCommand("insert into audbook(filname,link)values(?filname,?link)",conn);
    cmd.Parameters.Add("@filename",MySqlDbType.VarChar).Value=filname;
    cmd.Parameters.Add("@link",MySqlDbType.VarChar).Value=link;
    cmd.ExecuteNonQuery(); 
    return 1;   
    }
    catch (System.Exception err)
    {
        
       Console.WriteLine(err);
       return 0;
    }
    finally{

       conn.Close();
    }
   }

    
}
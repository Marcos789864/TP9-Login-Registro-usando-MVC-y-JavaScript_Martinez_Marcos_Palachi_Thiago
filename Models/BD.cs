using System.Data.SqlClient;
using Dapper;

public static class BD
{

private static string ConnectionString{get;set;}  = @"Server=. ; DataBase=Login_Usuarios ; Trusted_Connection=True;";                                       


public static string ObtnerContraseña(int DNI)
{
    string sql = "";   
    Usuario C = null;
    
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "Select Contraseña from Usuario where DNI = @vDNI";
        C = db.QueryFirstOrDefault<Usuario>(sql,new{vDNI = DNI});
    }
    if(C != null)
    {
        return C.Contraseña;
    }
    return "Contraseña no encontrada";
    

}

public static Usuario CrearUsuario(string Nombre, string Contraseña,int Telefono,string Ciudad, int DNI)
{
    string sql = "";
    Usuario us1 = null;
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "INSERT INTO Usuario (Nombre,Contraseña,Telefono,Ciudad,DNI) values (@vNombre,@vContraseña,@vTelefono,@vCiudad,@vDNI)";
        us1 = db.QueryFirstOrDefault<Usuario>(sql,new{vNombre = Nombre,vContraseña = Contraseña,vTelefono = Telefono,vCiudad = Ciudad, vDNI = DNI}); 
    }
    return us1;
}

public static Usuario IniciarSesion(string Nombre, string Contraseña)
{
    string sql = "";
    Usuario us1 = null;
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "Select * from Usuario where Nombre = @vNombre AND Contraseña = @vContraseña";
        us1 = db.QueryFirstOrDefault<Usuario>(sql,new{vNombre = Nombre,vContraseña = Contraseña}); 
    }
    return us1;
}

}
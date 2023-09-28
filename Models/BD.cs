using System.Data.SqlClient;
using Dapper;

public static class BD
{

private static string ConnectionString{get;set;}  = @"Server=localhost,DataBase=Login_Usuarios;Trusted_Connection=True;";                                       


public static string ObtnerContraseña(string Nombre)
{
    string sql = "";   
    string C = "";
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "Select Contraseña from Usuario where Nombre = @vNombre";
        C = db.Query<Usuario>(sql,new{vNombre = Nombre});
    }
    return C;
}

public static Usuario CrearUsuario(string Nombre, string Constraseña,int Telefono,string Ciudad, int DNI)
{
    string sql = "";
    Usuario us1 = null;
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "INSERT INTO Usuario (Nombre,Contraseña,Telefono,Ciudad,DNI) values (@vNombre,@vContraseña,@vTelefono,@vCiudad,@vDNI)";
        us1 = db.QueryFirstOrDefault<Usuario>(sql,new{vNombre = Nombre,vConstraseña = Constraseña,vTelefono = Telefono,vCiudad = Ciudad, vDNI = DNI}); 
    }
    return us1;
}

public static Usuario IniciarSesion(string Nombre, string Constraseña,int Telefono,string Ciudad, int DNI)
{
    string sql = "";
    Usuario us1 = null;
    using(SqlConnection db = new SqlConnection(ConnectionString))
    {
        sql = "Select from from Usuario where Nombre = @vNombre, Contraseña = @vContraseña ,Telefono = @vTelefono, Ciudad = @vCiudad, DNI = @vDNI";
        us1 = db.QueryFirstOrDefault<Usuario>(sql,new{vNombre = Nombre,vConstraseña = Constraseña,vTelefono = Telefono,vCiudad = Ciudad, vDNI = DNI});
    }
    return us1;
}

}
namespace AppModelo.Model.Infra.DataBase
{
    public static class Database
    {
        public static string MySqlConnection()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline03;uid=wwonline03;password=aluno22senai;";
            return conn;
        }
    }
}

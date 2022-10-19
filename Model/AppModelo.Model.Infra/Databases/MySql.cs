namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline03;uid=wwonline03;password=aluno22senai;";
            return conn;
        }
    }
}


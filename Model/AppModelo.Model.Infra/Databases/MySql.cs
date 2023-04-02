namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=localhost;database=senaiprojetomodelo;uid=root;password=;";
            return conn;
        }
    }
}


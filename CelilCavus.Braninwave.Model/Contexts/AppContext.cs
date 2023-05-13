
using MySql.Data.MySqlClient;

namespace CelilCavus.Braninwave.Model.Contexts
{
    public class AppContext
    {
        private static string connectStr = @"Server=localhost;Port=3306;Database=brainwave;Uid=root;Pwd=celil123;";
        private static MySqlConnection conn = new MySqlConnection(connectStr);

        public static MySqlConnection context { get; set; } = conn;
    }
}

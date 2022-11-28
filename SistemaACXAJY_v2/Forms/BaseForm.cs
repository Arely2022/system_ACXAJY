using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace system_ACXAJY;

public class BaseForm : Form
{
    protected SqlConnection con;

    public BaseForm()
    {
        string? connectionString = Program.Configuration.GetConnectionString("default");

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("El connection string no ha sido configurado correctamente.");
        }

        con = new SqlConnection(connectionString);
    }
}
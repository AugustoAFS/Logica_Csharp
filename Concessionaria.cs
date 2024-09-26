using MySql.Data.MySqlClient;

string connectionString = "Server=localhost;Database=concessionaria;Uid=root;Pwd=;";
using (MySqlConnection conn = new MySqlConnection(connectionString))
{
    conn.Open();

    Random rand = new Random();
    string[] cores = { "Vermelho", "Azul", "Verde", "Preto", "Branco" };

    for (int i = 0; i < 1000; i++)
    {
        // Inserir Marca
        string nomeMarca = "Marca_" + rand.Next(1, 101);
        string sqlMarca = "INSERT INTO Marca (nome) VALUES (@nomeMarca)";
        ExecuteNonQuery(conn, sqlMarca, new MySqlParameter("@nomeMarca", nomeMarca));
        int idMarca = GetLastInsertId(conn);

        // Inserir Modelo
        string nomeModelo = "Modelo_" + rand.Next(1, 101);
        string sqlModelo = "INSERT INTO Modelo (nome, id_marca) VALUES (@nomeModelo, @idMarca)";
        ExecuteNonQuery(conn, sqlModelo,
            new MySqlParameter("@nomeModelo", nomeModelo),
            new MySqlParameter("@idMarca", idMarca));
        int idModelo = GetLastInsertId(conn);

        // Inserir Placa
        string numeracao = GenerateRandomPlate(rand);
        string sqlPlaca = "INSERT INTO Placa (numeracao) VALUES (@numeracao)";
        ExecuteNonQuery(conn, sqlPlaca, new MySqlParameter("@numeracao", numeracao));
        int idPlaca = GetLastInsertId(conn);

        // Inserir Carro
        string cor = cores[rand.Next(cores.Length)];
        int quilometragem = rand.Next(0, 200001);
        DateTime dataFabricacao = DateTime.Today.AddDays(-rand.Next(0, 3651));
        string sqlCarro = "INSERT INTO Carro (cor, quilometragem, data_fabricacao, id_modelo, id_placa) " +
                          "VALUES (@cor, @quilometragem, @dataFabricacao, @idModelo, @idPlaca)";

        ExecuteNonQuery(conn, sqlCarro,
            new MySqlParameter("@cor", cor),
            new MySqlParameter("@quilometragem", quilometragem),
            new MySqlParameter("@dataFabricacao", dataFabricacao),
            new MySqlParameter("@idModelo", idModelo),
            new MySqlParameter("@idPlaca", idPlaca));
    }

    Console.WriteLine("Inserção de dados aleatórios concluída!");
}

void ExecuteNonQuery(MySqlConnection conn, string sql, params MySqlParameter[] parameters)
{
    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
    {
        if (parameters != null)
            cmd.Parameters.AddRange(parameters);

        cmd.ExecuteNonQuery();
    }
}

int GetLastInsertId(MySqlConnection conn)
{
    using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
    {
        return Convert.ToInt32(cmd.ExecuteScalar());
    }
}

string GenerateRandomPlate(Random rand)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    char[] plate = new char[7];
    for (int i = 0; i < plate.Length; i++)
    {
        plate[i] = chars[rand.Next(chars.Length)];
    }
    return new string(plate);
}

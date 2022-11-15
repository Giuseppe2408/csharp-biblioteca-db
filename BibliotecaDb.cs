// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

public class BibliotecaDb
{

    string StringaConnessione  { get; set; }
    SqlConnection ConnessioneSQL { get; set; }

    public BibliotecaDb() {

        StringaConnessione = "Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True";
        ConnessioneSQL = new SqlConnection(StringaConnessione);

    }



    public void AperturaConnessione()
    {
        //using System.Data.SqlClient;


        ConnessioneSQL.Open();


    }



    public void ChiusuraConnessione()
    {
        ConnessioneSQL.Close();
    }



    public void CreaLibro()
    {
        Console.WriteLine("titolo documento");
        string titolo = Console.ReadLine();
        Console.WriteLine("data");
        DateTime data = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("settore");
        string settore = Console.ReadLine();
        Console.WriteLine("scaffale");
        string scaffale = Console.ReadLine();
        Console.WriteLine("nome autore");
        string nome_autore = Console.ReadLine();
        Console.WriteLine("cognome autore");
        string cognome_autore = Console.ReadLine();
        Console.WriteLine("Codice Isbn");
        string codice_isbn = Console.ReadLine();
        Console.WriteLine("numero pagine");
        int numero_pagine = Convert.ToInt32(Console.ReadLine());



        string query = "INSERT INTO documenti" +
                " (titolo, anno, settore, stato, scaffale, nome_autore, cognome_autore, tipo, codice_isbn, numero_pagine)" +
                " VALUES (@titolo, @anno, @settore, @stato, @scaffale, @nome_autore, @cognome_autore, @tipo, @codice_isbn, @numero_pagine) ";

        SqlCommand command = new SqlCommand(query, ConnessioneSQL);
        command.Parameters.Add(new SqlParameter("@titolo", titolo));
        command.Parameters.Add(new SqlParameter("@anno", data));
        command.Parameters.Add(new SqlParameter("@settore", settore));
        command.Parameters.Add(new SqlParameter("@stato", false));
        command.Parameters.Add(new SqlParameter("@scaffale", scaffale));
        command.Parameters.Add(new SqlParameter("@nome_autore", nome_autore));
        command.Parameters.Add(new SqlParameter("@cognome_autore", cognome_autore));
        command.Parameters.Add(new SqlParameter("@tipo", "libro"));
        command.Parameters.Add(new SqlParameter("@codice_isbn", codice_isbn));
        command.Parameters.Add(new SqlParameter("@numero_pagine", numero_pagine));


        int affectedRows = command.ExecuteNonQuery();
    }


    public void CreaDvd()
    {
        Console.WriteLine("titolo documento");
        string titolo = Console.ReadLine();
        Console.WriteLine("data");
        DateTime data = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("settore");
        string settore = Console.ReadLine();
        Console.WriteLine("scaffale");
        string scaffale = Console.ReadLine();
        Console.WriteLine("nome autore");
        string nome_autore = Console.ReadLine();
        Console.WriteLine("cognome autore");
        string cognome_autore = Console.ReadLine();
        Console.WriteLine("Numero serie");
        string numero_di_serie = Console.ReadLine();
        Console.WriteLine("durata");
        int durata = Convert.ToInt32(Console.ReadLine());





        string query = "INSERT INTO documenti" +
        " (titolo, anno, settore, stato, scaffale, nome_autore, cognome_autore, tipo, numero_di_serie, durata)" +
        " VALUES (@titolo, @anno, @settore, @stato, @scaffale, @nome_autore, @cognome_autore, @tipo, @numero_di_serie, @durata) ";

        SqlCommand command = new SqlCommand(query, ConnessioneSQL);
        command.Parameters.Add(new SqlParameter("@titolo", titolo));
        command.Parameters.Add(new SqlParameter("@anno", data));
        command.Parameters.Add(new SqlParameter("@settore", settore));
        command.Parameters.Add(new SqlParameter("@stato", false));
        command.Parameters.Add(new SqlParameter("@scaffale", scaffale));
        command.Parameters.Add(new SqlParameter("@nome_autore", nome_autore));
        command.Parameters.Add(new SqlParameter("@cognome_autore", cognome_autore));
        command.Parameters.Add(new SqlParameter("@tipo", "DvD"));
        command.Parameters.Add(new SqlParameter("@numero_di_serie", numero_di_serie));
        command.Parameters.Add(new SqlParameter("@durata", durata));

        int affectedRows = command.ExecuteNonQuery();
    }

}

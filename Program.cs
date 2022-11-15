// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

BibliotecaDb bibliotecaDB = new BibliotecaDb(); 

        try
        {
            bibliotecaDB.AperturaConnessione();

            


            string titoloUt = Console.ReadLine();
            Console.WriteLine("digita 1 per aggiungere un libro");
            Console.WriteLine("digita 2 per aggiungere un dvd");
            Console.WriteLine("digita 3 per la lista dei libri");
            Console.WriteLine("digita 2 per la lista dei dvd");
            int sceltaUt = Convert.ToInt32(Console.ReadLine());
            switch (sceltaUt)
            {
            case 1:
            Console.WriteLine("quanti libri vuoi aggiungere?");
            int i = 0;
            int numerolibri = Convert.ToInt32(Console.ReadLine());

            while (i < numerolibri) {

                bibliotecaDB.CreaLibro();
 
                i++;
            }
            break;

        case 2:
            Console.WriteLine("quanti DvD vuoi aggiungere?");
            int n = 0;
            int numeroDvD = Convert.ToInt32(Console.ReadLine());

            while (n < numeroDvD)
            {

                bibliotecaDB.CreaDvd();
                n++;
            }
            break;


        case 3:




            break;

    }

           



        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            bibliotecaDB.ChiusuraConnessione();
        }
   


namespace FastChicken
{ 
    public class Program
    {
        public static void Main(string[] args)
        {

        
        var app = Startup.InicializarApp(args); // Pasamos los argumentos recibidos en la ejecucion



        app.Run();

        }
    }





}
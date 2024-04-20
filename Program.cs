using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.Laboratorio.ClasesHijasVideo;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

//Laboratorio();
//VideoJuego.listaDeJuegos();

static void pruebas()
{
    JuegoEstrategia Jugo = new JuegoEstrategia("Clash Royale","SuperCell",8,2013);
    JuegoDisparos Jugodis = new JuegoDisparos("Call of Duty", "Activition", 9, 2022);
    JuegoCombate Juegocom = new JuegoCombate("Mortal Kombat", "Konami", 7.5, 2012);
    int op = 0;
    string m;

    do
    {
        Console.WriteLine("Selecciona un género de juego:");
        Console.WriteLine("1. Estrategia");
        Console.WriteLine("2. Disparos");
        Console.WriteLine("3. Combate");
        Console.WriteLine("4. Salir");

        Console.Write("Ingrese el número correspondiente al género de juego deseado: ");
        op = Convert.ToInt32(Console.ReadLine());

        if (op != 0)
        {
            switch (op)
            {
                case 1:

                    m = Jugo.MostrarEs();
                    Console.WriteLine(m);
                    Console.WriteLine();
                    VideoJuego.saludo();
                    Console.WriteLine();
                    Console.WriteLine("Que dese hacer?");
                    Console.WriteLine("1) Jugar");
                    Console.WriteLine("2) Salir");
                    Console.WriteLine();
                    op = Convert.ToInt32(Console.ReadLine());
                    if(op == 1)
                    {
                        
                        Jugo.accion();
                    }
                    break;
                case 2:
                     m = Jugodis.Mostrardis();
                    Console.WriteLine(m);
                    Console.WriteLine();
                    VideoJuego.saludo();
                    break;
                case 3:
                    m = Juegocom.MostrarCom();
                    Console.WriteLine(m);
                    Console.WriteLine();
                    VideoJuego.saludo();
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida");
                    Console.WriteLine();
                    VideoJuego.saludo();
                    break;
            }
        }
    } while (op != 0);

}


pruebas();



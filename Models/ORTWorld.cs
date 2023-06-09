class ORTWorld{
    public static List<string> ListaDestinos {get; private set;} = new List <string>{
        "Medillin", "Misiones", "Mendoza", "Los Angeles", "Berlin", "Tel Aviv", "Amsterdam", "Roma", "Bariloche", "Tokyo"
    } ;
    public static List<string> ListaHoteles {get; private set;} = new List<string>{
        "Hotel1.jpg", "Hotel2.jpg", "Hotel3.jfif", "Hotel4.jfif", "Hotel5.jpg", "Hotel6.jpg", "Hotel7.jpg", "Hotel8.jpg", "Hotel9.jfif", "Hotel10.jpg" 
    } ;
    public static List<string> ListaAereos {get; private set;} = new List<string>{
        "Areolinea1.jpeg", "Areolinea2.png", "Areolinea3.png", "Areolinea4.png", "Areolinea5.png", "Areolinea6.png", "Areolinea7.jpg", "Areolinea8.png", "Areolinea9.png", "Areolinea10.png"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>{
        "Excursion1.jfif","Excursion2.jfif", "Excursion3.jpg", "Excursion4.jfif", "Excursion5.jpg", "Excursion6.jfif", "Excursion7.jfif", "Excursion8.jpeg", "Excursion9.jpg", "Excursion10.jpg"
        };
    public static Dictionary<string, Paquete> dicPaquetes {get; private set;} = new Dictionary<string, Paquete>{};
    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool ingresar = dicPaquetes.ContainsKey(destinoSeleccionado);
        if(ingresar == true){
            return ingresar;
        }else{
            dicPaquetes.Add(destinoSeleccionado, paquete);
            return ingresar;
        }
        
    }
}
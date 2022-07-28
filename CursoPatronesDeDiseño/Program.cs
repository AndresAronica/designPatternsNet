//using CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_of_Responsability;
//using CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_Of_Responsability;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Command;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Iterator;
//using CursoPatronesDeDiseño.PATRONES.Comportamiento.Mediator;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Memento;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Observer;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.State;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Strategy;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Template_Method;
using CursoPatronesDeDiseño.PATRONES.Comportamiento.Visitor;
using CursoPatronesDeDiseño.PATRONES.Creacionales.AbstractFactory;
//using CursoPatronesDeDiseño.PATRONES.Creacionales.Builder;
using CursoPatronesDeDiseño.PATRONES.Creacionales.Prototype;
using CursoPatronesDeDiseño.PATRONES.Creacionales.Singleton;
using CursoPatronesDeDiseño.PATRONES.Estructurales;
using CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter;
using CursoPatronesDeDiseño.PATRONES.Estructurales.Composite;
using CursoPatronesDeDiseño.PATRONES.Estructurales.Decorator;
using CursoPatronesDeDiseño.PATRONES.Estructurales.Facade;
using CursoPatronesDeDiseño.PATRONES.Estructurales.Flyweight;
//using CursoPatronesDeDiseño.PATRONES.Estructurales.Proxy;
//using CursoPatronesDeDiseño.PATRONES.Estructurales.VirtualProxy;
using CursoPatronesDeDiseño.SOLID.Animales;
using CursoPatronesDeDiseño.SOLID.Computadora;
using CursoPatronesDeDiseño.SOLID.FigurasGeometricas;

// ------------------------------
// TODO Ir sacando a diferentes clases cada principio o cada patron, para limpiar esta clase horrenda
// ------------------------------


//// Demostracion de SOLID Principio de Liskov
//// Estoy creando instancias de clases especificas llamando a una Interfaz generica
//// Para que se cumpla el principio, las clases Rectangulo/Triangulo tienen que implementar el 100% de los metodos de la clase padre
//IFiguraGeometrica rectangulo = new Rectangulo(10, 20);
//IFiguraGeometrica triangulo = new Triangulo(10, 5);
//Presentacion presentacion = new();

//// Aca se ve la ventaja de eso, ya que puedo hacer una lista que contenga diferentes tipos de instancias, pero que todas tienen el mismo tipo padre
//List<IFiguraGeometrica> figuras = new() { rectangulo, triangulo };

//// Lo que me permite hacer algo como esto, recorrer todos los objetos a pesar de que, en tiempo de ejecucion, son de diferente tipo
//foreach (IFiguraGeometrica figura in figuras)
//    presentacion.Area(figura);

//// ------------------------------------------------------------

//// SOLID Interface Segregation
//// El Jaguar puede ser:
//// IFelino -> Cazar
//// IFelinoSalvaje -> Cazar, Rugir
//// Animal -> Dormir, Comer
//// Jaguar -> Los 4 metodos
//// Al hacer Interface Segregation, te aseguras de cumplir con el SOLID Principio de Liskov, que dice que un subtipo deberia poder ser implementado como un tipo padre, y para poder hacer eso necesitas que el hijo implemente el 100% de los metodos del padre
//// Al reducir las interfaces a la minima expresion, tengo correctamente separada la logica de cada tipo de objeto
//IFelinoSalvaje jaguar = new Jaguar();
//jaguar.Cazar();
//jaguar.Rugir();
////jaguar.Dormir();
////jaguar.Comer();

//// Ejemplo para SOLID Inversion de Dependencias
//Teclado teclado = new();
//Mouse mouse = new();

//Computadora pc = new(teclado, mouse);
//pc.Encender();

// PATRONES

// CREACIONALES

// Simple Factory
CursoPatronesDeDiseño.PATRONES.Creacionales.SimpleFactory.Pizzeria pizzeria = new();
// No me interesa que hace falta para crear una pizza, solo quiero poder usarla
// La pizzeria se encarga de toda esa logica, ademas de tener control de que tipos de objetos se pueden crear
CursoPatronesDeDiseño.PATRONES.Creacionales.SimpleFactory.Pizza pizzaChica = pizzeria.CrearPizzaChica();
Console.WriteLine(pizzaChica.ToString());



// Factory Method
// Con la interfaz, puedo generar N pizzerias
// Cada pizzeria puede crear pizzas
// Cada pizzeria decide que tipo de pizza devuelve
// Con borde relleno son ejemplo de que es la pizzeria la que se encarga de crear la instancia de la clase que corresponda, al crear Pizza comun en las 2 primeras y Pizza con relleno en las segundas
CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod.Pizzeria pizzeria1 = new();
CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod.Pizza pizzaPeperoni = pizzeria1.CrearPizza("Peperoni");
CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod.Pizza pizzaHawaiana = pizzeria1.CrearPizza("Hawaiana");
CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod.Pizza pizzaBordeRelleno = pizzeria1.CrearPizza("Peperoni borde relleno");
CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod.Pizza pizzaBordeRelleno1 = pizzeria1.CrearPizza("Hawaiana borde relleno");
Console.WriteLine(pizzaPeperoni.ToString());
Console.WriteLine(pizzaHawaiana.ToString());
Console.WriteLine(pizzaBordeRelleno.ToString());
Console.WriteLine(pizzaBordeRelleno1.ToString());



// Abstract Factory
// TODO Darle un ToString() a estos metodos para poder mostrar la dif, maybe.
// Creo dos factories diferentes, que van a devolver diferentes clases, pero que crean la misma familia de objetos (computadoras y tablets)
// Despues, cada factory se encarga de devolverme la pc o tablet que corresponda
SamsungStore samsungStore = new();
AppleStore appleStore = new();

IComputadora mac = appleStore.CrearComputadora();
ITablet iPad = appleStore.CrearTablet();

IComputadora samsungPc = samsungStore.CrearComputadora();
ITablet galaxyTab = samsungStore.CrearTablet();



// Singleton
// La instancia se crea una vez, despues siempre llama a la misma. Una forma de controlarlo es usando el HashCode, que deberia ser el mismo.
/*ConexionBD conexion = ConexionBD.ObtenerConexion();
ConexionBD conexion2 = ConexionBD.ObtenerConexion();
Console.WriteLine(conexion.GetHashCode());
Console.WriteLine(conexion2.GetHashCode());*/



// Singleton Concurrente
// TODO Ver como se hace en .NET el ejemplo con Threads, porque la implementacion en Java es diferente.



// Builder
// Me falta portearlo de Java a .NET
//Usuario andres = Usuario
//    .Make("andres", "aronica")
//    .SetDireccion("534")
//    .SetEmail("test@test.com")
//    .Build();

//Console.WriteLine(andres);


// Prototype
// Objeto base
Enemigo enemigoBase = new("Imagen1.png", 0, 100, 2);

// Objetos copia del prototipo usando constructor. Hasta aca, son copias identicas.
Enemigo enemigo1 = new(enemigoBase);
Enemigo enemigo2 = new(enemigoBase);
Enemigo enemigo3 = new(enemigoBase);

// Puedo ir cambiandole solamente las propiedades que necesito, dejando todo lo demas igual
enemigo1.PosicionX = 100;
enemigo2.PosicionX = 150;
enemigo3.PosicionX = 200;

// Objeto copia del prototipo usando Clone().
Enemigo enemigo4 = enemigoBase.Clone();

enemigo4.PosicionX = 250;



// ESTRUCTURALES

// Adapter
// Reemplazo la implementacion de MySQL por el Adaptador, y al constructor le paso una nueva instancia de la implementacion que realmente se va a usar
//IConexionSQL conexion1 = new ConexionMySQL();
IConexionSQL conexion1 = new AdaptadorDB(new ConexionMongoDB());

conexion1.Conexion();

string resultado = conexion1.RunQuery();
Console.WriteLine(resultado);



// Composite
// Menu padre
IMenu menuArchivo = new Menu();

// Hijos de Archivo
IMenu menuNuevo = new Menu();
IMenu menuAbrir = new Menu();

// Hijos de Abrir, nietos de Archivo
IMenu menuCarpeta = new Menu();
IMenu menuSitioWeb = new Menu();

// Creo la estructura de arbol
menuArchivo.AddMenu(menuNuevo);
menuArchivo.AddMenu(menuAbrir);

menuAbrir.AddMenu(menuCarpeta);
menuAbrir.AddMenu(menuSitioWeb);



// Decorator
// Agrega resposabilidades adicionales a un objeto dinamicamente.
// Los decorators proveen una alternativa flexible de subclassing para extender funcionalidad.
// Estan todos al mismo nivel jerarquico, por implementar IPizza, lo que permite no romper la jerarquia de objetos ya definida
IPizza pizzaPeperoni1 = new PizzaPeperoni();

Console.WriteLine(pizzaPeperoni1.Descripcion());
Console.WriteLine(pizzaPeperoni1.Precio());

IPizza pizzaHawaiana1 = new PizzaHawaiana();

Console.WriteLine(pizzaHawaiana1.Descripcion());
Console.WriteLine(pizzaHawaiana1.Precio());

// Ahora la pizzeria agrega nuevas reglas:
// Queso extra = Precio+2 y la descripcion += "con queso extra"
// Pueden ir con borde relleno de queso = Precio+4. Se pueden o no sumar al queso extra

IPizza pizzaQuesoExtra = new QuesoExtra(new PizzaPeperoni());
Console.WriteLine(pizzaQuesoExtra.Descripcion());
Console.WriteLine(pizzaQuesoExtra.Precio());

IPizza pizzaQuesoExtraBordeRelleno = new BordeRelleno(new QuesoExtra(new PizzaHawaiana()));
Console.WriteLine(pizzaQuesoExtraBordeRelleno.Descripcion() + " " + pizzaQuesoExtraBordeRelleno.Precio());



// Facade
// Proporciona una interfaz unificada para un conjunto de interfaces de un subsistema.
// Define una interfaz de nivel superior, que hace que el subsistema sea mas facil de usar.
// Es decir, si tenemos un subsistema complejo, usando Facade un cliente puede utilizar nuestro sistema de una forma mucho mas facil.
// Actua como una fachada, exponiendo unicamente acciones sencillas al cliente, aunque por detras se hagan tareas complejas.
// Ej: Una transferencia bancaria. Al cliente le interesa la cantidad y el destino, por mas que por detras las tareas que se realizan sean complejas, totalmente irrelevantes para el cliente.
// Funciona como intermediario entre el cliente y el sistema (complejo).
Fachada fachadaComputadora = new();
fachadaComputadora.Encender();



// Proxy
// Objetivo: Limitar funcionalidades de nuestro sistema.
// Permite controlar el acceso a diferentes áreas de módulos.
// Ej: Solo los usuarios Admin pueden usar el CRUD, el resto solo Leer.
//IServicio servicio = new Servicio();
//IServicio servicio = new ProxyServicio(new Servicio(), new Usuario(3));
//servicio.Leer();
//servicio.Escribir();
//servicio.Actualizar();
//servicio.Eliminar();



// Virtual Proxy
// Es una variante de Proxy. No restringe el acceso al objeto, sino que intenta retrasar su creacion.
// Un motivo de uso puede ser que el objeto a crear tiene un costo muy alto.
//IServicio servicio = new VirtualProxyServicio(new Usuario(5));
//servicio.Leer();
//servicio.Escribir();
//servicio.Actualizar();
//servicio.Eliminar();



// Flyweight
// Reutilizar objetos, creando aplicaciones con la minima cantidad de recursos necesarios.
// Permite eliminar o reducir redundancia cuando se trabaja con gran cantidad de objetos.
NubeFactory factory = new();

// Con estos ciclos voy a llamar a GetNube(tipo) 600 veces
for (int i = 0; i < 100; i++)
{
    Nube nube = factory.GetNube(TipoNube.Chica);
}

for (int i = 0; i < 200; i++)
{
    Nube nube = factory.GetNube(TipoNube.Mediana);
}

for (int i = 0; i < 300; i++)
{
    Nube nube = factory.GetNube(TipoNube.Grande);
}

Console.WriteLine(factory.CountNubesDictionary());



// COMPORTAMIENTO

// Chain of Responsability
//Transaccion transaccion = new(100, 200, TipoTransaccion.Reembolso);

//// Es el cliente quien se encarga de armar la cadena de responsabilidad.
//// En esta implementacion en particular, se crean todos los objetos de IManejadorTransacciones sin importar si el primer objeto lo puede resolver.
//// TODO Implementar Virtual Proxy para que los siguientes objetos se creen solamente si es estrictamente necesario.
//IManejadorTransacciones _deposito = new Deposito();
//IManejadorTransacciones _retiro = new Retiro();
//IManejadorTransacciones _reembolso = new Reembolso();

//// Aca se arma la cadena deposito -> retiro -> reembolso
//_deposito.SetNextManejador(_retiro);
//_retiro.SetNextManejador(_reembolso);

//// Dependiendo de TipoTransaccion se va a ir pateando la ejecucion hasta encontrar una clase que lo pueda manejar, o salir si no encontro ninguna.
//_deposito.EjecutarTransaccion(transaccion);



// Command
// Se tiene una clase por cada metodo
IDevice tv = new TV();

// Cada clase cumple una sola funcionalidad, con un solo metodo, desacoplando la ejecucion de metodos
// Ahora es un objeto el que ejecuta el metodo, dejandolo encapsulado
ICommand on = new OnDevice(tv);
ICommand off = new OffDevice(tv);

on.Operacion();
off.Operacion();



// Iterator
// Provee un mecanismo estandar para acceder a los elementos de una coleccion
// De tal forma que si un objeto quiere acceder a los elementos de una coleccion tenga que hacerlo mediante la interfaz.
// Asi, no se exponen atributos ni metodos de la coleccion, protegiendola (hasta cierto punto)

GuiaTelefonica guia = new();

guia.Add("123");
guia.Add("34");
guia.Add("123423423");
guia.Add("5234");
guia.Add("23525");
guia.Add("534");

// De esta forma el cliente no sabe que existe internamente para mi objeto.
// Lo unico que sabe es que puede iterar esa propiedad
IIterador iterador = new IteradorGuia(guia);

while (iterador.ContieneSiguiente())
    Console.WriteLine(iterador.Siguiente());



// Mediator
// Patron que no tiene reglas especificas para ser implementado
// Esta implementacion es bastante simple

// Define un objeto que encapsula como los objetos van a interactuar entre si
// Se utiliza para comunicar objetos (de la misma clase o distintas) entre ellos
// Ejemplo: Torre de control en aeropuerto. Torre de control cumple el papel de Mediator, ya que esta en contacto con todas las aeronaves permitiendo que se comuniquen entre ellas

//Usuario andres = new("Andres");
//Usuario pedro = new("Pedro");

//SalaChat salaChat = new();
//salaChat.AgregarParticipante(andres);
//salaChat.AgregarParticipante(pedro);

//salaChat.EnviarMensaje(andres, pedro, "Hola");



// Memento
// Permite capturar y externalizar el estado interno de un objeto (SIN ROMPER ENCAPSULAMIENTO) para que se pueda recuperar el estado anterior en un momento futuro.
// Es una copia de seguridad del objeto, es la posibilidad de hacer "Ctrl+Z".
// La copia de seguridad puede ser parcial o total.

// Creo un usuario y su copia de seguridad
UsuarioMemento usuarioMemento = new("Andres", 25);
UsuarioMemento copiaSeguridadUsuario = usuarioMemento.GetMemento();

Console.WriteLine(usuarioMemento);
Console.WriteLine(copiaSeguridadUsuario);

// Modifico al usuario original
usuarioMemento.Nombre = "Andres1";
usuarioMemento.Edad = 50;

Console.WriteLine(usuarioMemento);
Console.WriteLine(copiaSeguridadUsuario);

// Lo vuelvo a su estado anterior
usuarioMemento.RestartMemento(copiaSeguridadUsuario);

Console.WriteLine(usuarioMemento);
Console.WriteLine(copiaSeguridadUsuario);



// Observer (Tambien puede ser llamado Pub-Sub (Publiser-Subscriber))
// Define una relacion de dependencia uno a muchos para que cuando un objeto cambie su estado, todas las dependencias sean notificadas y actualizadas automaticamente

ProductoObserver palta = new(10);

UsuarioObserver usuario1 = new(); // Si va a estar notificado
UsuarioObserver usuario2 = new(); // Si va a estar notificado
UsuarioObserver usuario3 = new(); // No va a estar notificado

// Agrego usuario1 y usuario2 como observadores de este producto
palta.AddObserver(usuario1);
palta.AddObserver(usuario2);

// Llamo al metodo que va a disparar las notificaciones
palta.Venta();



// State
// Permite que un objeto modifique su comportamiento cuando cambia su estado interno.
// Dando la ilusion que el objeto cambio de clase
// Se implementa cuando se trabaja con maquinas de estado
Auto auto = new();

// Estos son cambios que si puede hacer el objeto
auto.Encender();
auto.Manejar();
auto.Apagar();

// Estos no, porque no me va a dejar manejar un auto apagado
//auto.Manejar();
//auto.Encender();


// Comportamiento - Algoritmos

// Strategy
// Permite encapsular algoritmos en clases, de tal forma que podes usar diferentes algoritmos en tiempo de ejecucion
// Ej: Calculo de comisiones. Como cada comision varia mucho, se puede encapsular en el patron Strategy

// Creo una transaccion de tipo deposito
Transaccion transaccion1 = new(new Deposito());

// Ejecuto la transaccion de tipo deposito
Console.WriteLine(transaccion1.EjecutarTransaccion(100, 300));

// Creo una transaccion de tipo retiro
Transaccion transaccion2 = new(new Retiro());

// Ejecuto la transaccion de tipo retiro
Console.WriteLine(transaccion2.EjecutarTransaccion(100, 50));



// Template Method
// Define una estuctura algoritmica cuya logica queda a cargo de las subclases
// Se crea una clase padre con diferentes algoritmos, ejecutables en las clases hijas
// La clase padre tendra metodos que las clases hijas tendran que definir el comportamiento
// Basicamente, es una clase abstracta

Usuario gerente = new Gerente();
Usuario administrador = new Administrador();

gerente.Autenticacion();
gerente.FormaTrabajar();

administrador.Autenticacion();
administrador.FormaTrabajar();



// Visitor
// Permite definir una nueva operacion sin cambiar las clases de los elementos que los operan
// Permite separar un algoritmo de la estructura de un objeto
// Si un objeto es el responsable de mantener cierto tipo de informacion, entonces es logico asignarle tambien la responsabilidad de realizar todas las operaciones necesarias sobre esa informacion
// Ej: Descuentos en productos de supermercados. Fruta 10%, Linea Blanca 5%
// Sin el patron, tendria que estar modificando el precio en la clase manzana,lavarropas,etc por cada descuento que haya (fin de semana, fiestas, etc)

Manzana manzana = new();
Lavarropas lavarropas = new();

// Para aplicar un descuento comun, creo una instancia de DescuentoComun y se lo paso como el parametro a AplicarDescuento
IVisitor descuentoComun = new DescuentoComun();

// Si quisiera aplicar otro tipo de descuento, solo tengo que reemplazar el parametro de AplicarDescuento
Console.WriteLine(manzana.AplicarDescuento(descuentoComun));
Console.WriteLine(lavarropas.AplicarDescuento(descuentoComun));
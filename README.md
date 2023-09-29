# Patrón de diseño Estructural: Decorador

##### El patrón de diseño estructural se implementó de manera que el decorador sería el utilizado. El decorador nos sirve para agregar características adicionales a una clase.

El caso elegido para este ejemplo, fue una venta de videojuegos.

![](D:\Universidad\ANALISIS2\videojuegos\wall.jpg)

En este ejemplo, los decoradores agregan la funcionalidad de agregar un descuento al precio del videojuego, luego también agrega contenido descargable gratis a un videojuego.

Acá se explica la funcionalidad de cada clase:

| Clase              | Función                                                      |
| ------------------ | ------------------------------------------------------------ |
| VideoGame          | Clase abstracta que implementa propiedades y métodos del videojuego. |
| BaseGame           | Clase pública que implementa la clase VideoGame, setea las propiedades desde el constructor, y utiliza override void para reemplazar el método Play(). |
| DiscountDecorator  | Decorador que recibe el videojuego como parámetro, y el descuento en decimal. Luego en el método override void Play(), llama al método de la clase Padre, e imprime en consola que se aplicó un descuento y cuál es el nuevo precio. |
| DLCDecorator       | Este decorador agrega contenido descargable al videojuego. Y le agrega un valor agregado al precio original. Agrega 15 dólares al precio. |
| VideoGameDecorator | Este decorador es el base, implementa la clase VideoGame, y lo recibe como parámetro en el constructor, y siempre utiliza override void Play() para realizar la acción Play de la clase padre |
|                    |                                                              |



```c#
 public abstract class Videogame
 {
     public string Name { get; protected set; }
     public decimal Price { get; protected set; }
 	 public abstract void Play();
 }
```

### Autores:

- Miriam Leticia Cutzal Otzoy / Carné 0910-20-10619

- Emilio Andrés Hernández / Carné 0910-20-19375
- Byron Felipe Jutzutz Sepet / Carné 0910-20-1189
- Jonás Rangel Colón / Carné 0910-20-11094
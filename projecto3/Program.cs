using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
/*
Console.WriteLine("Ingresa un número:");

int n =int.Parse(Console.ReadLine());
int suma= 0;
while(n>0){
    int i=n %10;suma +=i; n/=10;
}
Console.WriteLine("la suma es "+ suma);



  Console.WriteLine("Ingrese un número:");
        string inpu = Console.ReadLine();
        int suma2 = 0;

        // Iteramos sobre cada carácter en la cadena de entrada
        for (int i = 0; i < inpu.Length; i++)
        {
            char digito = inpu[i];

            // Verificamos si el carácter es un dígito
            if (char.IsDigit(digito))
            {
                // Si es un dígito, lo convertimos a un número entero y lo sumamos a la suma total
                suma += int.Parse(digito.ToString());
            }
        

        Console.WriteLine("La suma de los dígitos es: " + suma2);
        }
    
Console.WriteLine("ingrese numero");
int n1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese otro numero");
int n2 =Convert.ToInt32(Console.ReadLine());

int suma1=n1 + n2;

Console.WriteLine("la suma de "+ n1 + "+" + n2 + "es;" + suma1);

*/
/*

Console.WriteLine("ingresa un numero pa darte la tabla ");
double numero =  double.Parse(Console.ReadLine());




  Console.WriteLine("tabla de multiplcar "+ numero);
  for(int i =0 ; i<=10; i++)
  {
    double resul=numero * i;
    Console.WriteLine($"{numero}x {i} = {resul}");
  }
*/

public class Person{   

    public Person(){
      Name ="unknown";
      Age="unknown";
    }
    public Person(string name, int age)
    {
      Name = name;
      Age = age.ToString(); // aca asigno la edad comvertida a cadena 
    }

    public string Name {get;}//esto es basicamente propiedades de lectura lo cual no permite modificar a no ser que lo hagas dentro del class 
    
    public string Age {get;} //en otras palabras son campos privados lo cual solo puedes acceder en modo de lectura . :V

    public override string ToString() // se usa public override es cuando estas anulando o sobreescribiendo un metodo  de la clase derivada
  //lo cual estoy anulando o sobreescribiendo el metodo ToString() de la clase base(person), lo cual permite proporcionar la implementacion especifica del tostring().

    {
      return $"Name :{Name} ,edad: {Age}"; //aca basicamente retorna la llamada al metodo a un objeto"person" , osea que deberia salirte tal como sale,ejemplo:"miguel",edad 30
    }
 
  
}
class TestPerson{
  static void Main()    //pues basicamente este es el punto de entrada de cualquier ampliacion .se ejecuta cuando se inicia un programa (es estatico ,no necesita una instancia de la clase para ser invocado)

  {//creo unas instancias para despues imprimirlas con sus atributos 
    var person1=new Person();       //basicamente la creo pero no mostrara ningun atributo ya que no han sido definidos , solo mostrara lo definido anteriormente:"unknown"
    Console.WriteLine(person1.Name,person1.Age);

    var person2 =new Person("sarah joneees",30);//aca basicamente creo otra en donde ingreso directamente los datos para luego ser imprimido 
    Console.WriteLine(person2.Name ,person2.Age);//esto solo muestra en consola los parametros declarados 
    Console.WriteLine(person2);
    
    var person3 =new Person();
    Console.WriteLine(person3.Name );
  
  
  
  
  }
}





namespace EjercicioR;
//Aqui hagan la superclase abstracta, y las operaciones
abstract class Empleados
{
  protected double tipo_pag;//Lo que el usuario digitara 
  protected double asalariados,suelxhor,emplexcom,asalaxcomi;//tipos de sueldo o tipo de cobro que se maneja 
  protected string resp; //Esta variable sirve para enviar una respuesta
    //Tengo accesos a las variables virtual y abstract 
    //La manera abstract fue para las variables que se necesitan en todas las subclases
    //La manera virtual lo contrario, pues sirve para que no se tenga que poner a fuerza el metodo de acceso

    //Hay algo mal en el codigo, una llave de una clase engloba a las demas clases, cambienlo
    //Solo la clase ABSTRACT puede usar metodos ABSTRACT//
  public virtual double SueldoSem //Esto es un acceso a la variable o metodo de variable
  {
   get;
   set;
  }
  public virtual double TrabaXHora
  {
    get;
    set;
  }
  public virtual double TrabaxComi
   {
    get;
   set;
   }
  public virtual double Traba_asalaxcomi
   {
   get;
   set;
  }
   public abstract double Resp
   {
   get;
   set;
   }
  public abstract void Result();
  }
// Fin de la clase padre

//Nota: Para las clases hijo no se debe poner abstract, solo el tipo de variable que se debe
  //Clase para los asalariados
   class EmAsalar : Empleados//Tipo empleado deberia ser lo que tienes a la derecha (EmSalar), en la izquierda debe de ponere Empleados
   {
     public override double SueldoSem
      {
       get{return SueldoSem;}
       set{SueldoSem = value;}
      }
   }
  //Clase para el trabajador por horas
  class EmPagxHor :Empleados//Lo mismo
   {  
     public override double TrabaXHora
      {
       get{return TrabaXHora;}
       set{TrabaXHora = value;}
      } 
   }
  //Esta clase es para los comisionistas
  class EmPagxComi :Empleados //Lo mismo
   {
     public override double TrabaxComi
      {
       get{return TrabaxComi;}
       set{TrabaxComi = value;}
      }
   }
  //Esta clase sirve para el empleado asalariado con comision
   class EmPagxAsalarxComi :Empleados //Lo mismo, el resto de clases no aplican pues solo hay 4 tipos de empleados.
   {
     public override double Traba_asalaxcomi
       {
         get{return Traba_asalaxcomi;}
         set{Traba_asalaxcomi = value;}
       }
   }
    class Respuesta :Empleados //Lo mismo, el resto de clases no aplican pues solo hay 4 tipos de empleados.
   {
    public override double Resp
       {
         get{return Resp;}
         set{Resp = value;}
       }
}




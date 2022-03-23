using System;

namespace ProjetoPets
{
    public abstract class Pets
    {
       public string? Nome { get; set; }
       public string? Raca { get; set; }
       public int Idade { get; set; }
      
       public bool Vacinado{get;set;}

       private bool _possuiDono = false;
       public bool PossuiDono { get; set; }

 


       public  virtual String MostrarPet()
       {
            return "\n Nome: " + Nome + "\n Raça: " + Raca + "\n Idade: " + Idade + "\n Vacinado: " + (Vacinado? "Sim": "Não");
       }
       


      
       

    }
}
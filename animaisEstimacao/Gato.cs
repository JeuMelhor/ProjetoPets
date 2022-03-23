namespace ProjetoPets
{
    public class Gato:Pets
    {
        public Gato (string Nome, string Raca, int Idade, bool Vacinado)
        {
             this.Nome = Nome;
            this.Raca=Raca;
            this.Idade=Idade;
            this.Vacinado=Vacinado;
        }
            
         
     public  override String MostrarPet()
       {
            //return "Informações do Seu Cachorro \n Nome: " + Nome + "\n Raça: " + Raca + "\n Idade: " + Idade + "\nPorte: " + Porte +"\n Vacinado: " + (Vacinado?"sim":"Não");

            return "Informações do seu Gato "+ base.MostrarPet()  + "\n-----------------------------------------";
       }
      
    }
}
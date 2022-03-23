namespace ProjetoPets
{
    public class Cachorro:Pets
    {
        
        private string _porte;
        public string Porte 
        { 
            get
            {
                return _porte;
            } 
            set
            {
                
                if(value != "MEDIO" && value != "PEQUENO" && value != "GRANDE" )
                {
                    Console.WriteLine("Escolha entre PEQUENO, MEDIO OU GRANDE! \n ATENÇÃO: Letras MAIÚSCULAS!");
                }
                _porte=value;
                
                            
 
            } 
        }

        public Cachorro (string Nome, string Raca, int Idade, bool Vacinado, string Porte)
        {
            this.Nome = Nome;
            this.Raca=Raca;
            this.Idade=Idade;
            this.Porte = Porte;
            this.Vacinado=Vacinado;
        }

        public  override String MostrarPet()
       {
            //return "Informações do Seu Cachorro \n Nome: " + Nome + "\n Raça: " + Raca + "\n Idade: " + Idade + "\nPorte: " + Porte +"\n Vacinado: " + (Vacinado?"sim":"Não");

            return "Informações do seu Cachorro"+ base.MostrarPet() + "\n Porte: "+ Porte + "\n -----------------------------------------";
       }
    }
}
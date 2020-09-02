using GAMETOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
   
        public readonly string _Nome;
        

        public Jogador1(string nome = "Rafito")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {

            return $"{_Nome} está chutando \n" ;

        }
        //corre
                public string Corre()
        {
            return $"{_Nome} está correndo \n" ;

        }
        //passa
        public string Passe()
        {
            return $"{_Nome} está passando \n" ;
        }
    }
}
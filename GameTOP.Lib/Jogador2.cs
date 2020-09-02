using GAMETOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
           return "Mandrake está pateando \n";
        }

        public string Corre()
        {
           return "Mandrake está correndo \n";
        }

        public string Passe()
        {
            return "Mandrake está passando \n";
        }
    }
}
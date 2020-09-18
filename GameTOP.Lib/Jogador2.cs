using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Victor esta Chutando \n";
        }

        public string Corre()
        {
            return "Victor esta Correndo \n";
        }

        public string Passe()
        {
            return "Victor esta Passando \n";
        }
    }
}
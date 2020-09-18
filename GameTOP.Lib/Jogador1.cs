using GameTOP.Interface;

namespace GameTOP.Lib
{
 public class Jogador1 : iJogador
    {
        public string _Nome;

        public Jogador1(string Nome = "Ronaldo")
        {
            _Nome = Nome;
        }

        public string Chuta()
        {
           return $"{_Nome} esta Chutando. \n";
        }

        public string Corre()
        {
            return $"{_Nome} esta Correndo. \n";
        }

        public string Passe()
        {
            return $"{_Nome} esta Passando. \n";
        }

    }
}
using System;

namespace TsukaAirlines
{
    class Passageiro
    {        
            string nome;
            int numeroPassagem;
            DateTime data;

            public void setNome(string nome){
                this.nome = nome;   
            }
            public void setNumeroPassagem(int numeroPassagem){
                this.numeroPassagem = numeroPassagem;
            }
            public void setDateTime(DateTime data){
                this.data = data;
            }

        public string getNome() {
            return this.nome;
        }
        public int getNumeroPassagem() {
            return this.numeroPassagem;
        }
        public DateTime GetDateTime() {
            return this.data;
        }
    }
}

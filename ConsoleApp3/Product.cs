using System;
using System.Globalization;

namespace ConsoleApp3 {
    class Product {
        private string _nome;
        public double Preco { get; private set; }//não é permitido para outros arquivos alterar
        //o valor do atributo Preco
        public int Quantidade { get; private set;}

        public Product() {
         
        }
        public Product(string nome, double preco, int quantidade)  {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {//expor para mundo externo apenas a propriedade
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;

                }
            }


        }
        public double ValorEmEstoque() {
            return Preco * Quantidade;
        }
        public void Adicionar(int adicionar) {
             Quantidade += adicionar;
        }
        public void Remover(int adicionar) {
            Quantidade -= adicionar;
        }
        public override string ToString() {
            return "Dados do produto: "+ _nome +
               ", "+Preco+" , "+Quantidade+" , Total: "+
               ValorEmEstoque();
        }
    }
}

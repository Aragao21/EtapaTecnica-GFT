namespace Exercicio_1.Classes
{
    public class Calculadora : EntidadeBase
    {
        // Atributos
		private int Ano { get; set; }
		private int AnoNasc { get; set; }
        private float Altura { get; set; }
        private float Peso { get; set; }

        // Métodos
		public Calculadora(int id, int ano, int nascimento, float altura, float peso)
		{
			this.Id = id;
			this.Ano = ano;
			this.AnoNasc = nascimento;
			this.Altura = altura;
			this.Peso = peso;
		}
    }
}
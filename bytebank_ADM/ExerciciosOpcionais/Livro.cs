using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ExerciciosOpcionais
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public int AnoPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisPublicacao { get; set; }

        public Livro(string titulo, int isbn)
        {
            this.Titulo = titulo;
            this.Isbn = isbn;
        }
    }
}

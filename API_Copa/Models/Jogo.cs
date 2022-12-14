using System;
using System.ComponentModel.DataAnnotations;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {
           // SelecaoA = new Selecao();
           // SelecaoB = new Selecao();
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public int SelecaoAId {get;set;}
        public Selecao SelecaoA { get; set; }
        public int SelecaoBId {get; set;}
        public Selecao SelecaoB { get; set; }
        public int placarA { get; set; }
        public int placarB { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}

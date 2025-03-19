using System.ComponentModel.DataAnnotations;

namespace AppFotos.Models
{
    ///<summary>
    ///categorias a que as fotografias podem ser associadas
    ///</summary> 
    public class Categorias {
        /// <summary>
        /// Identificador da categoria
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        ///Nome da categoria que será associada às fotografias
        /// </summary>
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório.")]
        [StringLength(20, ErrorMessage = "A {0} deve ter um máximo de {1} caracteres.")]
        public string Categoria { get; set; }

        /******************************
         * Definicao dos Relacionamentos
         * *****************************
         */

        ///<summary>
        /// Lista das Fotografias associadas a uma categoria
        /// </summary>
        public ICollection<Fotografias> ListaFotografias { get; set; } = new List<Fotografias>();
    }
}

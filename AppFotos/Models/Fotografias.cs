namespace AppFotos.Models
{
    ///<summary>
    ///Fotografias disponiveis na aplicação
    ///</summary> 
    
    public class Fotografias{
        public int Id { get; set; }

        /// <summary>
        ///  
        /// </summary>
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Ficheiro { get; set; }

        /// <summary>
        /// Data que a foto foi tirada
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Preco de venda da fotografia
        /// </summary>
        public decimal Preco { get; set; }


    }
}

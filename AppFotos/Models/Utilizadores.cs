namespace AppFotos.Models
{
    ///<summary>
    ///utilizadores
    ///</summary> 
    public class Utilizadores
    {
        /// <summary>
        /// identificador do utilizador
        /// </summary>
        public int Id { get; set; }

        public String Nome { get; set;  }

        public string Morada { get; set; }
        /// <summary>
        /// numero Identificacao fiscal
        /// </summary>
        public int CodPostal { get; set; }
        /// <summary>
        /// pais do utilizador
        /// </summary>
        public int Pais { get; set; }
        /// <summary>
        /// numero Identificacao fiscal
        /// </summary>
        public string NIF { get; set; }
        /// <summary>
        /// numero de telemovel
        /// </summary>
        public string Telemovel { get; set; }






    }
}

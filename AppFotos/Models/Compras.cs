namespace AppFotos.Models
{
    ///<summary>
    ///compras
    ///</summary> 
    public class Compras {

        public int Id { get; set; }

        /// <summary>
        /// data da compra
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Estado da compra
        /// Representa um conjunto de valores pre-determinados
        /// que representa a evolucao da compra
        /// </summary>
        public Estados Estado { get; set; }
        
        
        /// <summary>
        /// Estados associados a uma compra
        /// </summary>
        public enum Estados {
        Pendente,
        Pago,
        Enviada,
        Entregue,
        Terminada
        }


    }
}

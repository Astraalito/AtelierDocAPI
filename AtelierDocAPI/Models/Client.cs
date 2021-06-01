using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierDocAPI.Models
{
    /// <summary>
    /// An object that represent a Client
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class Client
    {
        /// <summary>
        /// Id of the client
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the client
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Email of the client
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Adress of the client
        /// </summary>
        public string Adresse { get; set; }
        /// <summary>
        /// Telephone of the client
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Referent of the client
        /// </summary>
        public string Referent { get; set; }
        /// <summary>
        /// Rib of the client
        /// </summary>
        public string Rib { get; set; }
        /// <summary>
        /// Siret of the company of the client
        /// </summary>
        public string Siret { get; set; }
        /// <summary>
        /// Type of client
        /// </summary>
        public string Type_Client { get; set; }

        /// <summary>
        /// Client Constructor
        /// </summary>
        public Client(int id, string nom, string email, string adresse, string telephone, string referent, string rib, string siret, string type_Client)
        {
            Id = id;
            Nom = nom;
            Email = email;
            Adresse = adresse;
            Telephone = telephone;
            Referent = referent;
            Rib = rib;
            Siret = siret;
            Type_Client = type_Client;
        }
    }
}

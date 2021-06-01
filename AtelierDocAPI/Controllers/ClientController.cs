using AtelierDocAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtelierDocAPI.Controllers
{
    /// <summary>
    /// The controller of the Client class
    /// </summary>
    /// <remarks>
    /// This controller manage all the request that concern the Clients in the application. The application can apply all CRUDS requests for Client object.
    /// The base endpoint for api access is "/api/Client"
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        /// <summary>
        /// List of all the clients
        /// </summary>
        /// <remarks>
        /// All the client are contained in this list. These datas would normally be stored and fetch in a json file but as Nicolas can't do shit, here we are :)
        /// </remarks>
        List<Client> listClient = new List<Client>();

        /// <summary>
        /// First client object
        /// </summary>
        Client client1 = new Client(0, "oui", "ouiExact@mail.com", "42 rue de la moulaga", "0622222222", "Non Padutou", "22222222222", "9393939393", "Gentil");
        /// <summary>
        /// Second client object
        /// </summary>
        Client client2 = new Client(1, "oui", "ouiExact@mail.com", "42 rue de la moulaga", "0622222222", "Non Padutou", "22222222222", "9393939393", "Gentil");


        /// <summary>
        /// Class constructor
        /// </summary>
        /// <remarks>
        /// Used to fill the clientList
        /// </remarks>
        public ClientController()
        {
            listClient.Add(client1);
            listClient.Add(client2);
        }

        /// <summary>
        /// GET all the Clients
        /// </summary>
        /// <remarks>
        /// This method refere to a GET request, that return all the client stored in the datas.
        /// </remarks>
        [HttpGet]
        public List<Client> GetClients()
        {
            return listClient;
        }

        /// <summary>
        /// The method Get one Client
        /// </summary>
        /// <remarks>
        /// This method refere to a GET request, that return one Client using his Id.
        /// </remarks>
        /// <param name="id">
        /// id of the requested client
        /// </param>
        [HttpGet("{id}")]
        public Client GetClient(int id)
        {
            return listClient.Single(client => client.Id == id);         
        }

        /// <summary>
        /// The method Create a new Client
        /// </summary>
        /// <remarks>
        /// This method refere to a POST request, that create a new client in the datas.
        /// </remarks>
        /// <param name="client">
        /// A Client object sent in the body of the request.
        /// </param>
        [HttpPost]
        public ActionResult<Client> CreateClient([FromBody] Client client)
        {
            listClient.Add(client);
            return CreatedAtAction(nameof(GetClients), new { id = 3});
        }

        /// <summary>
        /// The method Delete a Client
        /// </summary>
        /// <remarks>
        /// This method refere to a DELETE request, that remove a client from the datas.
        /// </remarks>
        /// <param name="id">
        /// id of the requested client
        /// </param>
        /// <param name="client">
        /// A Client object sent in the body of the request.
        /// </param>
        [HttpDelete("{id}")]
        public ActionResult<Client> DeleteClient(int id, [FromBody] Client client)
        {
            Client targetClient = listClient.Single(oui => oui.Id == id);
            listClient.Remove(targetClient);
            return CreatedAtAction(nameof(GetClients), new { id = 3 });
        }
    }
}

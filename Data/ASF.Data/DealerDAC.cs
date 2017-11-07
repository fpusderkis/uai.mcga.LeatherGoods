using System;
using System.Collections.Generic;
using System.Linq;
using ASF.Entities;

namespace ASF.Data
{
    public class DealerDAC : AbstractDAC<Dealer>
    {
        public DealerDAC(LeatherContext context) : base(context)
        {
        }
        
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public Client Create(Client client)
        {
            using (var dbc = Context) {

                var savedEntity = dbc.Client.Add(client);
                dbc.SaveChanges();
                return savedEntity;

            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public void UpdateById(Client client)
        {
            using (var dbc = Context)
            {
                client.ChangedOn = new DateTime();
                dbc.Entry(client).State = System.Data.Entity.EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            using (var dbc = Context)
            {
                Client client = new Client { Id = id };
                dbc.Client.Attach(client);
                dbc.Client.Remove(client);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client SelectById(int id)
        {
            using (var dbc = new LeatherContext())
            {
                return dbc.Client.Find(id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>		
        public List<Client> Select()
        {


            using (var dbc = new LeatherContext())
            {

                return dbc.Client.ToList();
            }

            
        }

        
        
    }
}
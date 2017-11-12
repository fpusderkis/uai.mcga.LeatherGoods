using ASF.Data;
using ASF.Entities;
using System;
using System.Collections.Generic;

namespace ASF.Business
{
    public class DealerBusiness
    {
        DealerDAC dealerDAC = new DealerDAC();
        
        /// <summary>
        /// Add method. 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Dealer Add(Dealer dto)
        {

            dto.CreatedOn = DateTime.Now;
            dto.ChangedOn = dto.CreatedOn;
            var saved = dealerDAC.Save(dto);
            return saved;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            dealerDAC.DeleteById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Dealer> All()
        {

            var result = dealerDAC.SelectAll();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dealer Find(int id)
        {
            return dealerDAC.SelectById(id);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        public void Edit(Dealer dto)
        {


            var dtoToSave = dealerDAC.SelectById(dto.Id);

            if (!String.IsNullOrEmpty(dto.FirstName)) dtoToSave.FirstName = dto.FirstName;
            if (!String.IsNullOrEmpty(dto.Description)) dtoToSave.Description = dto.Description;
            if (!String.IsNullOrEmpty(dto.LastName)) dtoToSave.LastName = dto.LastName;
            if (dto.CountryId > 0) {

                if (dto.CountryId != dtoToSave.CountryId)
                {

                }

            }
            if (!String.IsNullOrEmpty(dto.FirstName)) dtoToSave.FirstName = dto.FirstName;
            if (!String.IsNullOrEmpty(dto.FirstName)) dtoToSave.FirstName = dto.FirstName;

            dtoToSave.ChangedOn = DateTime.Now;
            dealerDAC.Save(dtoToSave);
        }
    }
}

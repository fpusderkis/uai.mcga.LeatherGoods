//====================================================================================================
// Base code generated with LeatherGoods - ASF.Business
// Architecture Solutions Foundation
//
// Generated by academic at LeatherGoods V 1.0 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASF.Entities;
using ASF.Data;
using System.Diagnostics;

namespace ASF.Business
{
    /// <summary>
    /// CategoryBusiness business component.
    /// </summary>
    public class CategoryBusiness : AbstractBussiness
    {

        public CategoryDAC categoryDAC { get; set; } = new CategoryDAC();
        /// <summary>
        /// Add method. 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public Category Add(Category category)
        {
            return categoryDAC.Create(category);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            categoryDAC.DeleteById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> All()
        {
            var result = categoryDAC.Select();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category Find(int id)
        {
            categoryDAC.SelectById(id);

            var sw = Stopwatch.StartNew();

            var directo = categoryDAC.SelectById(id);

            var stg1 = sw.ElapsedMilliseconds;

            var refsw = Stopwatch.StartNew();
            var result = categoryDAC.FindById<Category>(id);

            var stg2 = refsw.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        public void Edit(Category category)
        {
            
            categoryDAC.UpdateById(category);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website_BHDT_BTL_CNWEB_.Models.Entities;

namespace Website_BHDT_BTL_CNWEB_.Models.Functions
{
    public class SanPhamF
    {
        private MyDBContext context;
        public SanPhamF()
        {
            context = new MyDBContext();
        }
        public IQueryable<SanPham> SanPhams
        {
            get { return context.SanPhams; }
        }
       
    }
}
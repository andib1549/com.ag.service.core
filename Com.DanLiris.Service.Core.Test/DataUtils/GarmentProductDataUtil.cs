﻿using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using Com.DanLiris.Service.Core.Test.Helpers;
using Com.DanLiris.Service.Core.Test.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Core.Test.DataUtils
{
    public class GarmentProductServiceDataUtil : BasicDataUtil<CoreDbContext, GarmentProductService, GarmentProduct>, IEmptyData<GarmentProductViewModel>
    {

        public GarmentProductServiceDataUtil(CoreDbContext dbContext, GarmentProductService service) : base(dbContext, service)
        {
        }

        public GarmentProductViewModel GetEmptyData()
        {
            GarmentProductViewModel Data = new GarmentProductViewModel();

            Data.Name = "";
            Data.Code = "";
            Data.UOM.Id = 1;
            Data.UOM.Unit = "";
            
            return Data;
        }

        public override GarmentProduct GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            GarmentProduct TestData = new GarmentProduct
            {
                Code = string.Format("TEST {0}", guid),
                Name = string.Format("TEST {0}", guid),
                Active = true,
                UomId = 1,
                UomUnit = "uom",
                ProductType = "FABRIC",
                Composition = string.Format("TEST {0}", guid),
                Const = string.Format("TEST {0}", guid),
                Yarn = string.Format("TEST {0}", guid),
                Width = string.Format("TEST {0}", guid),
                UId = guid
            };

            return TestData;
        }

        public async Task<GarmentProduct> GetNewData2()
        {
            string guid = Guid.NewGuid().ToString();
            GarmentProduct TestData = new GarmentProduct
            {
                Code = string.Format("TEST {0}", guid),
                Name = string.Format("TEST {0}", guid),
                Active = true,
                UomId = 1,
                UomUnit = "uom",
                ProductType = "FABRIC",
                Composition = string.Format("TEST {0}", guid),
                Const = string.Format("TEST {0}", guid),
                Yarn = string.Format("TEST {0}", guid),
                Width = string.Format("TEST {0}", guid),
                UId = guid
            };

            return TestData;
        }

        public async Task<GarmentProduct> GetNewData3()
        {
            string guid = Guid.NewGuid().ToString();
            GarmentProduct TestData = new GarmentProduct
            {
                Code = "test",
                Name = "test",
                Active = true,
                UomId = 1,
                UomUnit = "uom",
                ProductType = "FABRIC",
                Composition = "test",
                Const = "test",
                Yarn = "test",
                Width = "test",
                UId = guid
            };

            return TestData;
        }

        public override async Task<GarmentProduct> GetTestDataAsync()
        {
            GarmentProduct Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }

        public async Task<GarmentProduct> GetTestDataAsync2()
        {
            var Data = await GetNewData3();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}
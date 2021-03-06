﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webmanager.DAL;

namespace webmanager.Controllers
{
    public class ProductController : Controller
    {
        #region get 接口
        /// <summary>
        /// 获取某个产品信息
        /// </summary>
        /// <param name="id">产品id</param>
        /// <param name="callback">回调函数</param>
        [HttpGet]
        public void GetProductById_get(string id,string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.getDataById(id,type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }

        
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="pagesize">页码</param>
        /// <param name="pageindex">页大小</param>
        /// <param name="callback">回调函数，支持jsonp获取</param>
        [HttpGet]
        public void GetProductsByPage_get(int pagesize, int pageindex,string type, string callback)
        {
            var dal = new ProductDAL();
            var products = dal.getall(type);
            var productssub = products.Skip(pagesize * (pageindex - 1)).Take(pagesize);
            var data = JsonConvert.SerializeObject(productssub);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }

        }

        [HttpGet]
        public void CreateUpdateProduct_get(string id, string datajson,string type, string callback)
        {
            var dal = new ProductDAL();
            var result = dal.CreateUpdateData(id, datajson, type);
            var userdata = JsonConvert.SerializeObject(result);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(userdata);
            }
            else
            {
                Response.Write(callback + "(" + userdata + ")");
            }
        }

        [HttpGet]
        public void DeleteProductById_get(string id,string type, string callback)
        {
            var dal = new ProductDAL();
            var result = dal.delete(id,type);
            var userdata = JsonConvert.SerializeObject(result);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(userdata);
            }
            else
            {
                Response.Write(callback + "(" + userdata + ")");
            }
        }

        [HttpGet]
        public void GetProductByIds_get(string ids, string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.getDataByIds(ids, type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }

        [HttpGet]
        public void DeleteProductByIds_get(string ids, string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.deleteDataByIds(ids, type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }

        #endregion
        #region post接口
        /// <summary>
        /// 获取某个产品信息
        /// </summary>
        /// <param name="id">产品id</param>
        /// <param name="callback">回调函数</param>
        [HttpPost]
        public void GetProductById_post(string id,string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.getDataById(id,type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }

        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="pagesize">页码</param>
        /// <param name="pageindex">页大小</param>
        /// <param name="callback">回调函数，支持jsonp获取</param>
        [HttpPost]
        public void GetProductsByPage_post(int pagesize, int pageindex,string type, string callback)
        {
            var dal = new ProductDAL();
            var products = dal.getall(type);
            var productssub = products.Skip(pagesize * (pageindex - 1)).Take(pagesize);
            var data = JsonConvert.SerializeObject(productssub);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }

        }



        [HttpPost]
        public void CreateUpdateProduct_post(string id, string datajson,string type, string callback)
        {
            var dal = new ProductDAL();
            var result = dal.CreateUpdateData(id, datajson,type);
            var userdata = JsonConvert.SerializeObject(result);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(userdata);
            }
            else
            {
                Response.Write(callback + "(" + userdata + ")");
            }
        }

        [HttpPost]
        public void DeleteProductById_post(string id,string type, string callback)
        {
            var dal = new ProductDAL();
            var result = dal.delete(id,type);
            var userdata = JsonConvert.SerializeObject(result);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(userdata);
            }
            else
            {
                Response.Write(callback + "(" + userdata + ")");
            }
        }

        [HttpPost]
        public void GetProductByIds_post(string ids, string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.getDataByIds(ids, type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }

        [HttpPost]
        public void DeleteProductByIds_post(string ids, string type, string callback)
        {
            var dal = new ProductDAL();
            var product = dal.deleteDataByIds(ids, type);
            var data = JsonConvert.SerializeObject(product);
            if (string.IsNullOrEmpty(callback))
            {
                Response.Write(data);
            }
            else
            {
                var result = callback + "(" + data + ")";
                Response.Write(result);
            }
        }
        #endregion

    }
}

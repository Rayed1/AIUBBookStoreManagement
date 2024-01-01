using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUBBookStoreManagement.Controllers
{
    public class BookController : ApiController
    {


        [HttpPost]
        [Route("api/Book/add")]
        public HttpResponseMessage Register(BookDTO book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BookServices.Add(book);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/User/add")]
        public HttpResponseMessage CreateUser(UserDTO book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BookServices.AddUser(book);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/inventory/add")]
        public HttpResponseMessage CreateInventory(InventoryDTO inv)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BookServices.AddInventory(inv);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/Logincheck")]
        public HttpResponseMessage Logincheck(int intUserId, string password)
        {
            try
            {
                var data = BookServices.Logincheck(intUserId, password);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllUserByArea")]
        public HttpResponseMessage ShowAllUserByArea(string address)
        {
            try
            {
                var data = BookServices.ShowAllUserByArea(address);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllUserByType")]
        public HttpResponseMessage ShowAllUserByType(string t)
        {
            try
            {
                var data = BookServices.ShowAllUserByType(t);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/price/add")]
        public HttpResponseMessage CreatePrice(PriceDTO pri)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = BookServices.AddPrice(pri);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpGet]
        [Route("api/Book/list")]
        public HttpResponseMessage GetAllAdmins()
        {
            try
            {
                var data = BookServices.Show();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ActiveBooks/list")]
        public HttpResponseMessage ShowActiveBooks()
        {
            try
            {
                var data = BookServices.ShowActiveBooks();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllUsers")]
        public HttpResponseMessage ShowAllUsers()
        {
            try
            {
                var data = BookServices.ShowAllUsers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllActiveUsers")]
        public HttpResponseMessage ShowAllActiveUsers()
        {
            try
            {
                var data = BookServices.ShowAllActiveUsers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        

        [HttpGet]
        [Route("api/ReportInventory")]
        public HttpResponseMessage ReportInventory()
        {
            try
            {
                var data = BookServices.ReportInventory();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }

}

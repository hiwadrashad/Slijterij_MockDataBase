using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slijterij_Sjonnie_Loper.Models;
using Slijterij_Sjonnie_Loper.Services;

namespace Slijterij_Sjonnie_Loper.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(ModelCollaborator userModel)
        {
            if (SingletonData.initialized == false)
            {
                SingletonData.StoreDataClient = new MockDataStoreClient();
                SingletonData.StoreDataCollaborator = new MockDataStoreCollaborator();
                SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
            }
            var UserDetails = SingletonData.StoreDataCollaborator.GetItemBynameAndPassword(userModel.Username, userModel.Password);
            if (UserDetails == null)
            {
                userModel.LoginErrorMessage = "Wrong username or password";
                return View("Login", userModel);
            
            }
            return View();
        }
    }
}